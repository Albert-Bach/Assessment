using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class StorePage
    {
        public StorePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }

        public IWebElement findAddCart => Driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));

        public bool IsButonAddCartExist() => findAddCart.Displayed;

    }
}
