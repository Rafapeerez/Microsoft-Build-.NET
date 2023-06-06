using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

//This class creates a database context we can use to register a database service. The context also allows us to have a controller that accesses the database.
public class PizzaStoreContext : DbContext{
    public PizzaStoreContext(DbContextOptions options) : base(options){
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}