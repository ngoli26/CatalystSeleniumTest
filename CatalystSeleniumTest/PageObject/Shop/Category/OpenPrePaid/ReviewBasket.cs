using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.WebElementExtClass;

namespace CatalystSelenium.PageObject.Shop.Category.OpenPrePaid
{
    [TestClass]
    public class ReviewBasket : CardStores
    {
        private IWebDriver _driver;

        public ReviewBasket(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void DeleteFromCart(int index)
        {
            var element =
                GenericHelper.GetVisiblityOfElement(
                    By.XPath("//div[@id='CartListView']/div[position()=" + index + "]//a[@id='RemoveButton']"));
            element.ScrollElementAndClick();
            GenericHelper.WaitForLoadingMask();
        }

        public void ClickUpdateButton(int index)
        {
            var element =
                GenericHelper.GetVisiblityOfElement(
                    By.XPath("//div[@id='CartListView']/div[position()=" + index + "]//a[@id='UpdateQuantityButton']"));
            element.ScrollElementAndClick();
            GenericHelper.WaitForLoadingMask();
        }
    }
}
