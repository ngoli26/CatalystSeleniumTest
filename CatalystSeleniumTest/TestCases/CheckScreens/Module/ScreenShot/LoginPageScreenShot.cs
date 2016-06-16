using System;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ScreenShot
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

