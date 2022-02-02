using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
using Microsoft.Extensions.Caching.Memory;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BingoCardController : ControllerBase
{
    private IBL _bl;

    public BingoCardController(IBL bl)
    {
        _bl = bl;
    }

    // GET: api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET: api/values/5
    [HttpGet("{id}")]
    public BingoCard Get(int id)
    {
        return _bl.GetBingoCardById(id);
    }

    [HttpGet("Get Bingo Cards by{UserID}")]
    public ActionResult<BingoCard> GetBingoCards(int userID)
    {
        List<BingoCard> allCards = _bl.GetBingoCardsbyUserId(userID);
        return Ok(allCards);
    }

    // POST: api/values
    [HttpPost]
    public void Post([FromBody] BingoCard value)
    {
        _bl.AddBingoCard(value);
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
        _bl.DeleteBingoCard(id);
    }
}