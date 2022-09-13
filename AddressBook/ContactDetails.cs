using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactDetails
    {
        public void AddingPerson()
        {
            Contact contact = new Contact()
            {
                FirstName = "Anurag",
                LastName = "Mendhe",
                Address = "Jyoti Nagar",
                City = "Akola",
                State = "Maharashtra",
                Zip = "444005",
                PhoneNumber = "7038315684",
                Email = "anurag.mendhe14@gmail.com"
            };
            Console.WriteLine("Name of person : " + contact.FirstName + " " + contact.LastName);
            Console.WriteLine("Address of person is : " + contact.Address);
            Console.WriteLine("Name of City : " + contact.City);
            Console.WriteLine("Name of State :" + contact.State);
            Console.WriteLine("Zip Code:" + contact.Zip);
            Console.WriteLine("Email of person : " + contact.Email);
            Console.WriteLine("Phone Number of person : " + contact.PhoneNumber);
        }
    }
}
