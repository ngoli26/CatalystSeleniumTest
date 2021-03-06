﻿using System;
using System.Threading;
using log4net;
using OpenQA.Selenium;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.Settings;

namespace CatalystSelenium.ComponentHelper
{
    public class JavaScriptExecutorHelper
    {
        private static IJavaScriptExecutor _exeScript;
        private static readonly ILog Logger = LoggerHelper.GetLogger(typeof(JavaScriptExecutorHelper));

        public static void ExecuteScript(string script, params object[] args)
        {
            _exeScript = ((IJavaScriptExecutor)ObjectRepository.Driver);
            Logger.Info(" Executing Script " + script);
            _exeScript.ExecuteScript(script,args);
        }

        public static object ExecuteScript(string script)
        {
            _exeScript = ((IJavaScriptExecutor)ObjectRepository.Driver);
            Logger.Info(" Executing Script " + script);
            return _exeScript.ExecuteScript(script);
        }
        
        public static void ScrollElementAndClick(IWebElement element)
        {
            Thread.Sleep(500);
            var eleName = element.ToString();
            ExecuteScript("window.scrollTo(0," + element.Location.Y + ");");
            element.Click();
            Logger.Info(" Scroll Element And Click " + eleName);
        }

        public static void ScrollToElement(IWebElement element)
        {
            Thread.Sleep(500);
            ExecuteScript("window.scrollTo(0," + element.Location.Y + ");");
            Logger.Info(" Scroll To Element " + element);
        }

        public static void ScrollElementAndClick(By locator)
        {
            var element = ObjectRepository.Driver.FindElement(locator);
            GenericHelper.WaitForElement(element);
            ExecuteScript("window.scrollTo(0," + element.Location.Y + ");");
            element.Click();
            Logger.Info(" Scroll Element And Click " + locator);
        }
    }
}
