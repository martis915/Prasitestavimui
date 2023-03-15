using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasitestavimui.POM
{
    internal class ProductCard
    {
        IWebDriver driver;
        GeneralMethods genm ;
        public ProductCard(IWebDriver driver) { 
            this.driver = driver;
            genm = new GeneralMethods(driver);
        }

        public void CheckBreadcrumbsCount() {
            int CountOfBreadcrumbs = genm.GetElementsCountByXpath("//span[@itemprop=\"itemListElement\"]");
            Assert.AreEqual(4, CountOfBreadcrumbs, "Expected 4 breadcrumbs, but got : " + CountOfBreadcrumbs);
        }

    }
}
