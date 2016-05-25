using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;

namespace CatalystSelenium.PageObject.IncentivePage
{
    public class OverlaySetup : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//a[text()='Overlay Setup']")]
        private IWebElement OverlaySetups;

        [FindsBy(How = How.XPath, Using = "//div[@id='accordion']/descendant::div[@id='rendered'][position()=7]/button")]
        private IWebElement OverlaySetupsNext;

        public OverlaySetup(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void ClickOverlaySetupAndNext()
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(OverlaySetups);
            GenericHelper.WaitForLoadingMask();
            TakeScreenShot(string.Format("OverlaySetups-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            JavaScriptExecutorHelper.ScrollElementAndClick(OverlaySetupsNext);
            GenericHelper.WaitForLoadingMask();
            JavaScriptExecutorHelper.ScrollElementAndClick(OverlaySetups);
            GenericHelper.WaitForLoadingMask();
        }
    }
}
