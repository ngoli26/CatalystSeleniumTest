using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ManageRoles
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

