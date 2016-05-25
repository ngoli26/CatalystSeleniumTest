using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.Settings;
using CatalystSelenium.PageObject.UserGroups;
//using CatalystSelenium.PageObject.Partners;

namespace CatalystSelenium.PageObject.MyPoints
{
    public class MyPoints : PageBase
    {
        private IWebDriver _driver;

       

        public MyPoints(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

       

            [FindsBy(How = How.XPath, Using = "//a[contains(@href,'MyPoints')]/span[contains(text(),'Points')]")]
        private IWebElement MyPointsPage2;


        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Pending Points')]")]
        private IWebElement PendingPoints;


        [FindsBy(How = How.XPath, Using = " //h2[contains(text(),'Available Points')]")]
        private IWebElement AvailablePoints;


        //span[contains(text(),'Expiring Points')]


        public void MyPointsValidateElements()
        {

            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PendingPoints")), "PendingPoints Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AvailablePoints")), "AvailablePoints Element Not Found");

        }
    }
}