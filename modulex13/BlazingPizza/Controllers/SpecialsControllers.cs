using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazingPizza.Data;

namespace BlazingPizza.Controllers;

//This class creates a controller that allows us to query the database for pizza specials and returns them as JSON at the (http://localhost:{PORT}/specials) URL.

[Route("specials")]
[ApiController]
public class SpecialsController : Controller{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db){
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials(){
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}