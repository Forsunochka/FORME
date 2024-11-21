using LABA_3._1;

internal class Program
{
    static void Main(string[] args)
    {
        Reptiles r = new Reptiles("Lizard", new DateTime(2022, 05, 11), 3, true);
        Console.WriteLine(r);
        r.MakeSound();
        Console.WriteLine("_____________________________________________________________________________________________");
        Mlecopitayshee m = new Mlecopitayshee("Korova", new DateTime(2020, 12, 4), 200, "Myyyyyyyyyyy");
        Console.WriteLine(m);
        m.MakeSound();
        Console.WriteLine("_____________________________________________________________________________________________");
        Mlecopitayshee m1 = new Mlecopitayshee("CAt", new DateTime(2019, 12, 18), 5, "Mau MAU Mau");
        Console.WriteLine(m1);
        m1.MakeSound();
        Console.WriteLine("_____________________________________________________________________________________________");
        Nasekomoe n = new Nasekomoe("Pauk", new DateTime(2024, 01, 10), 0.25, true);
        Console.WriteLine(n);
        n.MakeSound();
        Console.WriteLine("_____________________________________________________________________________________________");
        Fish f = new Fish("Gustera", new DateTime(2023, 12, 9), 1.25, true);
        Console.WriteLine(f);
        f.MakeSound();
        Console.WriteLine("_____________________________________________________________________________________________");
        Bird b = new Bird("Kukuffka", new DateTime(2022, 08, 17), 2, true, "Ku-Kuuu");
        Console.WriteLine(b);
        b.MakeSound();
        b.Fly();
        Console.WriteLine("_____________________________________________________________________________________________");
    }
}
