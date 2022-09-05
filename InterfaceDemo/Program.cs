namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ticket t1 = new Ticket(10);
            //Ticket t2 = new Ticket(10);

            //System.Console.WriteLine(t1.Equals(t2));

            Chair officeChar = new Chair("Red", "Plastic");
            Chair gamingChar = new Chair("Blue", "Plastic");

            Car damagedCar = new Car(80f, "Green");

            damagedCar.DestroyablesNearby.Add(officeChar);
            damagedCar.DestroyablesNearby.Add(gamingChar);

            damagedCar.Destroy();
        }
    }
}
