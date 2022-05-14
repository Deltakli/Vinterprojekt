using System;
using System.Collections.Generic;
using Raylib_cs;

  static public class Dock
  {

       public static int t;

      public static int ClockT(int t,
                                int timer)
     {
       t = Raylib.GetKeyPressed();

        if (timer > 0)
        {
            timer--;
        }
        
       if (t != 0 && t != (int)KeyboardKey.KEY_D 
                && t != (int)KeyboardKey.KEY_A
                && t != (int)KeyboardKey.KEY_S
                && t != (int)KeyboardKey.KEY_W)
        {
            timer = 60;
           Console.WriteLine(t);
        }

      return(timer);
     }
  }