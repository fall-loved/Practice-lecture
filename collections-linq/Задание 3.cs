using System.Globalization;

namespace ConsoleApp3;

class Program
{
    // Сущность: Employee (Id, Name, Department, Salary, HireDate)
    // Запросы:
    // 1. Выбрать сотрудников отдела "IT" с зарплатой выше 100000, отсортированных по дате найма (от новых к старым).
    // 2. Найти среднюю зарплату по каждому отделу.
    // 3. Выбрать три самых высокооплачиваемых сотрудника.

    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice Johnson", Department = "IT", Salary = 120000, HireDate = new DateTime(2023, 5, 10) },
            new Employee { Id = 2, Name = "Bob Smith", Department = "IT", Salary = 95000, HireDate = new DateTime(2022, 3, 15) },
            new Employee { Id = 3, Name = "Charlie Brown", Department = "HR", Salary = 60000, HireDate = new DateTime(2021, 7, 20) },
            new Employee { Id = 4, Name = "Diana Prince", Department = "Finance", Salary = 110000, HireDate = new DateTime(2020, 1, 5) },
            new Employee { Id = 5, Name = "Ethan Hunt", Department = "IT", Salary = 130000, HireDate = new DateTime(2024, 2, 1) },
            new Employee { Id = 6, Name = "Fiona Gallagher", Department = "Marketing", Salary = 75000, HireDate = new DateTime(2019, 11, 12) },
            new Employee { Id = 7, Name = "George Miller", Department = "IT", Salary = 105000, HireDate = new DateTime(2023, 9, 30) },
            new Employee { Id = 8, Name = "Hannah Davis", Department = "Finance", Salary = 98000, HireDate = new DateTime(2022, 6, 18) },
            new Employee { Id = 9, Name = "Ian Curtis", Department = "IT", Salary = 102000, HireDate = new DateTime(2021, 12, 25) },
            new Employee { Id = 10, Name = "Julia Roberts", Department = "HR", Salary = 65000, HireDate = new DateTime(2020, 8, 14) },
            new Employee { Id = 11, Name = "Kevin Lee", Department = "IT", Salary = 115000, HireDate = new DateTime(2024, 7, 7) },
            new Employee { Id = 12, Name = "Laura Palmer", Department = "Marketing", Salary = 72000, HireDate = new DateTime(2018, 4, 9) },
            new Employee { Id = 13, Name = "Michael Scott", Department = "Sales", Salary = 90000, HireDate = new DateTime(2017, 2, 2) },
            new Employee { Id = 14, Name = "Nina Williams", Department = "IT", Salary = 125000, HireDate = new DateTime(2025, 1, 10) },
            new Employee { Id = 15, Name = "Oscar Wilde", Department = "Finance", Salary = 108000, HireDate = new DateTime(2023, 4, 22) }
        };

        var first = employees.Where(e => e.Department == "IT")
        .Where(e => e.Salary > 100000)
        .OrderBy(e => e.HireDate);

        foreach (var employee in first)
        {
            Console.WriteLine(employee);
        }

        var second = employees.GroupBy(e => e.Department).Select(g => new
        {
            name = g.Key,
            salary = g.Average(e => e.Salary)
        });

        foreach (var department in second)
        {
            Console.WriteLine($"{department.name}, {department.salary}");
        }

        var third = employees.OrderByDescending(e => e.Salary).Take(3);

        foreach (var employee in third)
        {
            Console.WriteLine(employee);
        }
    }

    class Employee
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Department { get; set;}
        public decimal Salary { get; set;}
        public DateTime HireDate { get; set;}

        public override string ToString()
        {
            var str =
            $"id: {Id}, name: {Name}, department: {Department}, salary: {Salary}, hire_date: {HireDate.ToShortDateString()}";
            return str;
        }
    }
}
