using OpenQA.Selenium;
using TestProject.Pages;

namespace TestProject.Steps;

public class LoginStep : BaseStep
{
    public LoginStep(IWebDriver driver) : base(driver)
    {
    }

    public void Login(string userName, string password)
    {
        var loginPage = new LoginPage(Driver, true);
        loginPage.UsernameInput.SendKeys(userName);
        loginPage.PasswordInput.SendKeys(password);
        loginPage.LoginButton.Submit();
    }
}