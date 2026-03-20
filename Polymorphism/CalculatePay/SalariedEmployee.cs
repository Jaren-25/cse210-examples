public class SalariedEmployee : Employee
{
    double _biweeklyPay;
    public SalariedEmployee(string firstName, string lastName, double biweeklyPay) : base(firstName, lastName)
    {
        _biweeklyPay = biweeklyPay;
    }

    public override double CalculatePay()
    {
        // Calculate pay for two weeks
        return _biweeklyPay;
    }
}
