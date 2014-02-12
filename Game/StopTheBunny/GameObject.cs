namespace StopTheBunny
{

    public abstract class GameObject
    {
        public UpperLeftPoint UpperLeftPoint { get; set; }

        public abstract char Sign { get; set; }

        public abstract Color Color { get; set; }

        
    }
}
