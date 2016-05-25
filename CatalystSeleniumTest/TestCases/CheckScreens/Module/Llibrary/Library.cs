using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.ScreenShotExtClass;
using CatalystSelenium.PageObject.Shop.Orders;

namespace CatalystSelenium.TestCases.Shop
{
    [TestClass, Ignore]
    public class Library : LoginBase
    {
        [TestMethod]
        public void TestLibrary()
        {
            var libpage = HPage.NavigateToLibrary();
            libpage.EntertAssetURL("http://www.google.com");
            libpage.EntertAssetName("AssetAutomation");
            libpage.EntertAssetDescription("Desciption");
            libpage.SelectEligibleGroup("StaticStage1");
          // libpage.SelectEndDatetoday("12", "February", "2016");
           libpage.SelectEndDatetoday();
            libpage.SelectLanguage("US English");

           // libpage.Logout();
        }
    }
}
