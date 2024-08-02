
using System.ComponentModel.DataAnnotations;

namespace PassWordsCriator.API.Services;

public class PasswordService : IPasswordService
{
    [RegularExpression("^(?=.[a-z])(?=.[A-Z])(?=.\\d)(?=.[@$!%?&])[A-Za-z\\d@$!%?&]{8,}$", ErrorMessage = "")]
    private string password = string.Empty;
    private List<string> passWords = new();
    private string passwordAux = string.Empty;

    readonly string hardBase = "0123456789!@#$%&*()[]+-/|abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    readonly string mediumBase = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public IEnumerable<string> GetHardList()
    {
        Random random = new Random();
        int contador = 0;

        do
        {
            for (int i = 0; i <= 14; i++)
            {
                passwordAux += (mediumBase.Substring(random.Next(0, mediumBase.Length - 1), 1));
            }
            passWords.Add(passwordAux);
            contador++;
            passwordAux = string.Empty;
        } while (contador < 14);

        return passWords;
    }

    public string GetHardPassword()
    {
        Random random = new Random();
        for (int i = 0; i <= 14; i++)
        {
            password += hardBase.Substring(random.Next(0, hardBase.Length - 1), 1);
        }
        return password;
    }

    public IEnumerable<string> GetMediumList()
    {
        Random random = new Random();
        int contador = 0;

        do
        {
            for (int i = 0; i <= 14; i++)
            {
                passwordAux += (mediumBase.Substring(random.Next(0, mediumBase.Length - 1), 1));
            }
            passWords.Add(passwordAux);
            contador++;
            passwordAux = string.Empty;
        } while (contador < 20);

        return passWords;
    }

    public string GetMediumPassword()
    {
        Random random = new Random();
        for (int i = 0; i <= 9; i++)
        {
            password += mediumBase.Substring(random.Next(0, mediumBase.Length - 1), 1);
        }
        return password;
    }
}
