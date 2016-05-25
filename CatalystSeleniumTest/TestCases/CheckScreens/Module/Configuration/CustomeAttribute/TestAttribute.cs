using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Configuration.CustomeAttribute
{
    [TestClass]
    public class TestAttribute : LoginBase
    {
        [TestMethod]
        public void TestCustomeAttribute()
        {
            var caPage = HPage.NavigateToCustomeAttribute();
            caPage.ClickOnCustomeAttribute();
            GenericHelper.TakeSceenShot(string.Format("CustomeAttribute-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            caPage.ClickOnUserAttribute();
            GenericHelper.TakeSceenShot(string.Format("UserAttribute-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            caPage.ClickOnPartnerAttribute();
            GenericHelper.TakeSceenShot(string.Format("PartnerAttribute-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            caPage.Logout();
        }

        [TestMethod]
        public void TestNewAttributeScrShot()
        {
            var caPage = HPage.NavigateToCustomeAttribute();
            caPage.ClickOnCustomeAttribute();
            caPage.ClickOnNewAndTakeScrShot(string.Format("NewAttribute-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            caPage.Logout();
        }

        [TestMethod]
        public void TestEditAttributeScrShot()
        {
            var caPage = HPage.NavigateToCustomeAttribute();
            caPage.ClickOnCustomeAttribute();
            caPage.ClickEditAndTakeScrShot(Properties.Settings.Default.CustomAttGrid,1,1, string.Format("EditAttribute-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            caPage.Logout();
        }
    }
}
