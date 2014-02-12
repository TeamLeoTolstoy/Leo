namespace StopTheBunny
{

    public abstract class GameObject
    {
        public abstract UpperLeftPoint UpperLeftPoint { get; set; }

        public abstract char[,] SizeOfElement { get; set; }

        public abstract char Sign { get; }

        public abstract Color Color { get; set; }
        
    }
}
