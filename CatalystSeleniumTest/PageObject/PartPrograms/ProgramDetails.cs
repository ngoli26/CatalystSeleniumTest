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

namespace CatalystSelenium.PageObject.PartPrograms

{
    public class ProgramDetails : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//a[@class='mainNavLink1 headerBar2MessageText']")]
        private IWebElement hPrograms;

        [FindsBy(How = How.XPath, Using = "//div[@class='row viewDetails']/descendant::a[text()='Details']")]
        private IWebElement details;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit a')]")]
        private IWebElement SubmitClaim;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        private IWebElement SubmitOnProgramsPage;


        public ProgramDetails(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        private void ScreenShotofLink(IWebElement element, IWebElement button, string name)
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(element);
            GenericHelper.WaitForElement(button);
            GenericHelper.TakeSceenShot(name);
            JavaScriptExecutorHelper.ScrollElementAndClick(button);
            Thread.Sleep(200);
        }


        public void TakeprogramspageScrshot(string name)
        {
            
            TakeScreenShotofPage(hPrograms, name);


        }

        public void TakeprogramspagedetailsScrshot(string name)
        {
            hPrograms.Click();
            GenericHelper.WaitForLoadingMask();
            details.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            JavaScriptExecutorHelper.ScrollElementAndClick(SubmitClaim);
            // SubmitClaim.Click();
            GenericHelper.WaitForLoadingMask();
        }


        public void TakeSubmitClaimOnProgramsScrshot(string name)
        {
           
            GenericHelper.WaitForLoadingMask();

            SubmitOnProgramsPage.Click();

            GenericHelper.TakeSceenShot(name);
        }


    }
}
