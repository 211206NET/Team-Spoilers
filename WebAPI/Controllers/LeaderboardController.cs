using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
using Microsoft.Extensions.Caching.Memory;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeaderboardController : ControllerBase
{
    private IBL _bl;

    public LeaderboardController(IBL bl){
        _bl = bl;
    }
    // GET: api/values
    // [HttpGet]
    // public IEnumerable<string> Get()
    // {
    //     return new string[] { "value1", "value2" };
    // }

    // GET: api/values/5
    [HttpGet("{id}")]
    public Leaderboard Get(int id)
    {
        return _bl.GetLeaderboardById(id);
    }

    // POST: api/values
    [HttpPost]
    public void Post([FromBody] Leaderboard value)
    {
        _bl.AddLeaderboard(value);
    }

    // PUT: api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _bl.DeleteLeaderboard(id);
    }
}