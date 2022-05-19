using NUnit.Framework;
using TestProject.Pages;

namespace TestProject.Tests;

[TestFixture]
public class DropDownListTest: BaseTest
{
    [Test]
    public void DisplyTest()
    {
        var page = new DropDownPage(Driver, true);
        
        Assert.IsTrue(page.Logo.Displayed);
    }
}
