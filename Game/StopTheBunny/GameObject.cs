namespace StopTheBunny
{

    public abstract class GameObject
    {
        public abstract UpperLeftPoint UpperLeftPoint { get; set; }

        public abstract char[,] SizeOfElement { get; }

        public abstract char Sign { get; }

        public abstract Color Color { get; }
        
    }
}
