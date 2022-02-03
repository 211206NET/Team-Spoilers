using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
using Microsoft.Extensions.Caching.Memory;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GameController : ControllerBase
{
    private IBL _bl;

    public GameController(IBL bl){
        _bl = bl;
    }
    // GET: api/values
    [HttpGet]
    public List<Game> Get()
    {
        return _bl.GetAllGames();
    }

    // GET: api/values/5
    [HttpGet("{id}")]
    public Game Get(int id)
    {
        return _bl.GetGameById(id);
    }

    // POST: api/values
    [HttpPost]
    public void Post([FromBody] Game value)
    {
        _bl.AddGame(value);
    }

    // PUT: api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] int winner)
    {
        _bl.UpdateGame(id, winner);
    }

    // DELETE: api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _bl.DeleteGame(id);
    }
}