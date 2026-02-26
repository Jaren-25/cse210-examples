public class Student : Person
{
    private double _gpa;

    public Student(string name, int age, bool isLeftHanded, double gpa) : base(name, age, isLeftHanded)
    {
        _gpa = gpa;
    }
}