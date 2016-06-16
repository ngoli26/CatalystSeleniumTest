using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalystSelenium.BaseClasses
{
    [TestClass]
    public class ResourceDeployment
    {
        [TestMethod]
        [DeploymentItem("Resources")]
        public void DeployResource() { }
    }
}
