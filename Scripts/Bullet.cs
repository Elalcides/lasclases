namespace ProyectoSDL2.Engine.Scripts
{
    public class Bullet
    {
        Transform transform;
        private Animation bulletAnim;
        private List<Image> animationImages = new List<Image>();
        //Constructor, se llama cuando se crea
        public Bullet(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX + 44, startPosY);

            animationImages.Add(Engine.LoadImage("assets/Bullet/Idle/0.png"));
            animationImages.Add(Engine.LoadImage("assets/Bullet/Idle/1.png"));
            animationImages.Add(Engine.LoadImage("assets/Bullet/Idle/2.png"));
            animationImages.Add(Engine.LoadImage("assets/Bullet/Idle/3.png"));

            bulletAnim = new Animation(animationImages, 0.1f);
        }

        public void Update()
        {
            transform.Translate(0, -5);
            bulletAnim.Update();
        }

        public void Render()
        {
            Engine.Draw(bulletAnim.currentFrame, transform.PosX, transform.PosY);
            
        }
    }
}
