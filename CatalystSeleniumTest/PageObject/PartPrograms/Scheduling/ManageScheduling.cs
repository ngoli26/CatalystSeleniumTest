﻿using System.Threading;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace CatalystSelenium.PageObject.PartPrograms.Scheduling
{
    public class ManageScheduling : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//button[text()=' + Add']")]
        private IWebElement Add;


        [FindsBy(How = How.XPath, Using = "//button[text()='Cancel']")]
        private IWebElement Cancel;

        [FindsBy(How = How.Name, Using = "TemplateList")]
        private IWebElement SelectTemplate;

        [FindsBy(How = How.Name, Using = "Groups")]
        private IWebElement SelectGroup;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Log Off')]")]
        private IWebElement logoff;


        public ManageScheduling(IWebDriver driver) : base(driver)
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


        public void TakeManageSchedulingScrShot(string name)
        {
            
            GenericHelper.TakeSceenShot(name);
            GenericHelper.WaitForElement(Add);
            Add.Click();
            GenericHelper.WaitForElement(Cancel);
            DropDownHelper.SelectByVisibleText(By.Name("TemplateList"), "Invitation to Register");
            DropDownHelper.SelectByVisibleText(By.Name("Groups"), "Claim");
            GenericHelper.TakeSceenShot(name);
            GenericHelper.TakeSceenShot(name);
            Cancel.Click();
         

        }

        public void ChooseTemplate(string name)
        {

          
            Add.Click();
            DropDownHelper.SelectByVisibleText(By.Name("TemplateList"), "Invitation to Register");
            DropDownHelper.SelectByVisibleText(By.Name("Groups"), "StaticStage1");
            GenericHelper.TakeSceenShot(name);
            Cancel.Click();
            GenericHelper.WaitForElement(logoff);
            //GenericHelper.WaitForElement();

        }

    }
}
