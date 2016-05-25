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

namespace CatalystSelenium.PageObject.Triggers


{
    public class ManageTriggers : PageBase
    {
        private IWebDriver _driver;


       

        [FindsBy(How = How.XPath, Using = "//button[text()=' + New Notification']")]
        private IWebElement NewTrigger;


        [FindsBy(How = How.XPath, Using = "//button[text()='Cancel']")]
        private IWebElement Cancel;


        [FindsBy(How = How.Name, Using = "TriggerCode")]
        private IWebElement AddTrigger;

        [FindsBy(How = How.Name, Using = "Batch")]
        private IWebElement AddTemplate;

        [FindsBy(How = How.XPath, Using = "//input[@name='IsActive']")]
        private IWebElement Active;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Log Off')]")]
        private IWebElement logoff;

        public ManageTriggers(IWebDriver driver) : base(driver)
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


        public void TakeManageNotificationTriggerScrShot(string name)
        {


            NewTrigger.Click();
            GenericHelper.WaitForLoadingMask();
            DropDownHelper.SelectByVisibleText(By.Name("TriggerCode"), "Contact Us");
            DropDownHelper.SelectByVisibleText(By.Name("Batch"), "Invitation to Register");
            Active.Click();
            GenericHelper.TakeSceenShot(name);
           
            Cancel.Click();
          

        }



    }
}
