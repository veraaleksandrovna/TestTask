using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProject.Pages;

namespace TestProject.Tests;

[TestFixture]
public class DropDownListTest: BaseTest
{
    [Test]
    public void CountDropDownOptionsTest()
    {
        var dropDownPage = new DropDownPage(Driver, true);
        
        Assert.IsTrue(dropDownPage.Logo.Displayed);

        SelectElement selectList = new SelectElement(Driver.FindElement(By.TagName("select")));
        IList<IWebElement> elementCount = selectList.Options;
        
        var expectedValue = 249;
        var countOptions = elementCount.Count;
        Assert.AreEqual(expectedValue, countOptions);
    }
    
}
