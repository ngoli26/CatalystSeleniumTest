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

namespace CatalystSelenium.PageObject.CustomerProfile


{
    public class CustProfile : PageBase
    {
        private IWebDriver _driver;


      

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement Save;

        [FindsBy(How = How.XPath, Using = "//button[text()='Ignore']")]
        private IWebElement Ignore;


        [FindsBy(How = How.Name, Using = "AlternativeId")]
        private IWebElement AlternativeId;

        [FindsBy(How = How.Name, Using = "ProgramName")]
        private IWebElement ProgramName;

        [FindsBy(How = How.Name, Using = "AddressLine1")]
        private IWebElement AddressLine1;

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

        [FindsBy(How = How.Name, Using = "PhoneNumber")]
        private IWebElement PhoneNumber;


        [FindsBy(How = How.Name, Using = "EmailAddress")]
        private IWebElement EmailAddress;

        [FindsBy(How = How.XPath, Using = "//input[@name='AllowOpenEnrollment' and @value='true']")]
        private IWebElement AllowOpenEnrollmentYes;

        [FindsBy(How = How.XPath, Using = "//input[@name='AllowOpenEnrollment' and @value='false']")]
        private IWebElement AllowOpenEnrollmentNo;

        [FindsBy(How = How.XPath, Using = "//input[@name='KeyBasedRegistration' and @value='true']")]
        private IWebElement KeyBasedRegistrationYes;

        [FindsBy(How = How.XPath, Using = "//input[@name='KeyBasedRegistration' and @value='false']")]
        private IWebElement KeyBasedRegistrationNo;

        [FindsBy(How = How.XPath, Using = "//input[@name='ApprovalType' and @value='1']")]
        private IWebElement AutoApprovalYes;

        [FindsBy(How = How.XPath, Using = "//input[@name='ApprovalType' and @value='2']")]
        private IWebElement AutoApprovalNo;

     

        [FindsBy(How = How.Name, Using = "TaxInfo")]
        private IWebElement TaxInfo;

        [FindsBy(How = How.Name, Using = "TaxThresholdRequired")]
        private IWebElement TaxThresholdRequired;


        [FindsBy(How = How.Name, Using = "TCRequired")]
        private IWebElement TCRequired;



      //  [FindsBy(How = How.XPath, Using = "//label[text()='Default (Please select one)']")]
       // private IWebElement Pointtype;

        [FindsBy(How = How.XPath, Using = "//h4[text()='Point Types']")]
        private IWebElement Pointtype;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description")]
        private IWebElement PointtypeDescription;

        [FindsBy(How = How.Name, Using = "UserFile")]
        private IWebElement UserFile;

        [FindsBy(How = How.Name, Using = "PartnerFile")]
        private IWebElement PartnerFile;

        [FindsBy(How = How.Name, Using = "ProductFile")]
        private IWebElement ProductFile;

        [FindsBy(How = How.Name, Using = "SalesFile")]
        private IWebElement SalesFile;


        [FindsBy(How = How.Name, Using = "ActivityFile")]
        private IWebElement ActivityFile;


        [FindsBy(How = How.Name, Using = "PointAdjustmentFile")]
        private IWebElement PointAdjustmentFile;







        public void CustProfileValidateElements()
        {
         
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AlternativeId")), "AlternativeId Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ProgramName")), "ProgramName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine1")), "AddressLine1 Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("City")), "City Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("State")), "State Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PostalCode")), "PostalCode Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Country")), "Country Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ContactName")), "ContactName Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PhoneNumber")), "PhoneNumber Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("EmailAddress")), "EmailAddress Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AllowOpenEnrollmentYes")), "AllowOpenEnrollmentYes Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AllowOpenEnrollmentNo")), "AllowOpenEnrollmentNo Element Not Found");

            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("KeyBasedRegistrationYes")), "KeyBasedRegistrationYes Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("KeyBasedRegistrationNo")), "KeyBasedRegistrationNo Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AutoApprovalYes")), "AutoApprovalYes Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AutoApprovalNo")), "AutoApprovalNo Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxInfo")), "TaxInfo Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxThresholdRequired")), "TaxThresholdRequired Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TCRequired")), "TCRequired Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Pointtype")), "Pointtype Element Not Found");
            // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PointtypeName")), "PointtypeName Element Not Found");
           // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PointtypeDescription")), "PointtypeDescription Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("UserFile")), "UserFile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PartnerFile")), "PartnerFile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ProductFile")), "ProductFile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("SalesFile")), "SalesFile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ActivityFile")), "ActivityFile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PointAdjustmentFile")), "PointAdjustmentFile Element Not Found");
          




        }

        public CustProfile(IWebDriver driver) : base(driver)
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


        public void TakeCustomerPorfileScrShot(string name)
        {
          
            JavaScriptExecutorHelper.ScrollElementAndClick(Save);

            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(Save);

            GenericHelper.WaitForLoadingMask();

           if (GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Ignore")))
            {
                //GenericHelper.WaitForLoadingMask();
                Ignore.Click();
                GenericHelper.WaitForLoadingMask();
            }
           else
           // GenericHelper.WaitForElement(Ignore);
           // Ignore.Click();
          //  GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);


        }



    }
}
