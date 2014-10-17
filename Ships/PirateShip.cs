public class PirateShip : Ship
{
    public PirateShip()
    {
        Console.WriteLine("Child Constructor.");
    }

    public static void Main()
    {
        PirateShip child = new PirateShip();

        child.print();
    }
}