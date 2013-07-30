using System.Collections.Generic;
using System.Drawing;

using RobotHardware;

namespace GoRumbaMumba
{
    public class CleanRumbaMumbaNoObstacles : IRobotCommand
    {
        private const int NORTH = 3; //-y
        private const int EAST = 0; //+x
        private const int SOUTH = 1; //+y
        private const int WEST = 2; //-x

        private Dictionary<int, Dictionary<int, bool>> _visited;
        private List<Point> _path;

        public List<Point> Execute(IHardwareRobot robot)
        {
            _path = new List<Point>();
            _visited = new Dictionary<int, Dictionary<int, bool>>();

            //mark starting square as visited
            Visit(robot);

            var isRoomClean = false;
            while (!isRoomClean)
            {
                robot.TurnLeft();
                if (TryWalk(robot)) continue;

                robot.TurnRight();
                if (TryWalk(robot)) continue;

                robot.TurnRight();
                if (TryWalk(robot)) continue;

                isRoomClean = true;
            }
            return _path;
        }

        private void Visit(IHardwareRobot robot)
        {
            _path.Add(new Point(robot.X, robot.Y));
            if (!_visited.ContainsKey(robot.X))
                _visited.Add(robot.X, new Dictionary<int, bool>());
            _visited[robot.X].Add(robot.Y, true);
        }

        private bool IsValidDestination(IHardwareRobot robot)
        {
            return !robot.IsObstacle() && !IsVisited(NextX(robot.X, robot.FaceTo), NextY(robot.Y, robot.FaceTo));
        }

        private bool TryWalk(IHardwareRobot robot)
        {
            if (!IsValidDestination(robot)) return false;
            robot.Walk();
            Visit(robot);
            return true;
        }

        private static int NextX(int currentX, int faceTo)
        {
            if (faceTo == NORTH || faceTo == SOUTH) return currentX;
            return faceTo == EAST ? ++currentX : --currentX;
        }

        private static int NextY(int currentY, int faceTo)
        {
            if (faceTo == EAST || faceTo == WEST) return currentY;
            return faceTo == SOUTH ? ++currentY : --currentY;
        }

        private bool IsVisited(int x, int y)
        {
            return _visited.ContainsKey(x) && _visited[x].ContainsKey(y);
        }
    }
}
