using Microsoft.AspNetCore.Mvc;

namespace PassWordsCriator.API.Services;

public interface IPasswordService
{
    string GetMediumPassword();
    IEnumerable<string> GetMediumList();
    string GetHardPassword();
    IEnumerable<string> GetHardList();
}
