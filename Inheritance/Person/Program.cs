using System;

public class Program
{
    public static void Main(string[] args)
    {
        Student leroy = new Student("Leroy Anderson", 20, false, 4.0);
        Teacher broCrosby = new Teacher("Brother Crosby", 43, true, 100.0);
        Console.WriteLine(leroy.Display());
        Console.WriteLine(broCrosby.Display());
    }
}
