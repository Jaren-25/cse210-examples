public class HourlyEmployee : Employee
{
    double _hourlyPay;
    public HourlyEmployee(string firstName, string lastName, double hourlyPay) : base(firstName, lastName)
    {
        _hourlyPay = hourlyPay;
    }

    public override double CalculatePay()
    {
        // Calculate pay for 80 hours of work
        return _hourlyPay * 80;
    }
}
