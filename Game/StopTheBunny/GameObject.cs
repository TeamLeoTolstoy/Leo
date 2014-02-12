namespace StopTheBunny
{

    public abstract class GameObject
    {
        protected int posiotionRow;
        protected int positionCol;

        public int PositionRow
        {
            get { return this.posiotionRow; }
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
