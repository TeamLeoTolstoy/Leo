namespace StopTheBunny
{

    public abstract class GameObject
    {
        public abstract UpperLeftPoint UpperLeftPoint { get; set; }

        public abstract int NumberOfRows { get; set; }
        public abstract int NumberOfCols { get; set; }

        public abstract char Sign { get; set; }

        public abstract Color Color { get; set; }
        
    }
}
