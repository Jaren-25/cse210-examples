public class Volunteer : Employee
{
    public Volunteer(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override double CalculatePay()
    {
        return 0;
    }

    public override string GetName()
    {
        return "Volunteer " + base.GetName();
    }
}
