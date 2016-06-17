using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalystSelenium.ComponentHelper;
using CatalystSelenium.ExtensionClass.LoggerExtClass;
using CatalystSelenium.PageObject;
using CatalystSelenium.Settings;

namespace CatalystSelenium.BaseClasses.LoginBaseClass
{
    public class LoginBase : IDisposable
    {
        protected ILog Logger;
        protected LoginPage Lpage;
        protected HomePage HPage;

        public LoginBase()
        {
            try
            {
                Logger = LoggerHelper.GetLogger(GetType());
                Lpage = new LoginPage(ObjectRepository.Driver);
                HPage = Lpage.LoginApplication(ObjectRepository.Config.GetUsername(), ObjectRepository.Config.GetPassword());
                Logger.Info("Test Execution Started");
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw;
            }
            
        }

        ~LoginBase()
        {
           Dispose();
        }

        public void Dispose()
        {
            Logger = null;
            Lpage = null;
            HPage = null;
        }
    }
}
