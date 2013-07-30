using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotHardware;
using System.Drawing;
using System.Collections.Generic;

namespace GoRumbaMumba.Tests
{
    [TestClass]
    public class ReturnRumbaMumbaNoObstaclesTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            var robot = new Hardware(2, 2);

            // move the robot to (1, 1)
            robot.Walk();
            robot.TurnRight();
            robot.Walk();

            // just checking...
            Assert.AreEqual(robot.X, 1);
            Assert.AreEqual(robot.Y, 1);

            var command = new ReturnRumbaMumbaNoObstacles();
            var expected = new List<Point>
            {
                new Point { X = 1, Y = 1},
                new Point { X = 0, Y = 1},
                new Point { X = 0, Y = 0}
            };
            var actual = command.Execute(robot);

            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
