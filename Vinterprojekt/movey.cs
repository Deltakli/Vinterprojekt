using System;
using System.Collections.Generic;
using Raylib_cs;

  public class TimerTwo
  {          
    public static (int, float, Rectangle) TimeTwo(int timer,
                                    float yMovement,
                                    Rectangle playerRect) 
      {

        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            yMovement = 5;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            yMovement = -5;
        }

         playerRect.y += yMovement;

           return (timer, yMovement, playerRect);
      }
  } 