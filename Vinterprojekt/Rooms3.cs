using System;
using System.Collections.Generic;
using Raylib_cs;

public class Rooms3
{
    public static (Rectangle, string) RoomOne(Rectangle playerRect,
                                                       float xMovement,
                                                       float yMovement,
                                                       string room,
                                                        List<Rectangle> walls,
                                                       Rectangle Roomport,
                                                       Rectangle Roomport3)
    {
            for (int i = 0; i < walls.Count; i++)
            {
                if (Raylib.CheckCollisionRecs(playerRect, walls[i]))
                {
                    playerRect.x -= xMovement;
                    playerRect.y -= yMovement;
                }
            }

            if (Raylib.CheckCollisionRecs(playerRect, Roomport))
            {
                room = "room2";
                playerRect.x = 690;
            }

            if (Raylib.CheckCollisionRecs(playerRect, Roomport3))
            {
                room = "room3";
                playerRect.x = 30;
            }

        return (playerRect, room);
    }
}