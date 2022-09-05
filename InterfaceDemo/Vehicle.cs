namespace InterfaceDemo
{
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
