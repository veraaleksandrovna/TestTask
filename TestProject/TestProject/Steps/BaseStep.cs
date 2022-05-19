using OpenQA.Selenium;

namespace TestProject.Steps;

public class BaseStep
{
    protected static IWebDriver Driver;

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}