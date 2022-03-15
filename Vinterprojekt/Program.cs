using System;
using Raylib_cs;
Everything();
static void Everything()
{
Raylib.InitWindow(800, 600, "Happy stone game");
Raylib.SetTargetFPS(60);

Rectangle playerRect = new Rectangle(150, 150, 85, 100);
Rectangle enemyRect = new Rectangle(100, 100, 100, 100);
// Rectangle doorRect = new Rectangle()
Rectangle Roomport = new Rectangle(0, 200, 20, 200);
Rectangle Roomport2 = new Rectangle(780, 200, 20, 200);
Rectangle Roomport3 = new Rectangle(780, 200, 20, 200);
Rectangle Roomport4 = new Rectangle(0, 200, 20, 200);
Rectangle Door = new Rectangle(50,550,700,600);
Rectangle Key1 = new Rectangle(300, 300, 30, 30);
bool key1PickedUp = false;
int Keyall = 0;
Font f1 = Raylib.LoadFont(@"Metrophobic.ttf");

Texture2D playerImage = Raylib.LoadTexture("piskel.png");
Texture2D DoorImage = Raylib.LoadTexture("Door.png");
//playerRect.width = playerImage.width;
//playerRect.height = playerImage.height;

Rectangle wallRect = new Rectangle(0, 0, 50, 200);
Rectangle wallRect2 = new Rectangle(0, 0, 800, 60);
Rectangle wallRect3 = new Rectangle(750, 0, 50, 200);
Rectangle wallRect4 = new Rectangle(750, 400, 50, 200);
Rectangle wallRect5 = new Rectangle(0, 400, 50, 200);
Rectangle wallRect6 = new Rectangle(0, 550, 800, 60);
Rectangle wallRect7 = new Rectangle(750, 0, 50, 600);
Rectangle wallRect8 = new Rectangle(0, 0, 270, 60);
Rectangle wallRect9 = new Rectangle(530, 0, 220, 60);
string room = "room1";

while (Raylib.WindowShouldClose() == false)
{
    Console.WriteLine(room);
    float xMovement = 0;
    float yMovement = 0;
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        xMovement = 5;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        yMovement = 5;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        yMovement = -5;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        xMovement = -5;
    }

    playerRect.x += xMovement;
    playerRect.y += yMovement;

    if (room == "room1")
    {

        if (Raylib.CheckCollisionRecs(playerRect, wallRect))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect2))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect3))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect4))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect5))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
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


    }
    else if (room == "room2")
    {
        if (Raylib.CheckCollisionRecs(playerRect, wallRect))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect8))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect9))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect3))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect4))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }

        if (Raylib.CheckCollisionRecs(playerRect, wallRect5))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }

        if (Raylib.CheckCollisionRecs(playerRect, wallRect6))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }


        if (Raylib.CheckCollisionRecs(playerRect, Roomport2))
        {
            room = "room1";
            playerRect.x = 30;
        }

        if (key1PickedUp == false && Raylib.CheckCollisionRecs(playerRect, Key1))
        {
            key1PickedUp = true;
             Keyall += 1;
        }
    }

    if (room == "room3")
    {
        if (Raylib.CheckCollisionRecs(playerRect, wallRect))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
        if (Raylib.CheckCollisionRecs(playerRect, wallRect2))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }
    
        if (Raylib.CheckCollisionRecs(playerRect, wallRect7))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }

        if (Raylib.CheckCollisionRecs(playerRect, wallRect5))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }

        if (Raylib.CheckCollisionRecs(playerRect, wallRect6))
        {
            playerRect.x -= xMovement;
            playerRect.y -= yMovement;
        }

        if (Raylib.CheckCollisionRecs(playerRect, Roomport4))
        {
            room = "room1";
            playerRect.x = 690;
        }
    }



    // if (playerImage = Color.DARKBLUE)
    //Här börjar ritningen av karektären
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BROWN);
    // Raylib.DrawRectangleRec(playerRect, Color.LIME);

    Raylib.DrawTexture(playerImage, (int)playerRect.x, (int)playerRect.y, Color.WHITE);

    // Raylib.DrawRectangle(300, 300, 200, 200, Color.GRAY);

    if (room == "room1")
    {
        
        Raylib.DrawRectangleRec(wallRect, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect2, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect3, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect4, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect5, Color.GRAY);
        Raylib.DrawText($"{Keyall}", 20,15, 40,Color.BLACK);
        Rectangle overlap = Raylib.GetCollisionRec(playerRect, Roomport);
        //Raylib.DrawRectangleRec(playerRect, Color.YELLOW);
        Raylib.DrawRectangleRec(Roomport, Color.BLUE);
        Raylib.DrawRectangleRec(Roomport3, Color.BLUE);
        Raylib.DrawRectangleRec(overlap, Color.BROWN);
        //Raylib.DrawRectangleRec(Door, Color.WHITE);
    }
    else if (room == "room2")
    {
        Raylib.DrawRectangleRec(wallRect, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect8, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect9, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect3, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect4, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect5, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect6, Color.GRAY);
        //Raylib.DrawRectangleRec(Key, Color.GREEN);
        Rectangle overlap = Raylib.GetCollisionRec(playerRect, Roomport2);
        //Raylib.DrawRectangleRec(playerRect, Color.YELLOW);
        Raylib.DrawRectangleRec(Roomport2, Color.BLUE);
        Raylib.DrawRectangleRec(overlap, Color.BROWN);

        if (key1PickedUp == false)
        {
            Raylib.DrawRectangleRec(Key1, Color.GREEN);
        }

        //Raylib.DrawRectangleRec()
    }

    else if (room == "room3")
    {
        Raylib.DrawRectangleRec(wallRect, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect2, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect7, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect5, Color.GRAY);
        Raylib.DrawRectangleRec(wallRect6, Color.GRAY);
        Rectangle overlap = Raylib.GetCollisionRec(playerRect, Roomport4);
        //Raylib.DrawRectangleRec(playerRect, Color.YELLOW);
        Raylib.DrawRectangleRec(Roomport4, Color.BLUE);
        Raylib.DrawRectangleRec(overlap, Color.BROWN);
    }

    Raylib.EndDrawing();

}
}