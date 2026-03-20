// A class for phones
public class Phone : IPhoneNumber
{
    private string _type;
    private string _owner;
    private string _phoneNumber;

    public Phone(string type, string owner, string phoneNumber)
    {
        _type = type;
        _owner = owner;
        _phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }

    public override string ToString()
    {
        return $"{_owner}'s {_type}";
    }
}
