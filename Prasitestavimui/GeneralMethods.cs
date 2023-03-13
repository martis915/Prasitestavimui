using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasitestavimui
{
    internal class GeneralMethods
    {
        IWebDriver driver;
        public GeneralMethods(IWebDriver driver) { 
            this.driver = driver;
        }

        public void ClickElementBy(string xpath) {
            int tries = 0;
            while (tries<5) {
                try
                {
                    IWebElement el = driver.FindElement(By.XPath(xpath));
                    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", el);
                    el.Click();
                    break;
                }
                catch (Exception e )
                {
                    tries++;
                    Console.WriteLine("Could not find element " + xpath +"\n"+ e);
                    if (tries >= 3)
                    {
                        IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)driver;
                        javascriptExecutor.ExecuteScript("arguments[0].click();",driver.FindElement(By.XPath(xpath)));

                        Assert.Fail("Failed after " + tries + " Tries\n" + e);
                    }
                }
            }
        }

        public void EnterTextBy(string xpath, string text) {
            By searchField = By.XPath(xpath);
            driver.FindElement(searchField).SendKeys(text);
        }

    }
}
