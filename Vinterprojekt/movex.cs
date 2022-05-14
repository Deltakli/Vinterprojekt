using System;
using System.Collections.Generic;
using Raylib_cs;

  public class Timer
  {          
    public static (int, float, Rectangle) TimeOne(int timer,
                                    float xMovement,
                                    Rectangle playerRect) 
      {

        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            xMovement = 5;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            xMovement = -5;
        }

        playerRect.x += xMovement;

           return (timer, xMovement, playerRect);
      }
  } 