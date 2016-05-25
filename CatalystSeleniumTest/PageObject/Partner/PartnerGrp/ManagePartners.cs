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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.PageObject.Partners

{
    public class ManagePartners : PageBase
    {
        private IWebDriver _driver;
        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Partner Groups']")]
        private IWebElement PartnerGroups;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Partners']")]
        private IWebElement ManagePartners1;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Partner ']")]
        private IWebElement Partner;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-default dropdown-toggle'][position()=1]")]
        private IWebElement Action;

        [FindsBy(How = How.LinkText, Using = "Partner Profile")]
        private IWebElement PartProfile;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement Save;

        [FindsBy(How = How.XPath, Using = "//button[text()='Ignore']")]
        private IWebElement Ignore;

        [FindsBy(How = How.Name, Using = " PartnerName")]
        private IWebElement PartnerName;

        [FindsBy(How = How.Name, Using = "PartnerNumber")]
        private IWebElement PartnerNumber;


        [FindsBy(How = How.Name, Using = "Address1")]
        private IWebElement Address1;

        [FindsBy(How = How.Name, Using = "Address2")]
        private IWebElement Address2;

        [FindsBy(How = How.Name, Using = "Address3")]
        private IWebElement Address3;

        [FindsBy(How = How.Name, Using = "City")]
        private IWebElement City;

        [FindsBy(How = How.Name, Using = "State")]
        private IWebElement State;

        [FindsBy(How = How.Name, Using = "PostalCode")]
        private IWebElement PostalCode;

        [FindsBy(How = How.Name, Using = "Country")]
        private IWebElement Country;

        [FindsBy(How = How.Name, Using = "ContactName")]
        private IWebElement ContactName;

        [FindsBy(How = How.Name, Using = "Phone")]
        private IWebElement Phone;

        [FindsBy(How = How.Name, Using = "Fax")]
        private IWebElement Fax;

        [FindsBy(How = How.Name, Using = "EmailAddress")]
        private IWebElement EmailAddress;

        [FindsBy(How = How.Name, Using = "PartnerWebsite")]
        private IWebElement PartnerWebsite;

        [FindsBy(How = How.Name, Using = "PartnerType")]
        private IWebElement PartnerType;

        [FindsBy(How = How.Name, Using = "PartnerTier")]
        private IWebElement PartnerTier;

        [FindsBy(How = How.XPath, Using = "//input[@name='partLevel' and @value='1']")]
        private IWebElement Companylevel;

        [FindsBy(How = How.XPath, Using = "//input[@name='partLevel' and @value='2']")]
        private IWebElement InvidualLevel;

        


        public ManagePartners(IWebDriver driver) : base(driver)
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


        public void TakeManagePartnerScrShot(string name)
        {

            Action.Click();
            GenericHelper.TakeSceenShot(name);

        }


        public void TakePatnerGrpScrShot(string name)
        {
            Partner.Click();
            GenericHelper.WaitForElement(PartnerGroups);
            TakeScreenShotofPage(PartnerGroups, name);
        }




        public void TakePartnerprofile(string name)
        {
            Partner.Click();
            GenericHelper.WaitForElement(ManagePartners1);
            ManagePartners1.Click();
            Action.Click();
            GenericHelper.WaitForElement(PartProfile);
            PartProfile.Click();
           
            GenericHelper.WaitForElement(Save);
            JavaScriptExecutorHelper.ScrollElementAndClick(Save);


            GenericHelper.WaitForLoadingMask();


            GenericHelper.WaitForElement(Ignore);
            Ignore.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
        }

        public void PartnerValidateElements()
        {
         
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PartnerName")), "PartnerName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PartnerNumber")), "PartnerNumber Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Address1")), "Address1 Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Address2")), "Address2 Element Not Found");
           Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Address3")), "Address3 Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("City")), "City Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("State")), "State Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PostalCode")), "PostalCode Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Country")), "Country Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ContactName")), "ContactName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Phone")), "Phone Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Fax")), "Fax Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("EmailAddress")), "EmailAddress Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PartnerWebsite")), "PartnerWebsite Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PartnerType")), "PartnerType Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PartnerTier")), "PartnerTier Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Companylevel")), "Companylevel Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("InvidualLevel")), "InvidualLevel Element Not Found");


        }
    }
}
