using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotHardware;

namespace GoRumbaMumba.Tests
{
    [TestClass]
    public class CleanRumbaMumbaNoObstaclesTest
    {
        [TestMethod]
        public void ExecuteTest()
        {
            var robot = new Hardware(2, 2);

            var command = new CleanRumbaMumbaNoObstacles();
            var expected = new List<Point>
            {
                new Point { X = 0, Y = 0},
                new Point { X = 1, Y = 0},
                new Point { X = 1, Y = 1},
                new Point { X = 0, Y = 1}
            };
            var actual = command.Execute(robot);

            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        //TODO : Add more tests for TryWalk, IsVisited etc. ?
    }
}
