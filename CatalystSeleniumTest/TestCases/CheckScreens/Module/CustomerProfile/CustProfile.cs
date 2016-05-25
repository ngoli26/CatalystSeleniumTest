using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.Module.ScreenShot
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


