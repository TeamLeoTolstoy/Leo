namespace StopTheBunny
{

    public abstract class GameObject
    {
        protected int posiotionX;
        protected int positionY;

        public int PositionX
        {
            get { return this.posiotionX; }
            set
            {
                if (value<0 || value>)
                {
                    
                }
            }
        }

        public abstract int PositionY { get; set; }

        public abstract char Sign { get; set; }

        public abstract Color Color { get; set; }

        
    }
}
