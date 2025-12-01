// Команды CLI
//
// dotnet new create console --name homework
// Создаём проект с макетом консольного приложения и собственным названием 
//
// cd homework
// Переходим в каталог проекта и там пишем код в Program.cs
//
// dotnet build homework.csproj
// Собираем наш проект
//
// dotnet run
// Запускаем собранное приложение

public class Contact
{
    private string _name;
    private string _phoneNumber;
    private string _email;

    public Contact (string name, string phoneNumber, string email) 
    { 
        _name = name;
        _phoneNumber = phoneNumber; 
        _email = email; 
    }

    public override string ToString()
    {
        return $"{_name}\nНомер: {_phoneNumber}\nEmail: {_email}\n";
    }

    public string GetName()
    {
        return _name;
    }
    
    public int CompareTo(Contact other)
    {
        var a = _name;
        var b = other._name;

        var minLength = a.Length < b.Length ? a.Length : b.Length;

        for (var i = 0; i < minLength; i++)
        {
            if (a[i] != b[i])
            {
                return a[i] - b[i];
            }
        }
        
        if (a.Length == b.Length)
        {
            return 0;
        }
        return a.Length - b.Length;
    }
}

public static class Program
{
    public static void Main()
    {
        var contacts = new List<Contact>();

        while (true)
        {
            Console.WriteLine("Выберите команду:\n1. Добавить контакт\n2. Найти контакт\n3. Вывести все контакты\n4. Выйти\n");
            var choose = Console.ReadLine();
            
            switch (choose)
            {
                case "1":
                    AddContact(contacts);
                    break;
                case "2":
                    Console.WriteLine($"\n{FindByName(contacts)}\n");
                    break;
                case "3":
                    ListAllContacts(contacts);
                    break;
                case "4":
                    return;
                default:
                Console.WriteLine("Выберите команду из списка ниже по номеру!\n");
                break;
            }
        }
    }
    private static void AddContact(List<Contact> contacts)
    {
        Console.WriteLine("\nУкажите имя контакта");
        var name = Console.ReadLine();

        Console.WriteLine("\nУкажите номер телефона");
        var phoneNumber = Console.ReadLine();

        Console.WriteLine("\nУкажите адрес электронной почты");
        var email = Console.ReadLine();

        if (name != null && phoneNumber != null && email != null)
        {
            contacts.Add(new Contact(name, phoneNumber, email));
        }
        
        Console.WriteLine("\nНовый контакт успешно добавлен");
    }
    private static string FindByName(List<Contact> contacts)
    {
        Console.WriteLine("\nУкажите имя искомого контакта");
        var name = Console.ReadLine();

        for (var index = 0; index < contacts.Count; index++)
        {
            var contact = contacts[index];
            if (contact.GetName() == name)
            {
                return contact.ToString();
            }
        }

        return "\nКонтакта с таким именем нет";
    }

    private static void ListAllContacts(List<Contact> contacts)
    {
        Sort(contacts, 0, contacts.Count - 1);

        for (var index = 0; index < contacts.Count; index++)
        {
            Console.WriteLine(contacts[index].ToString());
        }
            
        Console.WriteLine("\n");
    }

    private static void Sort(List<Contact> list, int left, int right)
    {
        while (left < right)
        {
            var pivotIndex = Partition(list, left, right);

            Sort(list, left, pivotIndex - 1);
            left = pivotIndex + 1;
        }
    }

    private static int Partition(List<Contact> list, int left, int right)
    {
        var pivot = list[right];
        var i = left - 1;
        Contact buf;
        
        for (var j = left; j < right; j++)
        {
            if (list[j].CompareTo(pivot) <= 0)
            {
                i++;
                buf = list[i];
                list[i] = list[j];
                list[j] = buf;
            }
        }
        
        buf = list[i + 1];
        list[i + 1] = list[right];
        list[right] = buf;
        return i + 1;
    }

}
