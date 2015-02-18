// Decompiled with JetBrains decompiler
// Type: RobotHardware.HardwareWithObstacles
// Assembly: RobotHardware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B77775D-33AF-4F14-8F02-F0402356DB5D
// Assembly location: D:\Projects\rumbamumarobots\lib\RobotHardware.dll

namespace RobotHardware
{
  public class HardwareWithObstacles : Hardware
  {
    private int[,] obstacles;

    public HardwareWithObstacles(int maxX, int maxY)
      : base(maxX, maxY)
    {
      this.obstacles = new int[maxX, maxY];
      for (int index1 = 0; index1 < maxX; ++index1)
      {
        int index2 = 0;
        for (; index1 < maxX; ++index1)
          this.obstacles[index1, index2] = 0;
      }
    }

    public void AddObstacle(int x, int y)
    {
      this.obstacles[x, y] = 1;
    }

    public override bool IsObstacle()
    {
      bool flag = base.IsObstacle();
      if (!flag)
      {
        switch (this._lookingTo)
        {
          case 0:
            flag = this.obstacles[this._x + 1, this._y] == 1;
            break;
          case 1:
            flag = this.obstacles[this._x, this._y + 1] == 1;
            break;
          case 2:
            flag = this.obstacles[this._x - 1, this._y] == 1;
            break;
          default:
            flag = this.obstacles[this._x, this._y - 1] == 1;
            break;
        }
      }
      return flag;
    }
  }
}
