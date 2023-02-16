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
    }
}