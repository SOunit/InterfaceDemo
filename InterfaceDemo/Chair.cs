namespace InterfaceDemo
{
    internal class Chair : Furniture, IDestroyable
    {
        public Chair(string color, string material) : base(color, material)
        {
            DestructionSound = "CharDesctructionSound.mp3";
        }

        public string DestructionSound { get; set; }

        public void Destroy()
        {
            System.Console.WriteLine("destroy chair");
        }
    }
}
