using PassWordsCriator.API.Services;

namespace PassWordsCriator.Test;

public class UnitTest
{
    private readonly PasswordService _service;

    public UnitTest()
    {
        _service = new PasswordService();
    }

    [Fact]
    public void TestListIsCompleted()
    {
        // Arrange
        short listMediumSize = 20;
        // Act
        int result = _service.GetMediumList().Count();
        // Assert
        Assert.Equal(result, listMediumSize);
    }

    [Fact]
    public void GetMediumPassword_ShouldReturnValidPassword()
    {
        string password = _service.GetMediumPassword();
        Assert.NotNull(password);
        Assert.Matches("^[A-Za-z\\d]{10}$", password);
    }

    [Fact]
    public void GetHardList_ShouldReturn14Passwords()
    {
        IEnumerable<string> passwords = _service.GetHardList();
        Assert.NotNull(passwords);
        Assert.Equal(14, ((List<string>)passwords).Count);
    }

    [Fact]
    public void GetMediumList_ShouldReturn20Passwords()
    {
        IEnumerable<string> passwords = _service.GetMediumList();
        Assert.NotNull(passwords);
        Assert.Equal(20, ((List<string>)passwords).Count);
    }

    [Fact]
    public void GetHardPassword_ShouldReturnDifferentPasswords()
    {
        string password1 = _service.GetHardPassword();
        string password2 = _service.GetHardPassword();

        Assert.NotEqual(password1, password2);
    }

    [Fact]
    public void GetMediumPassword_ShouldReturnDifferentPasswords()
    {
        string password1 = _service.GetMediumPassword();
        string password2 = _service.GetMediumPassword();
        Assert.NotEqual(password1, password2);
    }
}