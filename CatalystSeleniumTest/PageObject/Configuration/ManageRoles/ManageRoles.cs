using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using System.Threading;

namespace CatalystSelenium.PageObject.Configuration.ManageRoles
{
    public class ManageRoles : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//button[text()='Create']")]
        private IWebElement CreateBtn;

        public ManageRoles(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public RolesDetails ClickOnRoleName(string gridXpath, int row, int column)
        {
            var elemnet = GridHelper.GetGridElement(gridXpath, row, column);
            JavaScriptExecutorHelper.ScrollElementAndClick(elemnet);
            GenericHelper.WaitForLoadingMask();
            return new RolesDetails(_driver);

        }

        public void ClickCreateAndTakeSrcShot(string scrShotName)
        {
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(CreateBtn);
            JavaScriptExecutorHelper.ScrollElementAndClick(CreateBtn);
            GenericHelper.WaitForLoadingMask();

            Thread.Sleep(200);
            TakeScreenShot(scrShotName);

            GenericHelper.WaitForLoadingMask();
        }
    }
}
