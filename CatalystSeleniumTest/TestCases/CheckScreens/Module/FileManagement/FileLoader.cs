using System;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.TestCases.CheckScreens.Module.FileManagement
{
    [TestClass]
    public class FileManagement : LoginBase
    {
       

        [TestMethod]
        public void UserFileLoader()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
            FilePage.TakeSelectUserFileScrShot(string.Format("StageSelectUserFiletype-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            FilePage.FileLoaderValidateElements();
           hPage.Logout();
        }


        [TestMethod]
        public void PartnerFileLoader()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
            FilePage.TakeSelectPartnerFileScrShot(string.Format("StageSelectPartnerFiletype-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
           
            hPage.Logout();
        }


        [TestMethod]
        public void SalesFileLoader()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
           
            FilePage.TakeSelectSalesScrShot(string.Format("StageSelectSalesFiletype-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            hPage.Logout();
        }

        [TestMethod]
        public void ActivityCodeFileLoader()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
            FilePage.TakeSelectActivityCodeFileScrShot(string.Format("StageSelectActivityCodeFiletype-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            hPage.Logout();
        }

        [TestMethod]
        public void ActivityTransactionFileLoader()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
            
            FilePage.TakeSelectActivityTransactionFileScrShot(string.Format("StageSelectActivityTransactionFiletype-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            hPage.Logout();
        }
        

        [TestMethod]
        public void PointAdjustmentFileLoader()
        {
            try
            {
                var filePage = HPage.UploadFile();
                filePage.TakeSelectPointAdjustmentFileScrShot(string.Format("StagePointAdjustmentFiletype-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                //FilePage.PointAdjustmentValidateElements();
                HPage.Logout();
            }
            catch (Exception exception)
            {

                Logger.LogException(exception);
                throw;
            }
            
        }

        [TestMethod]
        public void ProductFileLoader()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
            FilePage.TakeSelectProductFileScrShot(string.Format("StageProductFiletype-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            
            hPage.Logout();
        }

       /* [TestMethod]
        public void ChooseFile()
        {
            var lpage = new LoginPage(ObjectRepository.Driver);
            var hPage = lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
            var FilePage = hPage.UploadFile();
            
            FilePage.TakeChooseFileScrShot(string.Format("StageChooseFile-{0}",DateTime.UtcNow.ToString("hh-mm-ss")));
            hPage.Logout();
        }*/



    }
}


