using System;
using System.Collections.Generic;
using Raylib_cs;

public class Rooms
{
    public static (Rectangle, string, bool, int) RoomThree(Rectangle playerRect,
                                                       float xMovement,
                                                       float yMovement,
                                                       bool key2PickedUp,
                                                       Rectangle key2,
                                                       int keyAll,
                                                       string room,
                                                        List<Rectangle> walls,
                                                       Rectangle Roomport4)
    {
        for (int i = 0; i < walls.Count; i++)
        {
            if (Raylib.CheckCollisionRecs(playerRect, walls[i]))
            {
                playerRect.x -= xMovement;
                playerRect.y -= yMovement;
            }
        }

        if (Raylib.CheckCollisionRecs(playerRect, Roomport4))
        {
            room = "room1";
            playerRect.x = 690;
        }

        if (key2PickedUp == false && Raylib.CheckCollisionRecs(playerRect, key2))
        {
            key2PickedUp = true;
            keyAll += 1;
        }

        return (playerRect, room, key2PickedUp, keyAll);
    }
}