using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V108.CSS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Prasitestavimui.Generators;
using System.Xml.Linq;
using Prasitestavimui.POM;

namespace Prasitestavimui
{
    public class OtherCases
    {
        static IWebDriver driver;
        static GeneralMethods generalMethods;

        [SetUp]
        public static void SETUP()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // to disable notification
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.1a.lt";
            generalMethods = new GeneralMethods(driver);


        }
        [TearDown]
        public static void TearDown()
        {
            //driver.Quit();
        }
        [Test]
        public static void CheckProductCardElements()
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Message = "LAbas";
            IWebElement elm = wait.Until(x => x.FindElement(By.XPath("//AA")));
            elm.Click();

        }





    }
}

