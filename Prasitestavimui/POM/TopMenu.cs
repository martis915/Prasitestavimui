using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasitestavimui.POM
{
    internal class TopMenu
    {
        IWebDriver driver;
        GeneralMethods generalMethods;

        string SearchFieldXpath = "//input[contains(@class,'main-search-input') and @autocomplete=\"off\"]";
        string SearchButtonXpath = "//div[@class=\"main-search__submit\"]";


        public TopMenu(IWebDriver driver) {
            this.driver = driver;
            generalMethods = new GeneralMethods(driver);
        }

        public void SearchByText(string text) {
            generalMethods.EnterTextBy(SearchFieldXpath, text);
            generalMethods.ClickElementBy(SearchButtonXpath);
        }
        public void EnterTextToSearch(string text)
        {
            generalMethods.EnterTextBy(SearchFieldXpath, text);
        }
    }
}
