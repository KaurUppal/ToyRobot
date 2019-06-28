using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot;

namespace ToyRobotTests
{
    [TestClass]
    public class CommandFunctionsTests
    {
        #region Place Tests
        [TestMethod]
        public void Place_XYvaluesOutOfRange_ReturnFalse()
        {
            var commandFunctions = new CommandFunctions();
            var x = 5;
            var y = 0;
            var direction = EnumFaces.NORTH;

           var result = commandFunctions.Place(x, y, direction);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Place_XYvalueInRange_ReturntTrue()
        {
            var commandFunctions = new CommandFunctions();
            var x = 3;
            var y = 0;
            var direction = EnumFaces.NORTH;

            var result = commandFunctions.Place(x, y, direction);

            Assert.IsTrue(result);
        }
        #endregion

        #region Move Tests
        [TestMethod]
        public void Move_WithNorthDirectionAndValidValue_ReturnTrue()
        {
            var commandFunctions = new CommandFunctions
            {
                XValue =1,
                YValue =1,
                CurrentFace =EnumFaces.NORTH
            };
            var expectedValue = 2;

            commandFunctions.Move();

            Assert.AreEqual(expectedValue, commandFunctions.YValue);
        }

        [TestMethod]
        public void Move_WithNorthDirectionAndInValidValue_ReturnTrue()
        {
            var commandFunctions = new CommandFunctions
            {
                XValue = 1,
                YValue = 4,
                CurrentFace = EnumFaces.NORTH
            };
            var expectedValue = 4;

            commandFunctions.Move();

            Assert.AreEqual(expectedValue, commandFunctions.YValue);
        }
        #endregion

        #region Turn Tests
        [TestMethod]
        public void Turn_LeftTurnWithNorthFace_ReurnWest()
        {
            //Arrange
            var commandFunctions = new CommandFunctions();
            var expectedValue = EnumFaces.WEST;

            //Act
            commandFunctions.Turn(EnumFaces.NORTH, EnumTurn.LEFT);

            //Assert
            Assert.AreEqual(commandFunctions.CurrentFace, expectedValue);
        }
        #endregion

    }
}
