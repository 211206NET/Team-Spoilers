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
    // GET: api/values
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET: api/values/5
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/values
    public void Post([FromBody] string value)
    {
    }

    // PUT: api/values/5
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE: api/values/5
    public void Delete(int id)
    {
    }
}