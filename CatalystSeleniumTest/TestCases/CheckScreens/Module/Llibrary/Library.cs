using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.Llibrary
{
    [TestClass]
    public class Library : LoginBase
    {
        [TestMethod]
        public void TestLibrary()
        {
            try
            {
                var libpage = HPage.NavigateToLibrary();
                libpage.EntertAssetURL("http://www.google.com");
                libpage.EntertAssetName("AssetAutomation");
                libpage.EntertAssetDescription("Desciption");
                libpage.SelectEligibleGroup("Claim");
                // libpage.SelectEndDatetoday("12", "February", "2016");
                libpage.SelectEndDatetoday("Visibility End Date");
                libpage.SelectLanguage("US English");

                libpage.Logout();
            }
            catch (Exception exception)
            {
                Logger.LogException(exception);
                throw;
            }
            
        }
    }
}
