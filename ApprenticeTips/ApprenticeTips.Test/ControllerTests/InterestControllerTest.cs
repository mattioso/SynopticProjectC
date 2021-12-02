using ApprenticeTips.App.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApprenticeTips.Test.ControllerTests
{
    [TestClass]
    public class InterestControllerTest
    {
        [TestMethod]
        public void Test_IndexView_ReturnIndex()
        {
            var controller = new InterestController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void Test_ThanksView_ReturnsThanks()
        {
            var controller = new InterestController();
            var result = controller.Thanks() as ViewResult;
            Assert.AreEqual("Thanks", result.ViewName);
        }
    }
}
