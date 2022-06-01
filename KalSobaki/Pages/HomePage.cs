using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace KalSobaki.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement linkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement linkLogOff => Driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => linkLogin.Click();

        public bool IsLogOffExist() => linkLogOff.Displayed;

    }
}
