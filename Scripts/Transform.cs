namespace ProyectoSDL2.Engine.Scripts
{
    public class Transform
    {
        //posiciones
        int posX,posY;

        public int PosX => posX; 
        public int PosY => posY;

        //constructor
        public Transform(int x, int y)
        {
            posX = x;
            posY = y;
        }

        //translate
        public void Translate(int moveX, int moveY)
        {
            posX += moveX;
            posY += moveY;
        }

        public void SetPosition(int x, int y)
        {
            posX = x;
            posY = y;
        }
    }
}
