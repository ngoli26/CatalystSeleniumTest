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

namespace CatalystSelenium.PageObject.Templates


{
    public class ManageTemplates : PageBase
    {
        private IWebDriver _driver;


        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Communication ']")]
        private IWebElement Communication;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Notification Templates']")]
        private IWebElement ManageNotificationTemplates;

     

        [FindsBy(How = How.Id, Using = "mtAddNewBtn")]
        private IWebElement Add;


       // [FindsBy(How = How.XPath, Using = "//button[text()='Cancel']")]
       // private IWebElement Cancel;

        [FindsBy(How = How.Id, Using = "mtSubmitBtn")]
        private IWebElement Cancel;



        public ManageTemplates(IWebDriver driver) : base(driver)
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


        public void TakeManageNotificationScrShot(string name)
        {
            // Communication.Click();
            //GenericHelper.WaitForElement(ManageNotificationTemplates);
            GenericHelper.TakeSceenShot(name);
            Add.Click();
            GenericHelper.WaitForElement(Cancel);
            Cancel.ScrollElementAndClick();
            GenericHelper.TakeSceenShot(name + "1");
        }



    }
}
