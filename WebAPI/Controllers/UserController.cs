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
    public User Get(int id)
    {
        return _bl.GetUserById(id);
    }

    [HttpGet("{username} {password}")]
    public ActionResult UserLogin(string username, string password){
        if(_bl.Login(username, password)){
            return Ok("Welcome!");
        }
        else{
            return BadRequest("I don't know you.");
        }
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
    public void Put(int id, [FromBody]  BingoCard value)
    {
        _bl.AddCardToUser(id, value);
    }

    // DELETE: api/values/5
    [HttpDelete("{id}")]
    public void Delete(string id)
    {
        _bl.DeleteUser(id);
    }
}