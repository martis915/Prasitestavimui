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
using OpenQA.Selenium.Interactions;
using Prasitestavimui.Generators;
using System.Xml.Linq;
using Prasitestavimui.POM;

namespace Prasitestavimui
{
    public class OtherCases
    {
        private static string driverPath = "https://www.atea.lt/eshop/products/?filters=S_ALL_Products";
        static IWebDriver driver;


        [SetUp]
        public static void SETUP()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // to disable notification
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.1a.lt";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            GeneralMethods generalMethods = new GeneralMethods(driver);
            //generalMethods.ClickElementBy("//a[@class=\"c-button\"]");


        }

        [TearDown]
        public static void TearDown()
        {
            //driver.Quit();
        }


        [Test]
        public static void NavigationTest()
        {
            TopMenu topMenu = new TopMenu(driver);
            ProductList productList = new ProductList(driver);

            topMenu.SearchByText("iphone 13");
            productList.OpenFirstProduct();
        }


//



    }
}

