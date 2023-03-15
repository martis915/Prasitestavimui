﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasitestavimui.POM
{
    internal class ProductList
    {
        IWebDriver driver;
        GeneralMethods generalMethods;

        public ProductList(IWebDriver driver) {
            this.driver = driver;
            generalMethods = new GeneralMethods(driver);
        }

        public void OpenFirstProduct() {
            generalMethods.ClickElementByJS("(//a[contains(@class,'product-image')])[1]");
        }
        public void OpenSEcondProduct()
        {
            generalMethods.ClickElementBy("(//a[contains(@class,'product-image')])[2]");
        }
        public void OpenThirdProduct()
        {
            generalMethods.ClickElementBy("(//a[contains(@class,'product-image')])[3]");
        }

    }
}
