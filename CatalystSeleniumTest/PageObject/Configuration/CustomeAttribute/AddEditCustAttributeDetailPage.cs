using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;

namespace CatalystSelenium.PageObject.Configuration.CustomeAttribute
{
    public class AddEditCustAttributeDetailPage : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id,Using = "addAttributeClose")]
        private IWebElement cancel;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement Save;

        [FindsBy(How = How.Id,Using = "addAttributeH4")]
        private IWebElement header;

        public AddEditCustAttributeDetailPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void ClickOnCancel()
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(cancel);
            GenericHelper.WaitForLoadingMask();
        }

        public void ClickOnSave()
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(Save);
            GenericHelper.WaitForLoadingMask();
        }

        public void WaitForHeader()
        {
            GenericHelper.WaitForElement(header);
        }
    }
}
