using System;
using System.Threading;
using log4net;
using CatalystSelenium.CustomException;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.Settings;

namespace CatalystSelenium.ComponentHelper
{
    public class BrowserHelper
    {
        private static readonly ILog Logger = LoggerHelper.GetLogger(typeof (BrowserHelper));
        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
            Logger.Info(" Browser Back Button Clicked ");
        }

        public static void SwitchToWindow(int windowIndex)
        {
            Thread.Sleep(500);
            var windowList = ObjectRepository.Driver.WindowHandles;
            if (windowList == null || windowList.Count < windowIndex)
            {
                throw new InvalidBrowserWindowIndex(String.Format("Invalid index of Browser window : {windowIndex}"));
            }
            ObjectRepository.Driver.SwitchTo().Window(windowList[windowIndex]);
            Logger.Info(" Switch to Window " + windowIndex);
        }

        public static void SwitchToParentWithClose()
        {
            var windowList = ObjectRepository.Driver.WindowHandles;
            for (var i = windowList.Count - 1; i > 0; i--)
            {
                ObjectRepository.Driver.SwitchTo().Window(windowList[i]);
                Logger.Info(" Switch to Window " + windowList[i]);
                ObjectRepository.Driver.Close();
                Logger.Info(" Browser Window Closed " + windowList[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowList[0]);
            Logger.Info(" Switch to Parent Window ");
        }

    }


}
