using System;
using System.Collections.Generic;
using Raylib_cs;
Everything();
static void Everything()
{
    //Fönstrets namn och storlek och hur mycket Frame per second det är
    Raylib.InitWindow(800, 600, "Happy stone game");
    Raylib.SetTargetFPS(60);

    //Alla structioner som finns
    Rectangle playerRect = new Rectangle(150, 150, 85, 100);
    Rectangle enemyRect = new Rectangle(100, 100, 100, 100);
    // Rectangle doorRect = new Rectangle()
    Rectangle Roomport = new Rectangle(0, 200, 20, 200);
    Rectangle Roomport2 = new Rectangle(780, 200, 20, 200);
    Rectangle Roomport3 = new Rectangle(780, 200, 20, 200);
    Rectangle Roomport4 = new Rectangle(0, 200, 20, 200);
    Rectangle Door = new Rectangle(50, 550, 700, 600);
    Rectangle Key1 = new Rectangle(300, 300, 30, 30);
    Rectangle Key2 = new Rectangle(400, 200, 30, 30);
    bool key2PickedUp = false;
    bool key1PickedUp = false;
    int Keyall = 0;
    Font f1 = Raylib.LoadFont(@"Metrophobic.ttf");

    int timer = 0;

    Texture2D playerImage = Raylib.LoadTexture("piskel.png");
    Texture2D DoorImage = Raylib.LoadTexture("Door.png");

    //Alla vägar som finns
    Rectangle wallRect = new Rectangle(0, 0, 50, 200);
    Rectangle wallRect2 = new Rectangle(0, 0, 800, 60);
    Rectangle wallRect3 = new Rectangle(750, 0, 50, 200);
    Rectangle wallRect4 = new Rectangle(750, 400, 50, 200);
    Rectangle wallRect5 = new Rectangle(0, 400, 50, 200);
    Rectangle wallRect6 = new Rectangle(0, 550, 800, 60);
    Rectangle wallRect7 = new Rectangle(750, 0, 50, 600);
    Rectangle wallRect8 = new Rectangle(0, 0, 270, 60);
    Rectangle wallRect9 = new Rectangle(530, 0, 220, 60);


    //Lista på alla vägar som är i rum 1
    List<Rectangle> room1walls = new List<Rectangle>();
    room1walls.Add(wallRect);
    room1walls.Add(wallRect2);
    room1walls.Add(wallRect3);
    room1walls.Add(wallRect4);
    room1walls.Add(wallRect5);

    //Lista på alla vägar som är i rum 2
    List<Rectangle> room2walls = new List<Rectangle>();
    room2walls.Add(wallRect);
    room2walls.Add(wallRect8);
    room2walls.Add(wallRect9);
    room2walls.Add(wallRect3);
    room2walls.Add(wallRect4);
    room2walls.Add(wallRect5);
    room2walls.Add(wallRect6);

    //Lista på alla vägar som är i rum 3
    List<Rectangle> room3walls = new List<Rectangle>();
    room3walls.Add(wallRect);
    room3walls.Add(wallRect2);
    room3walls.Add(wallRect7);
    room3walls.Add(wallRect3);
    room3walls.Add(wallRect5);
    room3walls.Add(wallRect6);

    string room = "room1";

    //karektärens rörelsen
    while (Raylib.WindowShouldClose() == false)
    {
        // Console.WriteLine(room);
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

        if (timer > 0)
        {
            timer--;
        }

        int t = Raylib.GetKeyPressed();
        
        if (t != 0 && t != (int)KeyboardKey.KEY_D 
                && t != (int)KeyboardKey.KEY_A
                && t != (int)KeyboardKey.KEY_S
                && t != (int)KeyboardKey.KEY_W)
        {
            timer = 60;
            Console.WriteLine(t);
        }

        playerRect.x += xMovement;
        playerRect.y += yMovement;

        //Alla rum som finns och vad de har i sig i listor
        if (room == "room1")
        {
            (playerRect, room) = Rooms3.RoomOne(playerRect, xMovement, yMovement, room, room1walls, Roomport, Roomport3);
        }
        else if (room == "room2")
        {
            (playerRect, room, key1PickedUp, Keyall) = Rooms2.RoomTwo(playerRect, xMovement, yMovement, key1PickedUp, Key1, Keyall, room, room2walls, Roomport2);
        }

        if (room == "room3")
        {
            (playerRect, room, key2PickedUp, Keyall) = Rooms.RoomThree(playerRect, xMovement, yMovement, key2PickedUp, Key2, Keyall, room, room3walls, Roomport4);

        }


        //Här börjar ritningen av karektären
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BROWN);
        Raylib.DrawTexture(playerImage, (int)playerRect.x, (int)playerRect.y, Color.WHITE);

        //Här börjar ritningen av rum 1
        if (room == "room1")
        {
            //for each loppar 

            for (int i = 0; i < room1walls.Count; i++)
            {
                Raylib.DrawRectangleRec(room1walls[i], Color.GRAY);
            }
            Raylib.DrawText("How you move is by pressing W for Up, A for Left, D for Right and S for down", 25, 5, 19, Color.BLACK);
            Raylib.DrawText("Your objective is to collect all 5 Keys to Escape this house", 25, 30, 19, Color.BLACK);
            Raylib.DrawText($"{Keyall}", 20, 65, 40, Color.BLACK);
            Rectangle overlap = Raylib.GetCollisionRec(playerRect, Roomport);
            Raylib.DrawRectangleRec(Roomport, Color.BLUE);
            Raylib.DrawRectangleRec(Roomport3, Color.BLUE);
            Raylib.DrawRectangleRec(overlap, Color.BROWN);
        }
        //Här börjar ritningen av rum 2
        else if (room == "room2")
        {
            for (int i = 0; i < room2walls.Count; i++)
            {
                Raylib.DrawRectangleRec(room2walls[i], Color.GRAY);
            }
            Rectangle overlap = Raylib.GetCollisionRec(playerRect, Roomport2);
            Raylib.DrawRectangleRec(Roomport2, Color.BLUE);
            Raylib.DrawRectangleRec(overlap, Color.BROWN);

            //Ritar ut "nyckeln1" när den inte har blivit tagen
            if (key1PickedUp == false)
            {
                Raylib.DrawRectangleRec(Key1, Color.GREEN);
            }

        if (timer > 0)
        {
           Raylib.DrawText("you are pressing the wrong KEYS!", (int)playerRect.x - 80, (int)playerRect.y - 20, 19, Color.BLACK);
        }

        }

        //Här börjar ritningen av rum 3
        else if (room == "room3")
        {
            for (int i = 0; i < room3walls.Count; i++)
            {
                Raylib.DrawRectangleRec(room3walls[i], Color.GRAY);
            }
            Rectangle overlap = Raylib.GetCollisionRec(playerRect, Roomport4);
            Raylib.DrawRectangleRec(Roomport4, Color.BLUE);
            Raylib.DrawRectangleRec(overlap, Color.BROWN);


            //Ritar ut "nyckeln2" när den inte har blivit tagen
            if (key2PickedUp == false)
            {
                Raylib.DrawRectangleRec(Key2, Color.GREEN);
            }

        }

        Raylib.EndDrawing();

    }
}