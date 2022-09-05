namespace InterfaceDemo
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
