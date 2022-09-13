namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem");

            ContactDetails contacts = new ContactDetails();
            contacts.AddingPerson();
        }

    }
}