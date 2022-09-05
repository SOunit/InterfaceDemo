using System.Collections.Generic;

namespace InterfaceDemo
{
    internal class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color) : base(speed, color)
        {
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            System.Console.WriteLine($"Playing destruction sound {DestructionSound}");
            System.Console.WriteLine($"Create fire");

            foreach (var destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
