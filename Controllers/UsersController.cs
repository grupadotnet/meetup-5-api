using Microsoft.AspNetCore.Mvc;

namespace meetup_5_api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase {
  private static readonly string[] Users = new[]
  {
      "Jarek", "Franek", "Arek", "Mrek", "Czesiek"
  };

  [HttpGet]
  public IActionResult Get() {
    return Ok(Users);
  } 
}