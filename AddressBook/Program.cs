
class AddressBook
{
    private string first_name;
    private string last_name;
    private string address;
    private string state;
    private int zip;
    private long phone_number;
    private string email;

    public void printInf()
    {
        Console.WriteLine("First_name:"+ first_name);
        Console.WriteLine("last_name:"+ last_name);
        Console.WriteLine("addres:"+ address);
        Console.WriteLine("state:"+ state);
        Console.WriteLine("zip:"+ zip);
        Console.WriteLine("phone_number:"+ phone_number);
        Console.WriteLine("email:"+ email);
    }
    static void Main(string[]args)
    {
        AddressBook asd = new AddressBook();
        asd.first_name = "Anurag";
        asd.last_name = "Mendhe";
        asd.address = "jatharpetha";
        asd.state = "Maharashtra";
        asd.zip = 44400;
        asd.phone_number = 7038315684;
        asd.email = "anurag.mendhe14@gmail.com";
        asd.printInf();
    }
}
