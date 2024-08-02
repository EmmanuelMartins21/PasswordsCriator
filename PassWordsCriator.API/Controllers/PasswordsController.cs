using Microsoft.AspNetCore.Mvc;
using PassWordsCriator.API.Services;

namespace PassWords.Controllers;

[ApiController]
[Route("passwords")]
public class PasswordsController : Controller
{
    private readonly IPasswordService _service;

    public PasswordsController(IPasswordService passwordService)
    {
        _service = passwordService;
    }

    [HttpGet("medium")]
    public string GetMediumPassword()
    {
        return _service.GetMediumPassword();
    }

    [HttpGet("hard")]
    public string GetHardPassword()
    {
        return _service.GetHardPassword();
    }

    [HttpGet("hard/list")]
    public ActionResult<IEnumerable<string>> GetHardList()
    {
        var result = _service.GetHardList() != null ? _service.GetHardList().ToList() : new();
        return Ok(result);
    }

    [HttpGet("medium/list")]
    public ActionResult<IEnumerable<string>> GetMediumList()
    {
        var result = _service.GetMediumList() != null ? _service.GetMediumList().ToList() : new();
        return Ok(result);
    }
}
