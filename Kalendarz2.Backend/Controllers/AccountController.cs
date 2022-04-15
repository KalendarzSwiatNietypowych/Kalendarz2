using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Interfaces.Facades;
using Microsoft.AspNetCore.Mvc;

namespace Kalendarz2.Backend.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountFcd _accountFcd;

    public AccountController(IAccountFcd accountFcd)
    {
        _accountFcd = accountFcd;
    }

    [HttpPost("register")]
    public ActionResult RegisterUser([FromBody] RegisterDTO registerDTO)
    {
        return Ok(_accountFcd.RegisterUser(registerDTO));
    }

/*    [HttpPost("login")]
    public ActionResult LoginUser([FromBody] LoginDTO loginDTO)
    {
        return Ok(_accountFcd.LoginUser(loginDTO));
    }

    [HttpPut("edit")]
    public ActionResult EditUser([FromBody] EditUserDTO editUserDTO, [FromHeader] string authorization)
    {
        var result = _accountFcd.UpdateUser(editUserDTO);
        result.Token = authorization.Split(' ')[1];
        return Ok(result);
    }*/
}