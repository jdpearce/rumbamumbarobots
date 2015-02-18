// Decompiled with JetBrains decompiler
// Type: RobotHardware.IHardwareRobot
// Assembly: RobotHardware, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B77775D-33AF-4F14-8F02-F0402356DB5D
// Assembly location: D:\Projects\rumbamumarobots\lib\RobotHardware.dll

namespace RobotHardware
{
  public interface IHardwareRobot
  {
    int TotalMovements { get; }

    int X { get; }

    int Y { get; }

    int FaceTo { get; }

    bool IsObstacle();

    void TurnRight();

    void TurnLeft();

    void Walk();

    void Reset();
  }
}
