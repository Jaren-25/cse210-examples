// A class for companies with phone numbers and addresses
public class Company : IPhoneNumber, IAddress
{
    private string _name;
    private string _phoneNumber;
    private string _city;
    private string _state;

    public Company(string name, string phoneNumber, string city, string state)
    {
        _name = name;
        _phoneNumber = phoneNumber;
        _city = city;
	    _state = state;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public string GetAddress()
    {
        return $"{_city}, {_state}";
    }

    public override string ToString()
    {
        return _name;
    }
}
