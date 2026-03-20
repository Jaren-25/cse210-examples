public abstract class Employee
{
    protected string _firstName;
    protected string _lastName;

    public Employee(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public virtual string GetName()
    {
        return _firstName + " " + _lastName;
    }

    public abstract double CalculatePay();

    public override string ToString()
    {
        return this.GetName();
    }
}
