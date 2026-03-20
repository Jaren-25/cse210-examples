// A human with a phone number, an age, an address, and a phone number
public class Person : IPhoneNumber, IAddress
{
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _age;

    public Person(string name, int age, string phoneNumber, string address)
    {
        _name = name;
        _phoneNumber = phoneNumber;
        _address = address;
        _age = age;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public string GetAddress()
    {
        return _address;
    }

    public override string ToString()
    {
        return _name;
    }
}
