namespace ProyectoSDL2.Engine.Scripts
{
    public class Bullet
    {
        Transform transform;

        //Constructor, se llama cuando se crea
        public Bullet(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX + 44, startPosY);
        }

        public void Update()
        {
            transform.Translate(0, -5);
        }

        public void Render()
        {
            Engine.Draw("assets/bullet.png", transform.PosX, transform.PosY);
        }
    }
}
