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
    public Series Get(int id)
    {
        return _bl.GetSeriesById(id);
    }

    [HttpGet("{imdbid}")]
    public Series Get(string imdbid){
        return _bl.GetSeriesByIMDbId(imdbid);
    }

    [HttpGet("{title}")]
    public Series GetBySeries(string title){
        return _bl.GetSeriesByTitle(title);
    }

    // POST: api/values
    [HttpPost]
    public void Post([FromBody] Series value)
    {
        _bl.AddSeries(value);
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