using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.PageObject.Programs.ManualPointAdjustment
{
    public class PointTypeDetail : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']/following-sibling::button[text()='Cancel']")]
        private IWebElement close;

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Point type')]")]
        private IWebElement Pointtype;

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'Program Name')]")]
        private IWebElement ProgramName;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Point Adjustment')]")]
        private IWebElement PointAdjustment;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Reason')]")]
        private IWebElement Reason;

        public PointTypeDetail(IWebDriver driver) : base(driver)
        {
            _driver = driver;   
        }

        public void ClickClose()
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(close);
        }

        public void WaitForModalDialog()
        {
            GenericHelper.WaitForElement(close);
        }

        public void ValidateElemetInPage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Pointtype")), "Point type Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ProgramName")), "Program Name Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PointAdjustment")), "Point Adjustment Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Reason")), "Reason Element Not Found");
        }
    }
}
