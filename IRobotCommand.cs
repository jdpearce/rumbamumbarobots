using System.Collections.Generic;
using System.Drawing;
using RobotHardware;

namespace GoRumbaMumba
{
    /// <summary>
    /// Classes which implement this interface represent algorithms which 
    /// move an IHardwareRobot along a particular path and describe the path taken.
    /// </summary>
    public interface IRobotCommand
    {
        List<Point> Execute(IHardwareRobot robot);
    }
}
