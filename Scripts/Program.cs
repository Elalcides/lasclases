using SDL2;
namespace ProyectoSDL2.Engine.Scripts
{
    class Program
    {
        static float deltaTime;
        static bool bIsGameActive = true;

        public static float DeltaTime => deltaTime;

        static void Main(string[] args)
        {

            Engine.Initialize();

            GameManager.Instace.Start();

            DateTime startTime = DateTime.Now;
            float currentTime;

            float lastFrameTime = 0;

            while (bIsGameActive)
            {
                if (Engine.KeyPress(Engine.KEY_ESC))
                {
                    bIsGameActive = false;
                    SDL.SDL_Quit();
                }

                currentTime = (float)(DateTime.Now - startTime).TotalSeconds;
                deltaTime = currentTime - lastFrameTime;
                lastFrameTime = currentTime;

                GameManager.Instace.Update();
                GameManager.Instace.Render();
            }

        }
    }
}