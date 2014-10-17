public class Dreadnaught : Ship
{
    public Dreadnaught()
    {
        Console.WriteLine("Child Constructor.");
    }

    public static void Main()
    {
        Dreadnaught child = new Dreadnaught();

        child.print();
    }
}