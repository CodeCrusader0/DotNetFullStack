using Microsoft.AspNetCore.Mvc;
using BLL;
using BOL;
using System.Collections.Generic;

using Microsoft.AspNetCore.Cors;
namespace usersWebApi.Controllers;


[ApiController]
[Route("api/[controller]")]

//[Route]	Specifies URL pattern for a controller or action.
public class UsersController : ControllerBase
{

    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

     [EnableCors()]
    [HttpGet()]

    public IEnumerable<Users> Get()
    {
        List<Users> list = UsersManager.GetAllUsers();
        return list;
    }

    [EnableCors()]
    [HttpGet()]
    [Route("{id}")]
    public IEnumerable<Users> GetOne(int id)
    {

        List<Users> list = UsersManager.GetUser(id);
        return list;

    }

    [EnableCors()]
    [HttpDelete()]
    [Route("{id}")]

    public IActionResult DeleteUser(int id)
    {
        UsersManager.DeleteUser(id);
        return NoContent();
    }

    [EnableCors()]
    [HttpPost]

    public void InsertUser(string name, string addr)
    {
        UsersManager.InsertUser(name, addr);
    }
}