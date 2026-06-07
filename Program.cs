using ProyectoSDL2.Engine;
using SDL2;
using System;
using System.Data;
using System.Media;



namespace ProyectoSDL2.Engine
{
    class Program
    {

        static void Main(string[] args)
        {
            Engine.Initialize();

            while (true)
            {
                Engine.Clear();
                Engine.Draw("assets/ship.png", 0, 0);
                Engine.Show();
            }
        }

    }

}

