using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;

namespace SeleniumTest.Tests
{
    class LoginTest
    {
        IWebDriver webDriver = new ChromeDriver();


        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }

        [Test]
        public void LoginPass()
        {
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("standard_user", "secret_sauce");

            StorePage storePage = new StorePage(webDriver);

            Assert.That(storePage.IsButonAddCartExist, Is.True);
        }

        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
