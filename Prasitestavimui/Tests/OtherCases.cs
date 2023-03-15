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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            generalMethods = new GeneralMethods(driver);
            generalMethods.ClickElementBy("//a[@class=\"c-button\"]");


        }
        [TearDown]
        public static void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public static void CheckProductCardElements()
        {
            TopMenu topMenu = new TopMenu(driver);
            ProductList productList = new ProductList(driver);
            ProductCard productCard = new ProductCard(driver);

            topMenu.SearchByText("iphone 13");
            productList.OpenFirstProduct();
            productCard.CheckBreadcrumbsCount();
            generalMethods.CheckElementExistsByID("add_to_cart_btn");
            generalMethods.CheckElementExistsByID("description-anchor");
            generalMethods.CheckElementExistsByID("also-bought-vue-wrapper");
        }





    }
}

