using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.WebElementExtClass;
using CatalystSelenium.PageObject.Claims;
using CatalystSelenium.PageObject.Claims.ManageCalims;
using CatalystSelenium.PageObject.Configuration.CustomeAttribute;
using CatalystSelenium.PageObject.Configuration.ManageRoles;
using CatalystSelenium.PageObject.Partner.PartnerGrp;
using CatalystSelenium.PageObject.Programs.ManualPointAdjustment;
using CatalystSelenium.PageObject.Reports;
using CatalystSelenium.PageObject.Shop;
using CatalystSelenium.PageObject.UserGroups;
using CatalystSelenium.Settings;
using CatalystSelenium.PageObject.CustomerProfile;
using CatalystSelenium.PageObject.FileUploads;
using CatalystSelenium.PageObject.Partners;
using CatalystSelenium.PageObject.Templates;
using CatalystSelenium.PageObject.Triggers;
using CatalystSelenium.PageObject.Users;
using CatalystSelenium.PageObject.PartPrograms;
using CatalystSelenium.PageObject.Shop.Orders;
using CatalystSelenium.PageObject.AssetLibrary.Library;
using CatalystSelenium.PageObject.PartPrograms.Scheduling;

namespace CatalystSelenium.PageObject
{
    public class HomePage : PageBase
    {
        private IWebDriver driver;
        private readonly string logoutXpath =
            "//div[@id='bergerModal']/following-sibling::div[position()=1]/descendant::span[position()=2]";


        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


        [FindsBy(How = How.XPath,Using = "//div[@id='header4']/descendant::a[text()='Programs ']")]
        private IWebElement Programs;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='User ']")]
        private IWebElement User;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Partner ']")]
        private IWebElement Partner;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='File ']")]
        private IWebElement File;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Communication ']")]
        private IWebElement Communication;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Configuration ']")]
        private IWebElement Configuration;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Reports']")]
        private IWebElement Reports;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Onboarding ']")]
        private IWebElement Onboarding;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Incentive Programs']")]
        private IWebElement ManageIncentivePrograms;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Claims']")]
        private IWebElement ManageClaims;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manual Point Adjustment']")]
        private IWebElement ManualPointAdj;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage User Groups']")]
        private IWebElement ManageUserGroups;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Users']")]
        private IWebElement ManageUser;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Partner Groups']")]
        private IWebElement PartnerGroups;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Partners']")]
        private IWebElement ManagePartners;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='File Management']")]
        private IWebElement FileLoader;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='File Status']")]
        private IWebElement FileStatus;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Notification Templates']")]
        private IWebElement ManageNotificationTemplates;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Notification Triggers']")]
        private IWebElement ManageNotificationTriggers;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Scheduled Messages']")]
        private IWebElement ManageScheduledMessages;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Email Analytics']")]
        private IWebElement EmailAnalytics;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Roles']")]
        private IWebElement ManageRoles;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Customer Profile']")]
        private IWebElement CustomerProfile;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Custom Attributes']")]
        private IWebElement CustomAttributes;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Manage Customer Content']")]
        private IWebElement ManageCustomerContent;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='New Customer']")]
        private IWebElement NewCustomer;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='SFDC Configuration']")]
        private IWebElement SFDCConfiguration;

        [FindsBy(How = How.PartialLinkText, Using = "Privacy Policy")]
        private IWebElement PrivacyPolicy;

        [FindsBy(How = How.XPath, Using = "//div[@class='incentive-modal-content']//button[text()='Ok']")]
        private IWebElement Ok;

        [FindsBy(How = How.XPath, Using = "//a[@class='mainNavLink1 headerBar2MessageText']")]
        private IWebElement hPrograms;

        [FindsBy(How = How.PartialLinkText, Using = "Terms and Conditions")]
        private IWebElement TermsandConditions;

        [FindsBy(How = How.XPath, Using = "//div[@class='incentive-modal-content']//button[text()='Close']")]
        private IWebElement Close;

        [FindsBy(How = How.PartialLinkText, Using = "Contact Us")]
        private IWebElement ContactUs;

        [FindsBy(How = How.XPath, Using = "//button[text()='Submit']")]
        private IWebElement Submit;

        [FindsBy(How = How.PartialLinkText, Using = "FAQ")]
        private IWebElement FAQ;

        [FindsBy(How = How.XPath, Using = "//div[@class='dropdown mainNavDropCont']/button[contains(text(),'Claims')]")]
        private IWebElement Claims;

        [FindsBy(How = How.LinkText, Using = "New Claim")]
        private IWebElement NewClaims;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Shop')]")] public IWebElement Shop;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Card Store')]")] public IWebElement CardStore;


        [FindsBy(How = How.Name, Using = "Title")]
        private IWebElement MyProfileTitle;

        [FindsBy(How = How.Name, Using = "FirstName")]
        private IWebElement MyProfileFirstName;

        [FindsBy(How = How.Name, Using = "LastName")]
        private IWebElement MyProfileLastName;

        [FindsBy(How = How.Name, Using = "UserName")]
        private IWebElement UserName;

        [FindsBy(How = How.Name, Using = "EmailAddress")]
        private IWebElement EmailAddress;

        [FindsBy(How = How.Name, Using = "JobTitle")]
        private IWebElement JobTitle;

        [FindsBy(How = How.Name, Using = "JobFunction")]
        private IWebElement JobFunction;


        [FindsBy(How = How.Name, Using = "PreferredLanguage")]
        private IWebElement PreferredLanguage;

        [FindsBy(How = How.Name, Using = "DateOfBirth")]
        private IWebElement DateOfBirth;


        [FindsBy(How = How.Name, Using = "PhoneNumber")]
        private IWebElement PhoneNumber;


        [FindsBy(How = How.Name, Using = "FaxNumber")]
        private IWebElement FaxNumber;

        [FindsBy(How = How.Name, Using = "AddressLine1")]
        private IWebElement AddressLine1;


        [FindsBy(How = How.Name, Using = "AddressLine2")]
        private IWebElement AddressLine2;


        [FindsBy(How = How.Name, Using = "AddressLine3")]
        private IWebElement AddressLine3;

      
        [FindsBy(How = How.XPath, Using = "//label[text()='Town/City']")]
        private IWebElement City;

        [FindsBy(How = How.XPath, Using = "//label[text()='State/Province/County']")]
        private IWebElement State;

        [FindsBy(How = How.XPath, Using = "//label[text()='Postal Code/Zip Code")]
        private IWebElement ZipCode;

        [FindsBy(How = How.XPath, Using = "//label[text()='Country']")]
        private IWebElement Country;

        [FindsBy(How = How.XPath, Using = "  //label[text()='Partner']")]
        private IWebElement MyProfilePartner;

        [FindsBy(How = How.XPath, Using = "//label[text()='Marketing Emails']")]
        private IWebElement marketingemails;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement MyProfileSave;

        [FindsBy(How = How.Name, Using = "LegalFirstName")]
        private IWebElement LegalFirstName;

        [FindsBy(How = How.Name, Using = "LegalLastName")]
        private IWebElement LegalLastName;

        [FindsBy(How = How.Name, Using = "SocialNumber")]
        private IWebElement SocialNumber;

        [FindsBy(How = How.Name, Using = "Address1")]
        private IWebElement TaxAddress1;

        [FindsBy(How = How.Name, Using = "Address2")]
        private IWebElement TaxAddress2;

        [FindsBy(How = How.Name, Using = "Address3")]
        private IWebElement TaxAddress3;

        [FindsBy(How = How.Name, Using = "City")]
        private IWebElement TaxCity;

        [FindsBy(How = How.Name, Using = "State")]
        private IWebElement TaxState;

        [FindsBy(How = How.Name, Using = "PostalCode")]
        private IWebElement TaxPostalCode;

        [FindsBy(How = How.Name, Using = "Agree")]
        private IWebElement Agree;

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement TaxSave;

        [FindsBy(How = How.Name, Using = "oldPassword")]
        private IWebElement oldPassword;

        [FindsBy(How = How.Name, Using = "Password")]
        private IWebElement Password;


        [FindsBy(How = How.Name, Using = "ConfirmPassword")]
        private IWebElement ConfirmPassword;

        [FindsBy(How = How.LinkText, Using = "My Claims")]
        private IWebElement MyClaims;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'MyPoints')]/span[contains(text(),'Points')]")]
        private IWebElement MyPointsPage1;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Learn ']")]
        private IWebElement Learn;

        [FindsBy(How = How.XPath, Using = "//div[@id='header4']/descendant::a[text()='Library']")]
        private IWebElement Library;

        #region Private

        private string GetSubMenuItemXpath(string name)
        {
            return "//a[contains(text(),'" + name + "')]";
        }

        #endregion


    

        /// <summary>
        /// Supply the Name of Element which you want to validate. The element should be in same class
        // Similarly for other element which u want to validate. Supply name as string
        ///  </summary>
        public void ValidateElements()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Programs")),"Element Not Found"); 
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("User")), "Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Partner")), "Element Not Found");
            Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("File")), "Element Not Found");
        }



        public void MyProfile()

        {
            if (GenericHelper.IsElementPresentQuick(By.XPath(logoutXpath)))
            {
                var MyProfile = GenericHelper.GetElement(By.XPath(logoutXpath));
                MyProfile = GenericHelper.WaitForElementClickAble(MyProfile);
                JavaScriptExecutorHelper.ScrollElementAndClick(MyProfile);
                MyProfile = GenericHelper.WaitForElement(By.XPath("//a[contains(text(),'My Profile')]"));
                JavaScriptExecutorHelper.ScrollElementAndClick(MyProfile);
                //GenericHelper.WaitForElement(By.XPath("//div[@class='loginWrapper']"));
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("MyProfileTitle")), "MyProfileTitle Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("MyProfileFirstName")), "MyProfileFirstName Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("MyProfileLastName")), "MyProfileLastName Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("UserName")), "UserName Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("EmailAddress")), "EmailAddress Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("JobTitle")), "JobTitle Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("JobFunction")), "JobFunction Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PreferredLanguage")), "PreferredLanguage Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("DateOfBirth")), "DateOfBirth Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("PhoneNumber")), "PhoneNumber Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("FaxNumber")), "FaxNumber Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine1")), "AddressLine1 Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine2")), "AddressLine2 Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("AddressLine3")), "AddressLine3 Element Not Found");
                //Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("City")), "City Element Not Found");
             
                
            }
           
        }

        public Library NavigateToLibrary()
        {
            Learn.Click();
            GenericHelper.WaitForElement(Library);
            Library.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new Library(driver);

        }

        public void MyTax()

        {
            if (GenericHelper.IsElementPresentQuick(By.XPath(logoutXpath)))
            {
                var myProfile = GenericHelper.GetElement(By.XPath(logoutXpath));
                myProfile = GenericHelper.WaitForElementClickAble(myProfile);
                JavaScriptExecutorHelper.ScrollElementAndClick(myProfile);
                myProfile = GenericHelper.WaitForElement(By.XPath("//a[contains(text(),'My Profile')]"));

                JavaScriptExecutorHelper.ScrollElementAndClick(myProfile);
                var myTax = GenericHelper.WaitForElement(By.XPath("//a[contains(text(),'My Tax')]"));

                JavaScriptExecutorHelper.ScrollElementAndClick(myTax);
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("LegalFirstName")), "LegalFirstName Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("LegalLastName")), "LegalLastName Element Not Found");
                 Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("SocialNumber")), "SocialNumber Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxAddress1")), "TaxAddress1 Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxAddress2")), "TaxAddress2 Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxAddress3")), "TaxAddress3 Element Not Found");
                //Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxCity")), "TaxCity Element Not Found");
               // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxPostalCode")), "TaxPostalCode Element Not Found");
                //Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Agree")), "Agree Element Not Found");
               // Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("TaxSave")), "TaxSave Element Not Found");


                //Assert.IsFalse(GenericHelper.IsElementPresent(By.Id("titleDiv")), ErrorMessage.PageLoadErrMsg + "My Tax Page");
                //GenericHelper.WaitForElement(By.XPath("//div[@class='loginWrapper']"));
            }
        }

        public void MyPassword()

        {
            if (GenericHelper.IsElementPresentQuick(By.XPath(logoutXpath)))
            {
                var MyProfile = GenericHelper.GetElement(By.XPath(logoutXpath));
                MyProfile = GenericHelper.WaitForElementClickAble(MyProfile);
                JavaScriptExecutorHelper.ScrollElementAndClick(MyProfile);
                MyProfile = GenericHelper.WaitForElement(By.XPath("//a[contains(text(),'My Profile')]"));
                JavaScriptExecutorHelper.ScrollElementAndClick(MyProfile);
                var MyPassword = GenericHelper.WaitForElement(By.XPath("//a[contains(text(),'My Password')]"));

                JavaScriptExecutorHelper.ScrollElementAndClick(MyPassword);
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("oldPassword")), "oldPassword Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("Password")), "Password Element Not Found");
                Assert.IsTrue(GenericHelper.IsElementPresentQuick(GetLocatorOfWebElement("ConfirmPassword")), "ConfirmPassword Element Not Found");
                //GenericHelper.WaitForElement(By.XPath("//div[@class='loginWrapper']"));
            }
        }


        public void TakeMyClaimspageScrshot(string name)
        {
            Claims.Click();
            GenericHelper.WaitForElement(MyClaims);
            MyClaims.Click();
            GenericHelper.WaitForLoadingMask();
            // TakeScreenShotofPage(MyClaims, name);
            GenericHelper.TakeSceenShot(name);

        }

        public void TakeprogramspageScrshot(string name)
        {
            hPrograms.Click();
            GenericHelper.WaitForElement(hPrograms);

            GenericHelper.WaitForLoadingMask();
            TakeScreenShotofPage(hPrograms, name);

        }

        private void ScreenShotofLink(IWebElement element, IWebElement button,string name)
        {
            GenericHelper.WaitForElement(element);
            JavaScriptExecutorHelper.ScrollElementAndClick(element);
            GenericHelper.WaitForElement(button);
            GenericHelper.TakeSceenShot(name);
            button.ScrollInViewAndClick();
            Thread.Sleep(200);
        }

        public ProgramDetails OpenPartDetails()
        {
            hPrograms.Click();

            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new ProgramDetails(driver);
        }

        public MyPointsPage OpenMyPoints()
        {
           MyPointsPage1.Click();

            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new MyPointsPage(driver);
        }

        public ManagePartners OpenManagePartners()
        {
            Partner.Click();
            GenericHelper.WaitForElement(ManagePartners);
            ManagePartners.Click();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            GenericHelper.WaitForLoadingMask();
            return new ManagePartners(driver);

        }
        public ManageIncentivePrograms OpenManageIncentivePrograms()
        {
            Programs.Click();
            GenericHelper.WaitForElement(ManageIncentivePrograms);
            ManageIncentivePrograms.Click();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("titleDiv")), ErrorMessage.PageLoadErrMsg + "Manage Incentive Programs Page");
            GenericHelper.WaitForLoadingMask();
            return new ManageIncentivePrograms(driver);
        }

        public CustProfile SaveCustomerProfile()
        {
            Configuration.Click();
            GenericHelper.WaitForElement(CustomerProfile);
            CustomerProfile.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new CustProfile(driver);


        }

        public FileLoader UploadFile()
        {
            File.Click();
            GenericHelper.WaitForElement(FileLoader);
            FileLoader.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new FileLoader(driver);
        }

        public FileLoader VerifyFiles()
        {
            File.Click();
            GenericHelper.WaitForElement(FileStatus);
            FileStatus.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new FileLoader(driver);


        }

        public ManageUserGroups OpenManageUserGroups()
        {
            User.Click();
            GenericHelper.WaitForElement(ManageUserGroups);
            ManageUserGroups.Click();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("titleDiv")), ErrorMessage.PageLoadErrMsg + "Manage Incentive Programs Page");
            GenericHelper.WaitForLoadingMask();
            return new ManageUserGroups(driver);
        }

        public ManagePartnerGroups OpenManagePartnerGroups()
         {
            Partner.Click();
            GenericHelper.WaitForElement(PartnerGroups);
            PartnerGroups.Click();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            GenericHelper.WaitForLoadingMask();
            return new ManagePartnerGroups(driver);
        }

        public NewClaim OpeNewClaimPage()
        {
            Claims.Click();
            GenericHelper.WaitForElement(NewClaims);
            NewClaims.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new NewClaim(driver);
        }

        public ManageCalims OpeManageCalimsPage()
        {
            Programs.Click();
            GenericHelper.WaitForElement(ManageClaims);
            ManageClaims.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new ManageCalims(driver);
        }

        public ManageScheduling AddSchedule()
        {
            Communication.Click();
            GenericHelper.WaitForElement(ManageScheduledMessages);
            ManageScheduledMessages.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new ManageScheduling(driver);


        }

        public ManageTemplates AddTemplate()
        {
            Communication.Click();
            GenericHelper.WaitForElement(ManageNotificationTemplates);
            ManageNotificationTemplates.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new ManageTemplates(driver);


        }

        public ManageTriggers AddTrigger()
        {
            Communication.Click();
            GenericHelper.WaitForElement(ManageNotificationTriggers);
            ManageNotificationTriggers.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            return new ManageTriggers(driver);


        }

        public ManageUsers OpenManageUsers()
        {
            User.Click();
            GenericHelper.WaitForElement(ManageUser);
            ManageUser.Click();
            GenericHelper.WaitForElement(By.Id("titleDiv"));
            GenericHelper.WaitForLoadingMask();
            return new ManageUsers(driver);

        }


        public void TakeHomePageScrShot(string name)
        {
            GenericHelper.TakeSceenShot(name);
        }

        public void TakeManageIncentScrShot(string name)
        {
            Programs.Click();
            GenericHelper.WaitForElement(ManageIncentivePrograms);
            TakeScreenShotofPage(ManageIncentivePrograms,name);
        }
        public void TakeManageClaimsScrShot(string name)
        {
            Programs.Click();
            GenericHelper.WaitForElement(ManageClaims);
            TakeScreenShotofPage(ManageClaims, name);
        }
        public void TakeManualPointAdjScrShot(string name)
        {
            Programs.Click();
            GenericHelper.WaitForElement(ManualPointAdj);
            TakeScreenShotofPage(ManualPointAdj, name);
        }

        public void TakePatnerGrpScrShot(string name)
        {
            Partner.Click();
            GenericHelper.WaitForElement(PartnerGroups);
            TakeScreenShotofPage(PartnerGroups, name);
        }

        public void TakeManageUserGrpScrShot(string name)
        {
            User.Click();
            GenericHelper.WaitForElement(ManageUserGroups);
            TakeScreenShotofPage(ManageUserGroups, name);
        }
        public void TakeManageUserScrShot(string name)
        {
            User.Click();
            GenericHelper.WaitForElement(ManageUser);
            TakeScreenShotofPage(ManageUser, name);
        }

       
        public void TakeManagePartnerScrShot(string name)
        {
            Partner.Click();
            GenericHelper.WaitForElement(ManagePartners);
            TakeScreenShotofPage(ManagePartners, name);
        }

        public void TakeFileLoaderScrShot(string name)
        {
            File.Click();
            GenericHelper.WaitForElement(FileLoader);
            TakeScreenShotofPage(FileLoader, name);
        }
        public void TakeFileStatusScrShot(string name)
        {
            File.Click();
            GenericHelper.WaitForElement(FileStatus);
            TakeScreenShotofPage(FileStatus, name);
        }

        public void TakeManageNotificationScrShot(string name)
        {
            Communication.Click();
            GenericHelper.WaitForElement(ManageNotificationTemplates);
            TakeScreenShotofPage(ManageNotificationTemplates, name);
        }
        public void TakeManageNotiTriggerScrShot(string name)
        {
            Communication.Click();
            GenericHelper.WaitForElement(ManageNotificationTriggers);
            TakeScreenShotofPage(ManageNotificationTriggers, name);
        }

        public void TakeManageSchedMsgScrShot(string name)
        {
            Communication.Click();
            GenericHelper.WaitForElement(ManageScheduledMessages);
            TakeScreenShotofPage(ManageScheduledMessages, name);
        }
        public void TakeEmailAnalyticsScrShot(string name)
        {
            Communication.Click();
            GenericHelper.WaitForElement(EmailAnalytics);
            TakeScreenShotofPage(EmailAnalytics, name);
        }

        public void TakeReportsScrShot(string name)
        {
            Reports.Click();
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            BrowserHelper.GoBack();
            GenericHelper.WaitForLoadingMask();
        }

        public void TakeManageRolesScrShot(string name)
        {
            Configuration.Click();
            GenericHelper.WaitForElement(ManageRoles);
            TakeScreenShotofPage(ManageRoles, name);
        }

        public void TakeCustomeProfScrShot(string name)
        {
            Configuration.Click();
            GenericHelper.WaitForElement(CustomerProfile);
            TakeScreenShotofPage(CustomerProfile, name);
        }
        public void TakeCustomeAttributeScrShot(string name)
        {
            Configuration.Click();
            GenericHelper.WaitForElement(CustomAttributes);
            TakeScreenShotofPage(CustomAttributes, name);
        }

        public void TakeManageCustomerContentScrShot(string name)
        {
            Configuration.Click();
            GenericHelper.WaitForElement(ManageCustomerContent);
            GenericHelper.TakeSceenShot(name);
            BrowserHelper.GoBack();
            GenericHelper.WaitForLoadingMask();
        }

        public void TakeNewCustomerScrShot(string name)
        {
            Onboarding.Click();
            GenericHelper.WaitForElement(NewCustomer);
            TakeScreenShotofPage(NewCustomer, name);
        }
        public void TakeSFDCConfScrShot(string name)
        {
            Onboarding.Click();
            GenericHelper.WaitForElement(SFDCConfiguration);
            TakeScreenShotofPage(SFDCConfiguration, name);
        }

        public void TakePrivacyPolicyScrShot(string name)
        {
            ScreenShotofLink(PrivacyPolicy, Ok, name);

        }

        public void TakeTermsConditionScrShot(string name)
        {
            ScreenShotofLink(TermsandConditions, Close, name);

        }
        public void TakeContactUsScrShot(string name)
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(ContactUs);
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            BrowserHelper.GoBack();
            GenericHelper.WaitForLoadingMask();
        }

        public void TakeFaqScrShot(string name)
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(FAQ);
            GenericHelper.WaitForLoadingMask();
            GenericHelper.TakeSceenShot(name);
            BrowserHelper.GoBack();
            GenericHelper.WaitForLoadingMask();
        }

        public ManageRoles ClickManageRoles()
        {
            Configuration.Click();
            GenericHelper.WaitForElement(ManageRoles);
            ManageRoles.Click();
            GenericHelper.WaitForLoadingMask();
            return new ManageRoles(driver);
        }

        public ManagePartnerGrp ClickManagePartnerGrp()
        {
            Partner.Click();
            GenericHelper.WaitForElement(PartnerGroups);
            PartnerGroups.Click();
            GenericHelper.WaitForLoadingMask();
            return new ManagePartnerGrp(driver);
        }

        public CustomAttributes NavigateToCustomeAttribute()
        {
            Configuration.Click();
            GenericHelper.WaitForElement(CustomAttributes);
            CustomAttributes.Click();
            GenericHelper.WaitForLoadingMask();
            return new CustomAttributes(driver);
        }

        public ReportPage NavigateToReportsPage()
        {
            Reports.Click();
            GenericHelper.WaitForLoadingMask();
            return new ReportPage(driver);
        }

        public ManualPointAdjustment NavigateToManualPointAdjustment()
        {
            Programs.Click();
            GenericHelper.WaitForElement(ManualPointAdj);
            ManualPointAdj.Click();
            GenericHelper.WaitForLoadingMask();
            return new ManualPointAdjustment(driver);
        }

        public CardStores NavigateToCardStore(string subMenuItem)
        {
            Shop.ScrollElementAndClick();
            var menuItem = GenericHelper.GetElement(By.XPath(GetSubMenuItemXpath(subMenuItem)));
            GenericHelper.WaitForElement(menuItem);
            menuItem.ScrollElementAndClick();
            GenericHelper.WaitForLoadingMask();
            return new  CardStores(driver);
        }
        public MyOrders NavigateToOrders()
        {
            Shop.ScrollElementAndClick();
            var menuItem = GenericHelper.GetElement(By.XPath(GetSubMenuItemXpath("Orders")));
            GenericHelper.WaitForElement(menuItem);
            menuItem.ScrollElementAndClick();
            GenericHelper.WaitForLoadingMask();
            return new MyOrders(driver);
        }

        public class MyPointsPage
        {
            private IWebDriver driver;

            public MyPointsPage(IWebDriver driver)
            {
                this.driver = driver;
            }
        }
    }
}
