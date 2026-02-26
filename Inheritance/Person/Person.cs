public class Person
{
    private string _name;
    private int _age;

    private bool _isLeftHanded;

    private double _gpa;

    private double _salary;

    public Person()
    {
        _name = "Unknown";
    }
    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public Person(string name, int age, bool isLeftHanded)
    {
        _name = name;
        _age = age;
        _isLeftHanded = isLeftHanded;
    }

    public Person(string name, int age, bool isLeftHanded, double gpa, double salary)
    {
        _name = name;
        _age = age;
        _isLeftHanded = isLeftHanded;
        _gpa = gpa;
        _salary = salary;
    }


    public Person(string name)
    {
        _name = name;
    }

    public Person(int age)
    {
        _name = "Unknown";
        _age = age;
    }

    public string GetName()
    {
        return _name;
    }

    public string Display()
    {
        return _name + " (" + _age.ToString() + ") - " + _isLeftHanded;
    }
}