public class Program
{
    public static void Main(string[] args)
    {
	// Create some objects
        Person p1 = new Person("Buzz Lightyear", 25, "999-999-9999", "Planet Morph");
        Company c1 = new Company("BYU-Idaho", "208-496-1411", "Rexburg", "Idaho");
	Phone ip1 = new Phone("iPhone", "John Doe", "123-456-7890");

	// Gather all the objects with phone numbers
        List<IPhoneNumber> phoneNumbers = new List<IPhoneNumber>();
        phoneNumbers.Add(p1);
	phoneNumbers.Add(c1);
	phoneNumbers.Add(ip1);

	// Gather all the objects with addresses
        List<IAddress> addresses = new List<IAddress>();
        addresses.Add(p1);
        addresses.Add(c1);

	// Print the phone numbers
	Console.WriteLine("Phone Numbers: ");
	foreach(IPhoneNumber phone in phoneNumbers)
        {
            Console.WriteLine(phone.ToString() + ": " + phone.GetPhoneNumber());
        }
	
	// Print the addresses
	Console.WriteLine("\nAddresses: ");
	foreach(IAddress add in addresses)
        {
            Console.WriteLine(add.ToString() + ": " + add.GetAddress());
        }
    }
}
