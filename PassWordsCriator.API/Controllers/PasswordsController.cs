using Microsoft.AspNetCore.Mvc;
using PassWordsCriator.API.Services;
using System.ComponentModel.DataAnnotations;

namespace PassWords.Controllers;

[ApiController]
[Route("passwords")]
public class PasswordsController : Controller
{
    private readonly IPasswordService _passwordService;

    public PasswordsController(IPasswordService passwordService)
    {
        _passwordService = passwordService;
    }

    [HttpGet("medium")]
    public string GetMediumPassword()
    {
        return _passwordService.GetMediumPassword();
    }

    [HttpGet("hard")]
    public string GetHardPassword()
    {
        return _passwordService.GetHardPassword();
    }

    [HttpGet("hard/list")]
    public ActionResult<IEnumerable<string>> GetHardList()
    {
        var result = _passwordService.GetHardList() != null ? _passwordService.GetHardList().ToList() : new();
        return Ok(result);
    }

    [HttpGet("medium/list")]
    public ActionResult<IEnumerable<string>> GetMediumList()
    {
        var result = _passwordService.GetMediumList() != null ? _passwordService.GetMediumList().ToList() : new();
        return Ok(result);
    }
}
