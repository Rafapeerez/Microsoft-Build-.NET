using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Models;

var builder = WebApplication.CreateBuilder(args);

// checks the configuration provider for a connection string named Pizzas. If it doesn't find one, it will use Data Source=Pizzas.db as the connection string. 
// SQLite will map this string to a file.
var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";
builder.Services.AddSqlite<PizzaDb>(connectionString);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description = "Making the Pizzas you love", Version = "v1" });
});
builder.Services.AddDbContext<PizzaDb>(options => options.UseInMemoryDatabase("items"));

var app = builder.Build();
app.UseSwagger(); 
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1"); });

app.MapGet("/", () => "Pizza data practice");
//Get all pizzas
app.MapGet("/pizzas", async (PizzaDb db) => await db.Pizzas.ToListAsync());

//Get a pizza by ID
app.MapGet("pizza/{id}", async (PizzaDb db, int id) => await db.Pizzas.FindAsync(id));

//Update pizza information
app.MapPut("pizza/{id}", async (PizzaDb db, Pizza newPizza, int id) => {
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza is null) return Results.NotFound();
    pizza.Name = newPizza.Name;
    pizza.Description = newPizza.Description;
    await db.SaveChangesAsync();
    return Results.NoContent();
});

//Insert pizza  
app.MapPost("/pizza", async (PizzaDb db, Pizza pizza) => {
    await db.Pizzas.AddAsync(pizza);
    await db.SaveChangesAsync();
    return Results.Created($"/pizza/{pizza.Id}", pizza);
});

//Delete pizza by id
app.MapDelete("pizza/{id}", async (PizzaDb db, int id) => {
    var pizza = await db.Pizzas.FindAsync(id);
    if (pizza is null){
       return Results.NotFound();
    }
    db.Pizzas.Remove(pizza);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();