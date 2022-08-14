using Microsoft.AspNetCore.Mvc;
using Showplan.Tests.Data;
using WebApiTest.Data;

namespace WebApiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly StackExchangeContext _db;

    public UsersController(StackExchangeContext db)
    {
        _db = db;
    }

    [HttpGet(Name = "GetActiveUsers")]
    public IEnumerable<int> Get()
    {
        return _db.Users
            .Where(i => (i.Votes.Count > 10 || i.Comments.Count > 10) && i.Age > 50)
            .Select(i => i.Id)
            .TagWithSource()
            .ToList();
    }
}
