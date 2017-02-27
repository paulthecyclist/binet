using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextFib.Controllers;
using NextFib.Models;

namespace NextFib.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private HomeController _controller;

        [TestInitialize]
        public void Init()
        {
            _controller = new HomeController();
        }

        [TestMethod]
        public void OnLoadSequenceNumberIs1()
        {
            // Arrange

            // Act
            var result = _controller.Index() as ViewResult;
            var outputModel = (FibViewModel) result.Model;

            // Assert
            Assert.AreEqual(1, outputModel.SequenceNumber);
        }

        [TestMethod]
        public void GivenSequence1ThenExpect0()
        {
            // Arrange
            var inputModel = new FibViewModel {SequenceNumber = 1};

            // Act
            var result = _controller.Index(inputModel) as ViewResult;
            var outputModel = (FibViewModel) result.Model;

            // Assert
            Assert.AreEqual(1, outputModel.FibNumber);
        }

        [TestMethod]
        public void GivenSequence2ThenExpect1()
        {
            // Arrange
            var inputModel = new FibViewModel {SequenceNumber = 2};

            // Act
            var result = _controller.Index(inputModel) as ViewResult;
            var outputModel = (FibViewModel) result.Model;

            // Assert
            Assert.AreEqual(1, outputModel.FibNumber);
        }

        [TestMethod]
        public void GivenSequence7ThenExpect13()
        {
            // Arrange
            var inputModel = new FibViewModel {SequenceNumber = 7};

            // Act
            var result = _controller.Index(inputModel) as ViewResult;
            var outputModel = (FibViewModel) result.Model;

            // Assert
            Assert.AreEqual(13, outputModel.FibNumber);
        }

        [TestMethod]
        public void GivenInvalidValueThenVerifyResultIs0()
        {
            // Arrange
            var inputModel = new FibViewModel { SequenceNumber = 1 };
            _controller.ViewData.ModelState.AddModelError("Test", "Invalid value");

            // Act
            var result = _controller.Index(inputModel) as ViewResult;
            var outputModel = (FibViewModel)result.Model;

            // Assert
            Assert.AreEqual(0, outputModel.FibNumber);
        }
    }
}