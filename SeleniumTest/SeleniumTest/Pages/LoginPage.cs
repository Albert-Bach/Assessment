using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class LoginPage
    {

        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebDriver Driver { get; }
          
        IWebElement txtUsername => Driver.FindElement(By.Name("user-name"));

        IWebElement txtPassword => Driver.FindElement(By.Name("password"));

        IWebElement btnLogin => Driver.FindElement(By.Name("login-button"));

        public void Login(string userName, string password)
        {

            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();

        }
    }
}
