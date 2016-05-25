using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.WebElementExtClass;

namespace CatalystSelenium.PageObject.Shop.Category.OpenPrePaid
{
    public class ViewItems : CardStores
    {
        private IWebDriver _driver;

        public ViewItems(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

       

        public CardDetailPage ClickSelectButton(int index)
        {
            QuickSearch("");
            Thread.Sleep(2000);
            var element = GenericHelper.GetVisiblityOfElement(
                By.XPath("//div[@id='listView']/div[" + index + "]//img"));
            element.ScrollElementAndClick();
            GenericHelper.WaitForLoadingMask();
            return new CardDetailPage(_driver);
        }
    }
}
