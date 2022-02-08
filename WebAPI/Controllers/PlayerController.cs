using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
using Microsoft.Extensions.Caching.Memory;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayerController : ControllerBase
{
    private IBL _bl;

    public PlayerController(IBL bl){
        _bl = bl;
    }
    // GET: api/values
    [HttpGet]
    public List<Player> Get()
    {
        List<Player> allPlayer = _bl.GetAllPlayers();
        return allPlayer;
    }

    // GET: api/values/5
    [HttpGet("{id}")]
    public List<Player> Get(int id)
    {
        return _bl.GetPlayersByUserId(id);
    }

    // POST: api/values
    [HttpPost]
    public void Post([FromBody] Player value)
    {
        _bl.AddPlayer(value);
    }

    // PUT: api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] int master)
    {
        _bl.UpdatePlayer(id, master);
    }

    // DELETE: api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _bl.DeletePlayer(id);
    }
}