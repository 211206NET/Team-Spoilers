using Microsoft.AspNetCore.Mvc;
using Models;
using DL;
using BL;
using Microsoft.Extensions.Caching.Memory;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private IBL _bl;
    
    public UserController(IBL bl)
    {
        _bl = bl;
    }

    // GET: api/values
    [HttpGet]
    public List<User> Get()
    {
        List<User> allUser = _bl.GetAllUsers();
        return allUser;
    }

    // GET: api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/values
    [HttpPost]
    //For the moment until i get login and sign up working
    public ActionResult Post([FromBody] User userToAdd)
    {
        _bl.AddUser(userToAdd);
        return Created("Succesffully added", userToAdd);
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
    }
}