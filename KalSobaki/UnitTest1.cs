using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace KalSobaki
{
    public class Tests : DriverHelper
    {
       // public  IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            
            Console.WriteLine("Setup");
            //IWebDriver driver = new ChromeDriver(@"C:\Program Files (x86)\Driver");
            Driver = new ChromeDriver();


            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

        }


        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

          //  Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
          //  Driver.FindElement(By.XPath("input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
          //  IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));

          //  CustomControl control = new CustomControl();
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");


           // comboControl.Clear();
           // comboControl.SendKeys("Almond");
           // Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}