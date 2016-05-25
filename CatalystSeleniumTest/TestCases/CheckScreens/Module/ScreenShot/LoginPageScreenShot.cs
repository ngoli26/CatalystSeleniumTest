using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.ExtensionClass.WebElementExtClass;

namespace CatalystSelenium.TestCases.Module.ScreenShot
{
    [TestClass]
    public class LoginPageScreenShot 
    {
        [TestMethod]
        public void LoginScrShot()
        {
            
                var lpage = new LoginPage(ObjectRepository.Driver);
                lpage.ScreenShotofForgotPassword(string.Format("StageForgotUsername-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                lpage.ScreenShotofForgotUserName(string.Format("StageForgotPassword-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                lpage.ScreenShotofOpenReg(string.Format("StageOpenRegister-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

            }
          
        }
    }

