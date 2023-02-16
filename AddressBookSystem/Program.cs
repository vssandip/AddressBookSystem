namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome Address Book System ");
            //creating object of addressbook
            AddressBook addressBook = new AddressBook();
            //getting Op in Constructor with paratmers
            addressBook.addContacts("Sandip", "Shinde", "Kachrewadi", "Solapur", "MH", 413305, 9503508344, "Sandipshindesr9503@gmail.com");
            // called Print method 
            addressBook.print();
            Console.ReadLine();
        }
        // take Input And Add To Contacts
        public static void takeInputAndAddToContacts(AddressBook addressBook)
        {
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            string email = Console.ReadLine();
            addressBook.addContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
            Console.ReadLine();
        }
    }
}