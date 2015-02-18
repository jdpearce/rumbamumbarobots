// Decompiled with JetBrains decompiler
// Type: RobotHardware.Hardware
// Assembly: RobotHardware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B77775D-33AF-4F14-8F02-F0402356DB5D
// Assembly location: D:\Projects\rumbamumarobots\lib\RobotHardware.dll

namespace RobotHardware
{
  public class Hardware : IHardwareRobot
  {
    protected int _movements = 0;
    protected int _x = 0;
    protected int _y = 0;
    protected int _MaxX = 0;
    protected int _MaxY = 0;
    protected int _lookingTo = 0;

    public int TotalMovements
    {
      get
      {
        return this._movements;
      }
    }

    public int X
    {
      get
      {
        return this._x;
      }
    }

    public int Y
    {
      get
      {
        return this._y;
      }
    }

    public int FaceTo
    {
      get
      {
        return this._lookingTo;
      }
    }

    public Hardware(int maxX, int maxY)
    {
      this._MaxX = maxX - 1;
      this._MaxY = maxY - 1;
    }

    public virtual bool IsObstacle()
    {
      switch (this._lookingTo)
      {
        case 0:
          return this._MaxX == this._x;
        case 1:
          return this._MaxY == this._y;
        case 2:
          return this._x == 0;
        default:
          return this._y == 0;
      }
    }

    public void TurnRight()
    {
      ++this._movements;
      this._lookingTo = this._lookingTo == 3 ? 0 : this._lookingTo + 1;
    }

    public void TurnLeft()
    {
      ++this._movements;
      this._lookingTo = this._lookingTo == 0 ? 3 : this._lookingTo - 1;
    }

    public void Walk()
    {
      switch (this._lookingTo)
      {
        case 0:
          if (this.IsObstacle())
            break;
          ++this._x;
          ++this._movements;
          break;
        case 1:
          if (this.IsObstacle())
            break;
          ++this._y;
          ++this._movements;
          break;
        case 2:
          if (this.IsObstacle())
            break;
          --this._x;
          ++this._movements;
          break;
        default:
          if (this.IsObstacle())
            break;
          --this._y;
          ++this._movements;
          break;
      }
    }

    public void Reset()
    {
      this._movements = 0;
      this._x = 0;
      this._y = 0;
      this._lookingTo = 0;
    }
  }
}
