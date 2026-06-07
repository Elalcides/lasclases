namespace ProyectoSDL2.Engine
{
    class Program
    {
        static int posX = 200;
        static Player player;
        static Enemy enemy;
        static Enemy enemy2;
        static Enemy enemy3;
        static List<Enemy> enemyList = new List<Enemy>();

        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            float deltaTime;
            float currentTime;
            float lastFrameTime = 0;
            float timerLog = 0;

            

            player = new Player(200, 200);
            enemy = new Enemy(0, 0);
            enemy2 = new Enemy(100, 100);
            enemy3 = new Enemy(300, 300);

            enemyList.Add(enemy);
            enemyList.Add(enemy2);
            enemyList.Add(enemy3);

            Engine.Initialize();
            Engine.Debug("Engine inicializado");
            Engine.Debug(startTime.ToString());

            while (true)
            {
                currentTime = (float)(DateTime.Now - startTime).TotalSeconds;
                deltaTime = currentTime - lastFrameTime;
                lastFrameTime = currentTime;
                timerLog += deltaTime;

                Update();
                Render();
            }
        }
        static void Update()
        {
            player.Update();

            for(int i=0; i < enemyList.Count; i++)
            {
                enemyList[i].Update();
            }
        }
        static void Render()
        {
            Engine.Clear();
            player.Render();

            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].Render();
            }
            //otros Renders
            Engine.Show();
        }
    }
}
//*******==============================para abajo anda todo bien===============================*********
/*namespace ProyectoSDL2.Engine
{
    class Program
    {
        static int posX = 200;
        static Player player;
        static Player player2;

        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            float deltaTime;
            float currentTime;
            float lastFrameTime = 0;
            float timerLog = 0;

            player = new Player(200, 200);
            player2 = new Player(300, 300);

            Engine.Initialize();
            Engine.Debug("Engine inicializado");
            Engine.Debug(startTime.ToString());

            while (true)
            {
                // compute total seconds since start as a float
                currentTime = (float)(DateTime.Now - startTime).TotalSeconds;

                // compute delta time since last frame
                deltaTime = currentTime - lastFrameTime;
                lastFrameTime = currentTime;

                // accumulate elapsed time in timerLog
                timerLog += deltaTime;

                if (timerLog > 4)
                {
                    Engine.Debug("Han pasado 4 segundos");
                    timerLog = 0;
                    posX += 10;
                }

                Render();
            }
        }
        static void Render()
        {
            Engine.Clear();
            //Engine.Draw("assets/ship.png", 200, 200);
            player.Render();
            player2.Render();
            Engine.Show();
        }
    }
}

*/




//*******==============================para abajo anda todo bien===============================*********
/*using ProyectoSDL2.Engine;
using SDL2;
using System;
using System.Data;
using System.Diagnostics;

namespace ProyectoSDL2.Engine
{
    class Program
    {
        static int x = 0;
        static int angle = 0;
        static bool canMove = true;

        static Image player = Engine.LoadImage("assets/ship.png");
        static Image enemy = Engine.LoadImage("assets/enemy.png");

        static DateTime startTime;
        static float lastFrameTime;
        static float deltaTime;
        static float currentTime;

        static void Main(string[] args)
        {
            Engine.Initialize();
            Engine.Debug("Engine initialized");

            startTime = DateTime.Now;

            while (true)
            {
                Input();
                Update();
                Render();
            }
        }

        static void Input()
        {
            if (Engine.KeyPress(Engine.KEY_DOWN))
            {
                Engine.Debug("Down key is pressed");
                Console.Write("down");
            }
 
        }

        static void Update()
        {
            angle++;
            currentTime = (float)(DateTime.Now - startTime).TotalSeconds;
            deltaTime = currentTime - lastFrameTime;
            lastFrameTime = currentTime;
            if(currentTime > 4)
            {
                canMove = false;
            }

            if(canMove)
            {
                x++;
            }
        }

        static void Render()
        {
            Engine.Clear();
            Engine.Draw(player, x, 0, angle);
            Engine.Draw(enemy, x, 100, angle);
            Engine.Show();
        }
    }
}*/