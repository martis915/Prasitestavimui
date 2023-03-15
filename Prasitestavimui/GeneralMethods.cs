using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Prasitestavimui
{
    internal class GeneralMethods
    {
        IWebDriver driver;
        public GeneralMethods(IWebDriver driver) { 
            this.driver = driver;
        }

        public void ClickElementBy(string xpath) {

            try { 
            IWebElement el = driver.FindElement(By.XPath(xpath));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
            driver.FindElement(By.XPath(xpath)).Click();
            }
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                IWebElement el = driver.FindElement(By.XPath(xpath));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
                driver.FindElement(By.XPath(xpath)).Click();
            }

        }

        public void ClickElementByJS(string xpath)
        {
                IWebElement el = driver.FindElement(By.XPath(xpath));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
                js.ExecuteScript("arguments[0].click();", el);
        }

        public void EnterTextBy(string xpath, string text) {
            By searchField = By.XPath(xpath);
            driver.FindElement(searchField).SendKeys(text);
        }


        public int GetElementsCountByXpath(string xpath) { 
            By elements = By.XPath(xpath);
            return driver.FindElements(elements).Count();
        }

        public void CheckElementExistsByXpath(string xpath) {
            driver.FindElement(By.XPath(xpath));
        }
        public void CheckElementExistsByID(string id)
        {
            driver.FindElement(By.Id(id));
        }


    }
}
