using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.PageObject.FileUploads


{
    public class FileLoader : PageBase
    {
        private IWebDriver _driver;


        [FindsBy(How = How.Name, Using = "FileSelect")]
        private IWebElement SelectFile;

       

        [FindsBy(How = How.Id, Using = "fmDownloadSelectedTemplate")]
        private IWebElement downloadtemplate;

        [FindsBy(How = How.Id, Using = "fileUploadInput")]
        private IWebElement choosefile;

        [FindsBy(How = How.Id, Using = "fmPointTypesfmPointTypes")]
        private IWebElement SelectFilePointType;

        [FindsBy(How = How.Id, Using = "fmProgramNames")]
        private IWebElement SelectFileProgram;


        [FindsBy(How = How.Id, Using = "fmImport")]
        private IWebElement Import;
       




        public FileLoader(IWebDriver driver) : base(driver)
        {
            this._driver = driver;

        }



        private void ScreenShotofLink(IWebElement element, IWebElement button, string name)
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(element);
            GenericHelper.WaitForElement(button);
            GenericHelper.TakeSceenShot(name);
            JavaScriptExecutorHelper.ScrollElementAndClick(button);
            Thread.Sleep(200);
        }


        public void TakeSelectUserFileScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "User");
            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);
            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }

        public void TakeSelectPartnerFileScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "Partner");
            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);
            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }


        public void TakeSelectActivityCodeFileScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "ActivityCode");
            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);
            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }
        public void TakeSelectActivityTransactionFileScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "ActivityTransaction");
            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);
            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }
        public void TakeSelectPointAdjustmentFileScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "PointAdjustment");
            GenericHelper.WaitForLoadingMask();
            DropDownHelper.SelectByVisibleText(By.Name("SelectPointTypes"), "test");
            GenericHelper.WaitForLoadingMask();
            // GenericHelper.WaitForElement(SelectFileProgram);
            //DropDownHelper.SelectByVisibleText(By.Name("SelectProgram"), "Test expire");

            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);

            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }

        public void TakeSelectProductFileScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "Product");
            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);
            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }

        public void TakeSelectSalesScrShot(string name)
        {

            // JavaScriptExecutorHelper.ScrollElementAndClick(FileSelect);
            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "Sales");
            downloadtemplate.Click();
            GenericHelper.TakeSceenShot(name);
            // GenericHelper.WaitForElement(choosefile);
            // choosefile.Click();
        }

        public void TakeChooseFileScrShot(string name)
        {


            DropDownHelper.SelectByVisibleText(By.Name("FileSelect"), "Sales");
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(choosefile);
            choosefile.Click();
            GenericHelper.TakeSceenShot(name);

        }



        public void ClickFileNameAndTakeScrShot(string name)
        {
            //_driver.FindElement(By.XPath("//table//tbody//tr[" + row + "]//td[" + column + "]//a[1]")).Click();

            _driver.FindElement(By.XPath("//div[@id='UploadReportGrid']//td[@role='gridcell']//a")).Click();
            GenericHelper.TakeSceenShot(name);

        }


        public void FileLoaderValidateElements()
        {

            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("SelectFile")), "SelectFile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("downloadtemplate")), "downloadtemplate Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("choosefile")), "choosefile Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Import")), "Import Element Not Found");

        }

        public void PointAdjustmentValidateElements()
        {

            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("SelectFilePointType")), "SelectFilePointType Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("SelectFileProgram")), "SelectFileProgram Element Not Found");
           

        }
    }
}
