public class Program
{
    public static void Main(string[] args)
    {
        HourlyEmployee e1 = new HourlyEmployee("John", "Doe", 10.0);
        SalariedEmployee e2 = new SalariedEmployee("Sasha", "Brown", 500.00);
        Volunteer e3 = new Volunteer("Kate", "Smith");

        List<Employee> employees = new List<Employee>();
        employees.Add(e1);
        employees.Add(e2);
        employees.Add(e3);

        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.GetName()}'s pay: {e.CalculatePay()}");
        }
    }
}
