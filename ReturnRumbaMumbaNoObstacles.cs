using System.Collections.Generic;
using System.Drawing;
using RobotHardware;

namespace GoRumbaMumba
{
    public class ReturnRumbaMumbaNoObstacles : IRobotCommand
    {
        public List<Point> Execute(IHardwareRobot robot)
        {
            // quickest way back to the origin is, since the robot cannot travel diagonally,
            // to go all the way west, then all the way north (or vice-versa)

            // initialise the path by adding the current location
            var path = new List<Point> {new Point(robot.X, robot.Y)};

            //face west and return to X == 0
            if (robot.FaceTo == 3)
                robot.TurnLeft();
            else
            {
                while (robot.FaceTo != 2)
                    robot.TurnRight();
            }

            while (robot.X > 0)
            {
                robot.Walk();
                path.Add(new Point(robot.X, robot.Y));
            }

            //face north and return to Y == 0
            robot.TurnRight();
            while (robot.Y > 0)
            {
                robot.Walk();
                path.Add(new Point(robot.X, robot.Y));
            }

            return path;
        }
    }

}
