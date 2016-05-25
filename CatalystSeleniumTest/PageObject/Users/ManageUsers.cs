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

namespace CatalystSelenium.PageObject.Users

{
    public class ManageUsers : PageBase
    {
        private IWebDriver _driver;


        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='User ']")]
        private IWebElement User;

        [FindsBy(How = How.XPath,Using = "//button[@class='btn btn-default dropdown-toggle'][position()=1]")]
        private IWebElement Action;

        [FindsBy(How = How.LinkText, Using = "Edit Profile")]
        private IWebElement EditUserProfile;

        [FindsBy(How = How.XPath, Using = "//a[text()=' Impersonate'][position()=1]")]
        private IWebElement ImpersonateUser;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-small btn-default impersonateBtn'][text()='Stop Impersonating ']")]
        private IWebElement StopImpersonate;

        [FindsBy(How = How.XPath, Using = "//button[text()='Reset All']")]
        private IWebElement ResetAll;


        [FindsBy(How = How.LinkText, Using = "Manage Access")]
        private IWebElement UserAccess;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement Save;

        [FindsBy(How = How.XPath, Using = "//button[text()='Ignore']")]
        private IWebElement Ignore;

        [FindsBy(How = How.XPath, Using = "//label[text()='User Status")]
        private IWebElement UserStatus;

        [FindsBy(How = How.XPath, Using = "//label[text()='Tax Info")]
        private IWebElement TaxInfo;

      

        [FindsBy(How = How.XPath, Using = "//label[text()='Password")]
        private IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//label[text()='T&C's")]
        private IWebElement TC;

        [FindsBy(How = How.XPath, Using = "//label[text()='Test User")]
        private IWebElement TestUser;

        [FindsBy(How = How.XPath, Using = "//label[text()='User Profile for: ")]
        private IWebElement UserProfileName;

        [FindsBy(How = How.Name, Using = "Title")]
        private IWebElement Title;


        [FindsBy(How = How.Name, Using = "UserName")]
        private IWebElement UserName;


        [FindsBy(How = How.Name, Using = "FirstName")]
        private IWebElement FirstName;


        [FindsBy(How = How.Name, Using = "LastName")]
        private IWebElement LastName;



        [FindsBy(How = How.Name, Using = "EmailAddress")]
        private IWebElement EmailAddress;


        [FindsBy(How = How.Name, Using = "DateOfBirth")]
        private IWebElement DateOfBirth;


        [FindsBy(How = How.Name, Using = "JobTitle")]
        private IWebElement JobTitle;




        [FindsBy(How = How.Name, Using = "AddressLine1")]
        private IWebElement AddressLine1;

        [FindsBy(How = How.Name, Using = "AddressLine2")]
        private IWebElement AddressLine2;


        [FindsBy(How = How.Name, Using = "AddressLine3")]
        private IWebElement AddressLine3;


        [FindsBy(How = How.Name, Using = "City")]
        private IWebElement City;


        [FindsBy(How = How.Name, Using = "State")]
        private IWebElement State;

        [FindsBy(How = How.Name, Using = "PostalCode")]
        private IWebElement PostalCode;

        [FindsBy(How = How.Name, Using = "Country")]
        private IWebElement Country;

        [FindsBy(How = How.Name, Using = "PhoneNumber")]
        private IWebElement PhoneNumber;


        [FindsBy(How = How.Name, Using = "FaxNumber")]
        private IWebElement FaxNumber;

        [FindsBy(How = How.Name, Using = "Role")]
        private IWebElement Role;

        [FindsBy(How = How.Name, Using = "JobFunction")]
        private IWebElement JobFunction;

        [FindsBy(How = How.Name, Using = "PreferredLanguage")]
        private IWebElement PreferredLanguage;

        [FindsBy(How = How.Name, Using = "Partner")]
        private IWebElement Partner;

        [FindsBy(How = How.Name, Using = "AssignPartnerGroup")]
        private IWebElement AssignPartnerGroup;



        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement SaveUser;

       





        public ManageUsers(IWebDriver driver) : base(driver)
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



        public void UserAccessValidateElements()
        {
            GenericHelper.WaitForLoadingMask();
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ResetAll")), "ResetAll Element Not Found");
          //  Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("UserStatus")), "UserStatus Element Not Found");
           // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxInfo")), "TaxInfo Element Not Found");
           //  Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Password")), "Password Element Not Found");
           // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TC")), "TC Element Not Found");
           // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TestUser")), "TestUser Element Not Found");
         
       }







        public void TakeUserprofile(string name)
        {
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(Action);
            Action.Click();
            GenericHelper.WaitForElement(EditUserProfile);
            EditUserProfile.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
          
        }

        public void UserProfileValidateElements()
        {
            
            //Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("UserProfileName")), "UserProfileName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Title")), "Title Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("UserName")), "UserName Element Not Found");
             Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("FirstName")), "FirstName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("LastName")), "LastName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("EmailAddress")), "EmailAddress Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("DateOfBirth")), "DateOfBirth Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("JobTitle")), "JobTitle Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine1")), "AddressLine1 Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine2")), "AddressLine2 Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine3")), "AddressLine3 Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("State")), "State Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("City")), "City Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PostalCode")), "PostalCode Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Country")), "Country Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PhoneNumber")), "PhoneNumber Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("FaxNumber")), "FaxNumber Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Role")), "Role Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("JobFunction")), "JobFunction Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PreferredLanguage")), "PreferredLanguage Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Partner")), "Partner Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AssignPartnerGroup")), "AssignPartnerGroup Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("SaveUser")), "SaveUser button Element Not Found");
           

        }


        public void UpdateUserAccess(string name)
        {
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(Action);
            Action.Click();
            GenericHelper.WaitForElement(UserAccess);
            UserAccess.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            //Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("UserStatus")), "UserStatus Element Not Found");


        }

        public void ImpersonateUserAccess(string name)
        {
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(Action);
            Action.Click();
            GenericHelper.WaitForElement(ImpersonateUser);
            ImpersonateUser.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            StopImpersonate.Click();
            GenericHelper.WaitForLoadingMask();
           


        }

    }
}
