using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Prasitestavimui
{
    internal class GeneralMethods
    {
        IWebDriver driver;
        DefaultWait<IWebDriver> wait;

        public GeneralMethods(IWebDriver driver) { 
            this.driver = driver;
            wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

        public void ClickElementBy(string xpath) {
        
            wait.Message = "Cookie accept button was not found";
            IWebElement elm = wait.Until(x => x.FindElement(By.XPath(xpath)));
            elm.Click();

        }

        public void ClickElementByJS(string xpath)
        {
                IWebElement el = driver.FindElement(By.XPath(xpath));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
                js.ExecuteScript("arguments[0].click();", el);
        }

        public void EnterTextBy(string xpath, string text) {
          
            wait.Message = "Cookie accept button was not found";
            IWebElement elm = wait.Until(x => x.FindElement(By.XPath(xpath)));
            elm.SendKeys(text);
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

        public string getUsername() {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Work\Documents\Projects\Prasitestavimui\Prasitestavimui\LoginDetails.txt");
            return lines[1];
        }


    }
}
