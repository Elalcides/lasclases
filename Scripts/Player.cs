namespace ProyectoSDL2.Engine.Scripts
{
    public class Player
    {
        Transform transform;
        PlayerInput playerInput;
        Health health;

        public Transform Transform => transform;
        public PlayerInput PlayerInput => playerInput;
        public Health Health => health;

        public Player(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX, startPosY);
            playerInput = new PlayerInput(transform);
            health = new Health();
        }

        public void Update()
        {
            playerInput.Update();
        }

        public void Render()
        {
            Engine.Draw("assets/ship.png",transform.PosX, transform.PosY);
        }
    }
}
