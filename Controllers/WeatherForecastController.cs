using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace meetup_5_api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static List<User> Users = new List<User>
    {
        new User(1, "Jarek", "dsa@dsa.pl"),
        new User(2, "Arek", "dsa@dsa.pl"),
        new User(3, "Czarek", "dsa@dsa.pl"),
        new User(4, "Marian", "dsa@dsa.pl"),
        new User(5, "Krzysztof", "dsa@dsa.pl"),
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<User> Get()
    {
        return Users;
    }

    [HttpDelete]
    public bool Delete(int id)
    {
        Users = Users.Where(user => !user.Id.Equals(id)).ToList();
        return true;
    }
}
