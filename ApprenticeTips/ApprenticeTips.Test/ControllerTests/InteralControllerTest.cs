using ApprenticeTips.App.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApprenticeTips.Test.ControllerTests
{
    [TestClass]
    public class InteralControllerTest
    {
        [TestMethod]
        public void Test_IndexView_ReturnIndex()
        {
            var controller = new InterestController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
