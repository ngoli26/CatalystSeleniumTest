using System;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.CustomerProfile
{
    [TestClass]
    public class CustomerpRofile
    {
       

        [TestMethod]
        public void CustprofileScrShot()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var custpage = hPage.SaveCustomerProfile();
            
            custpage.TakeCustomerPorfileScrShot(string.Format("StageCustomerProfile-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            custpage.CustProfileValidateElements();
            hPage.Logout();
        }
       


    }
}


