using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CatalystSelenium.BaseClasses;
using CatalystSelenium.ComponentHelper;

namespace CatalystSelenium.ExtensionClass.ScreenShotExtClass
{
    public static class TakeScreenShot
    {
        public static void CaptureScreenShot(this PageBase baseClass, string name = null)
        {
            Thread.Sleep(200);
            GenericHelper.TakeSceenShot(name);
        }
    }
}
