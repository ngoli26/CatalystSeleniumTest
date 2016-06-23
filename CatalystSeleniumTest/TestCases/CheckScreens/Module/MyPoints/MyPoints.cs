using System;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.MyPoints
{
    [TestClass]
    public class MyPoints
    {
        [TestMethod]
        public void TestMyPointsScreen()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var mypointspage = hPage.OpenMyPoints();
          
            GenericHelper.TakeSceenShot(string.Format("StageMyPoints-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            hPage.Logout();
        }
    }

    
    }

