using System;
using System.Collections.Generic;
using Raylib_cs;


public class Rooms2
{

    public static (Rectangle, string, bool, int) RoomTwo(Rectangle playerRect,
                                                       float xMovement,
                                                       float yMovement,
                                                       bool key1PickedUp,
                                                       Rectangle key1,
                                                       int keyAll,
                                                       string room,
                                                        List<Rectangle> walls,
                                                       Rectangle Roomport2)
    {
        for (int i = 0; i < walls.Count; i++)
        {
            if (Raylib.CheckCollisionRecs(playerRect, walls[i]))
            {
                playerRect.x -= xMovement;
                playerRect.y -= yMovement;
            }
        }

        if (Raylib.CheckCollisionRecs(playerRect, Roomport2))
        {
            room = "room1";
            playerRect.x = 30;
        }

        if (key1PickedUp == false && Raylib.CheckCollisionRecs(playerRect, key1))
        {
            key1PickedUp = true;
            keyAll += 1;
        }


        return (playerRect, room, key1PickedUp, keyAll);
    }
}