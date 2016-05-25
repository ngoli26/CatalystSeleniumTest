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
using CatalystSelenium.PageObject.UserGroups;

namespace CatalystSelenium.PageObject.Partners
{
    public class ManagePartnerGroups : PageBase
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Partner ']")]
        private IWebElement Partner;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Partner Groups']")]
        private IWebElement PartnerGroups;

        [FindsBy(How = How.Id,Using = "GroupName")]
        private IWebElement GroupName;

        [FindsBy(How = How.Id, Using = "GroupDescription")]
        private IWebElement GroupDescription;

        [FindsBy(How = How.XPath,Using = "//input[@name='SmartGroup' and @value='yes']")]
        private IWebElement Yes;

        [FindsBy(How = How.XPath, Using = "//input[@name='SmartGroup' and @value='no']")]
        private IWebElement No;

        [FindsBy(How = How.XPath, Using = "//button[text()='OK']")]
        private IWebElement Ok;

        [FindsBy(How = How.XPath, Using = "//button[text()='Cancel']")]
        private IWebElement Cancel;

        private readonly GrpNameDetailPage grpPage;
        private readonly ManagePartnerGroups grp;

        [FindsBy(How = How.XPath, Using = "//button[text()='Create']")]
        private IWebElement Create;

        [FindsBy(How = How.XPath, Using = "//button[text()='Duplicate Group']")]
        private IWebElement duplicatBtn;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Create a Group')]")]
        private IWebElement createGrp;

        public ManagePartnerGroups(IWebDriver drive) : base(drive)
        {
            this._driver = drive;
            grpPage = new GrpNameDetailPage(_driver);
            grp = new ManagePartnerGroups(_driver);
        }

      //  public CreateNewPartnerGroup(IWebDriver driver) : base(driver)
      //  {
       //     this._driver = driver;
      //  }

        public void TakePartnerGroupScrshot(string name)
        {
            Create.Click();
            GenericHelper.WaitForElement(GroupName);
            GenericHelper.TakeSceenShot(name);

        }

        public void CreateGroup(string grpName, bool isSmartGroup)
        {
            GroupName.SendKeys(grpName);
            if(isSmartGroup)
                Yes.Click();
            else
                No.Click();
            Thread.Sleep(500);
        }

        public void CreateGrpOfGroup(string grpName, string grpDescription)
        {
            GroupName.SendKeys(grpName);
            GroupDescription.SendKeys(grpDescription);
            Thread.Sleep(500);
        }

        public void TakePatnerGrpScrShot(string name)
        {
            Partner.Click();
            GenericHelper.WaitForElement(PartnerGroups);
            TakeScreenShotofPage(PartnerGroups, name);
        }


        public void ClickOk()
        {
            Ok.Click();
        }

        public void ClickCancel()
        {
            Cancel.Click();
        }
    }
}
