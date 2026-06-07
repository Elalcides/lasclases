namespace ProyectoSDL2.Engine.Scripts
{
    public enum GAME_STATE
    {
        START = 0,
        GAME =1,
        END =2
    }

    public class GameManager
    {
        static GameManager instance;
        int score;
        GAME_STATE GAME_STATE = GAME_STATE.START;
        LevelControl levelControl = new LevelControl();

        public LevelControl LevelControl
        {
            get { return levelControl; }
        }

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }

        public void Start()
        {
            levelControl.Start();
        }

        public void SetScore(int newScore)
        {
            score = newScore;
        }
        public void Render()
        {
            switch(GAME_STATE)
            {
                case GAME_STATE.START:
                    Engine.Clear();
                    Engine.Draw("assets/MainMenu.png", 0, 0);
                    Engine.Show();
                    break;
                // Add more cases for different screens if needed
                case GAME_STATE.GAME:
                    levelControl.Render();
                    break;
                case GAME_STATE.END:
                    Engine.Clear();
                    Engine.Draw("assets/PantallaDerrota.png", 0, 0);
                    Engine.Show();
                    break;
            }
        }

        public void Update()
        {
            switch (GAME_STATE)
            {
                case GAME_STATE.START:
                    if(Engine.KeyPress(Engine.KEY_X))
                    {
                        GAME_STATE = GAME_STATE.GAME;
                    }
                    break;
                // Add more cases for different screens if needed
                case GAME_STATE.GAME:
                    levelControl.Update();
                    break;
                case GAME_STATE.END:
                    Engine.Clear();
                    Engine.Draw("assets/PantallaDerrota.png", 0, 0);
                    Engine.Show();
                    break;
            }
        }
        public void ChangeGameState(GAME_STATE newState)
        {
            GAME_STATE = newState;
        }
    }
}
