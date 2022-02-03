using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
using Microsoft.Extensions.Caching.Memory;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SeriesController : ControllerBase
{

    private IBL _bl;

    public SeriesController(IBL bl){
        _bl = bl;
    }
    // GET: api/values
    [HttpGet]
    public List<Series> Get()
    {
        return _bl.GetAllSeries();
    }

    // GET: api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/values/5
    [HttpDelete("{id}")]
    public void Delete(string id)
    {
        _bl.DeleteSeries(id);
    }
}