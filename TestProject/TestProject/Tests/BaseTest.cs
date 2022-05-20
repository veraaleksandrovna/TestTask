using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.Services;

namespace TestProject.Tests;

public class BaseTest
{
    protected IWebDriver? Driver;

    [OneTimeSetUp]
    protected void OneTimeSetup()
    {
        Driver = new BrowserService().Driver;
    }

    [OneTimeTearDown]
    protected void OneTimeTearDown()
    {
        Driver!.Quit();
    }
}
