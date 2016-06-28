using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.BaseClasses.LoginBaseClass;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExcelUtility;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;

namespace CatalystSelenium.TestCases.CheckScreens.Module.ManageUserGrps
{
    [TestClass]
    [DeploymentItem("Resources")]
    public class TestManageUserGrp : LoginBase
    {
        private readonly string[] _manageUsrGroup =
        {
            "Group Name", "Group Type", "Number of Recipients", "Active", "Date Created",
            "Last Edited"
        };


        private readonly string[] _addToGrop =
        {
            "Title", "First Name", "Last Name", "Email Address", "Birthday", "Phone Number", "Partner Name",
            "Partner Type",
            "Partner Number Of Users", "Partner Active", "Partner Date Created", "Partner Date Edited", "PartnerCustom",
            "UserCustom",
            "Shipping Address 1", "Shipping Zip", "PartnerType", "Custompartner", "PostProdDateAttrib", "PartDateAttrib"
        };

        private readonly string[] _smartGroupGridHeading =
        {
            "Email Address", "First Name", "Last Name", "Job Title",
            "Job Role", "Preferred Language", "City", "State", "Postcode/Zip Code", "Country", "Date Registered",
            "Active", "Terms and Conditions Accepted Date"
        };

        [TestMethod]
        public void TestManageUserGrpScreen()
        {
            try
            {
                using (var reader = new ExcelReaderHelper(@"TestData\ManagePartnerGrp.xlsx", "ManageUserGroups"))
                {
                    var excelData = reader.GetXcelData();
                    var mPage = HPage.OpenManageUserGroups();

                    //validation for grid heading
                    for (var i = 0; i < _manageUsrGroup.Length; i++)
                    {
                        Assert.AreEqual(_manageUsrGroup[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.UserGroupGrid, 1, (i + 2)));
                    }
                    mPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, excelData["StaticGroup"], 2, 2);
                    GenericHelper.TakeSceenShot(string.Format("StageStaticUserGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                    //validation for grid heading
                    for (var i = 0; i < _addToGrop.Length; i++)
                    {
                        Assert.AreEqual(_addToGrop[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.AllUserGrid, 1, (i + 2)));
                    }

                    //validation for grid heading
                    for (var i = 0; i < _addToGrop.Length; i++)
                    {
                        Assert.AreEqual(_addToGrop[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.GroupMemberGrid, 1, (i + 2)));
                    }
                    mPage.NavigateToHome();
                    HPage.OpenManageUserGroups();
                    mPage.ClickOnUserGrp(Properties.Settings.Default.UserGroupGrid, excelData["SmartGroup"], 7, 2);
                    GenericHelper.TakeSceenShot(string.Format("StageSmartUserGrp-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));

                    //validation for grid heading
                    for (var i = 0; i < _smartGroupGridHeading.Length; i++)
                    {
                        Assert.AreEqual(_smartGroupGridHeading[i], GridHelper.GetGridHeaderText(Properties.Settings.Default.UserSmartGrpGrid, 1, (i + 2)));
                    }
                    mPage.Logout(); 
                }
                
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace,exception);
                throw;
            }
           
        }

        [TestMethod]
        public void TestClickCreateAndCancel()
        {
            try
            {
                var mPage = HPage.OpenManageUserGroups();
                mPage.ClickCreateAndCancel(string.Format("StageCreateUserGroup-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                mPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace, exception);
                throw;
            }
           
        }

        [TestMethod]
        public void TestCreateGrpOfGrpAndCancel()
        {
            try
            {
                var mPage = HPage.OpenManageUserGroups();
                mPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 1, 1);
                mPage.SelectGroup(Properties.Settings.Default.UserGroupGrid, 2, 1);
                mPage.CreateGrpOfGrpAndCancel(string.Format("StageGrpofGrpUserScreenShot-{0}", DateTime.UtcNow.ToString("hh-mm-ss")));
                mPage.Logout();
            }
            catch (Exception exception)
            {
                Logger.Error(exception.StackTrace, exception);
                throw;
            }
            
        }
    }
}
