using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.WebElementExtClass;
using OpenQA.Selenium.Support.PageObjects;

namespace CatalystSelenium.PageObject.AssetLibrary.Library
{
    public class Library : PageBase
    {
        public Library(IWebDriver driver) : base(driver)
        {
            
        }

        [FindsBy(How = How.Name, Using = "Filepath")]
        private IWebElement Filepath;

        [FindsBy(How = How.Name, Using = "Name")]
        private IWebElement AssetName;

        [FindsBy(How = How.Name, Using = "Description")]
        private IWebElement Description;

        [FindsBy(How = How.Name, Using = "EligibleGroup")]
        private IWebElement EligibleGroup;

        [FindsBy(How = How.Name, Using = "StartDate")]
        private IWebElement StartDate;

        [FindsBy(How = How.Name, Using = "EndDate")]
        private IWebElement EndDate;

        [FindsBy(How = How.Name, Using = "NativeLanguage")]
        private IWebElement NativeLanguage;

        [FindsBy(How = How.Name, Using = "AssetFamily")]
        private IWebElement AssetFamily;

        [FindsBy(How = How.Name, Using = "IsDownloadable")]
        private IWebElement IsDownloadable;


        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement Save;

        [FindsBy(How = How.XPath, Using = "//input[@value='fd']")]
        private IWebElement tag;

        [FindsBy(How = How.XPath, Using = "//span[@class='input-group-btn']/descendant-or-self::button[@ng-click='endOpen($event)']")]
        private IWebElement Endate;


        [FindsBy(How = How.XPath, Using = "//span[@class='btn-group pull-left']/descendant-or-self::button[position()=1]")]
        private IWebElement Today;



        //button[text()='Today']

        public void SelectEligibleGroup(string name)
        {
            DropDownHelper.SelectByVisibleText(EligibleGroup, name);
        
            GenericHelper.WaitForLoadingMask();
        }

        public void EntertAssetURL(string AssetURL)
        {
            Filepath.SendKeys(AssetURL);
        
            GenericHelper.WaitForLoadingMask();
        }

        public void EntertAssetName(string Assetname)
        {
            AssetName.SendKeys(Assetname);

            GenericHelper.WaitForLoadingMask();
        }

        public void EntertAssetDescription(string AssetDesc)
        {
            Description.SendKeys(AssetDesc);

            GenericHelper.WaitForLoadingMask();
        }

      /*  public void SelectEndDate(string day, string month, string year)
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(Endate);
            Today.Click();
           // GenericHelper.WaitForElement(By.XPath("//button[@class='btn btn-default assetCalIcon'][@ng-click='endOpen($event)'][position()=1]"));
          //  CalenderHelper.SelectDate("//button[@class='btn btn-default assetCalIcon'][@ng-click='endOpen($event)'][position()=1]", day, month, year);
            GenericHelper.WaitForLoadingMask();
        }*/


        public void SelectEndDatetoday()
        {
            JavaScriptExecutorHelper.ScrollElementAndClick(Endate);
          //  GenericHelper.WaitForElement(Today);
          //  Today.Click();
             GenericHelper.WaitForElement(By.XPath("//span[@class='input-group-btn']/descendant-or-self::button[@ng-click='endOpen($event)']"));
             // CalenderHelper.SelectDate("//span[@class='input-group-btn']/descendant-or-self::button[@ng-click='endOpen($event)']", day, month, year);
             JavaScriptExecutorHelper.ScrollElementAndClick(Today);
             // Today.Click();
            GenericHelper.WaitForLoadingMask();
        }

        public void SelectLanguage(string Language)
        {
            DropDownHelper.SelectByVisibleText(NativeLanguage, Language);
       
            GenericHelper.WaitForLoadingMask();
        }
    }
}
