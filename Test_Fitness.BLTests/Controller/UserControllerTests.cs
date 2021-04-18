using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Fitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Fitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    { 
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Assert
            var userName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Now.AddYears(- 18);
            var weight = 90;
            var height = 190;
            var gender = "man";
            var controller = new UserController(userName);

            // Act
            controller.SetNewUserData(gender, birthDate, weight, height);
            var controller2 = new UserController(userName);
            

            // Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Assert
            var userName = Guid.NewGuid().ToString();

            // Act
            var controller = new UserController(userName);

            // Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}