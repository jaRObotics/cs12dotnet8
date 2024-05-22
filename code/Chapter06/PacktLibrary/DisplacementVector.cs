﻿namespace Packt.Shared;

public record struct DisplacementVector
//ORIGINALLY WAS: public struct DisplacementVector
{
  public int X { get; set; }
  public int Y { get; set; }

  public DisplacementVector(int initialX, int initialY)
  {
    X = initialX;
    Y = initialY;
  }

  public static DisplacementVector operator +( //operator method in action
    DisplacementVector vector1,
    DisplacementVector vector2)
  {
    return new(
      vector1.X + vector2.X,
      vector1.Y + vector2.Y);
  }
}
