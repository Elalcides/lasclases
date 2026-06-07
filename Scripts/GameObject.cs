namespace ProyectoSDL2.Engine.Scripts
{
    public abstract class GameObject
    {
        protected Transform transform;
        public Transform Transform => transform;

        public GameObject(int startPosX, int startPosY)
        {
            transform = new Transform(startPosX, startPosY);
        }

        public abstract void Render();

        public abstract void Update();
    }
}