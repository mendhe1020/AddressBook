namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem");

            ContactDetails contacts = new ContactDetails();
            Contact contacts1 = new Contact();

            while (true)
            {
                Console.WriteLine("Enter the option : \n1)Add Contact \n2)Edit Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        contacts.AddingPerson(contacts1); 
                        contacts.Display();
                        break;
                    case 2:
                        contacts.Edit();        
                        contacts.Display();
                        break;
                    default:
                        Console.WriteLine("please choose correct options :");
                        break;
                }
            }
        }

    }
}