public class Program
{

    public static Main()
    {
        var phoneBook = new PhoneBook();

        phoneBook.AddPhone("Peter Gof", "+375331112233");
        phoneBook.AddPhone("John Eof", "+375441234567");
        phoneBook.AddPhone("Will Smith", "+375251234567");

        Console.WriteLine(phoneBook.GetPhoneByName("John Eof"));

        phoneBook.RemovePhone("Will Smith");
    }

    public class PhoneBook
    {
        //     Разработайте класс PhoneBook, который хранит пары "Имя - Телефон" в коллекции Dictionary<string, string>.
        //     Реализуйте методы для добавления контакта, поиска номера по имени и удаления контакта.
        //     Соблюдайте принципы SOLID
        private static Dictionary<string, string> Phone;

        public PhoneBook()
        {
            Phone = new Dictionary<string, string>();
        }

        public void AddPhone(string name, string phone)
        {
            Phone.Add(name, phone);
        }

        public string? GetPhoneByName(string name)
        {
            var phone = Phone.GetValueOrDefault(name);
            return phone;
        }

        public void RemovePhone(string name)
        {
            Phone.Remove(name);
        }
    }
}
