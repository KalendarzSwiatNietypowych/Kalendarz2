using Kalendarz2.Domain.Common;
using Kalendarz2.Domain.Common.Helper;
using Kalendarz2.Domain.Common.Models.User;
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
        registerDTO.Email.ToLower();
        return Ok(_accountFcd.RegisterUser(registerDTO));
    }

    [HttpPost("login")]
    public ActionResult LoginUser([FromBody] LoginDTO loginDTO)
    {
        loginDTO.Email.ToLower();
        return Ok(_accountFcd.LoginUser(loginDTO));
    }

    [Authorize]
    [HttpPut("edit")]
    public ActionResult EditUser([FromBody] EditUserDTO editUserDTO)
    {
        var result = _accountFcd.UpdateUser(editUserDTO);
        return Ok(result);
    }

    [HttpGet("verify/{userId}")]
    public ActionResult UserVerification([FromRoute] int userId)
    {
        return Ok(_accountFcd.UserVerification(userId));
    }

    [HttpGet("resetPassword")]
    public ActionResult SendResetLink([FromBody] EmailDTO resetEmail)
    {
        return Ok(_accountFcd.SendResetLinkAsync(resetEmail));
    }

    [HttpPost("resetPassword/{UserId}")]
    public ActionResult ResetPassword([FromRoute] int UserId, [FromBody] ResetPasswordDTO resetPassword)
    {
        resetPassword.UserId = UserId;
        return Ok(_accountFcd.ResetPassword(resetPassword));
    }

    [Authorize]
    [HttpPost("deleteUser")]
    public ActionResult DeleteUser([FromBody] DeleteUserDTO deleteUser)
    {
        return Ok(_accountFcd.DeleteAccount(deleteUser));
    }

    [Authorize]
    [HttpPost("changePassword")]
    public ActionResult ChangePassword([FromBody] ChangePasswordDTO passwordDTO)
    {
        return Ok(_accountFcd.ChangePassword(passwordDTO));
    }
}