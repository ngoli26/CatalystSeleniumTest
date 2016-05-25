using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.WebElementExtClass;

namespace CatalystSelenium.PageObject.Claims.ManageCalims.AddProduct
{
    public class AddProducts : PageBase
    {
        private IWebDriver _driver;

        public AddProducts(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        [FindsBy(How = How.CssSelector,Using = ".btn.btn-primary.alignRight")]
        public IWebElement AddPrdButton;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement SaveButton;

        [FindsBy(How = How.XPath, Using = "//button[text()='cancel']")]
        private IWebElement CancelButton;

        [FindsBy(How = How.Id, Using = "ClaimItemsEditForm")]
        private IWebElement AddEditClaimDialog;

        public void ClickAddProductAndTakeScrShot(string name)
        {
            AddPrdButton.ScrollElementAndClick();
            GenericHelper.WaitForElement(AddEditClaimDialog);
            Thread.Sleep(200);
            TakeScreenShot(name);
            CancelButton.ScrollElementAndClick();
            Thread.Sleep(200);
            GenericHelper.WaitForLoadingMask();
        }

    }
}
