using System;

namespace Sotrudnik
{
    // Определение структуры Employee
    struct Employee
    {
        public string Name;      // Поле для имени сотрудника
        public string Vacancy;   // Поле для типа вакансии
        public int[] HireDate;    // Поле для даты приема на работу (например, день, месяц, год)
        public int Salary;        // Поле для зарплаты

        // Конструктор для инициализации полей структуры
        public Employee(string name, string vacancy, int[] hireDate, int salary)
        {
            Name = name;
            Vacancy = vacancy;
            HireDate = hireDate;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main()
        {
            int[] hireDate1 = { 1, 5, 2023 };
            Employee employee1 = new Employee("Жумагалым Бауыржан", "Developer", hireDate1, 50000);

            int[] hireDate2 = { 15, 8, 2022 };
            Employee employee2 = new Employee("Жумагалым Балжан", "Manager", hireDate2, 60000);

            // Вывод информации о сотрудниках
            Console.WriteLine($"Имя: {employee1.Name}, Вакансия: {employee1.Vacancy}, Зарплата: {employee1.Salary}");
            Console.WriteLine($"Имя: {employee2.Name}, Вакансия: {employee2.Vacancy}, Зарплата: {employee2.Salary}");

            if (employee1.Salary > employee2.Salary)
            {
                Console.WriteLine($"{employee1.Name} получает больше зарплату чем {employee2.Name}");
            }
            else if (employee1.Salary < employee2.Salary)
            {
                Console.WriteLine($"{employee2.Name} получает больше зарплату чем {employee1.Name}");
            }
            else
            {
                Console.WriteLine("Зарплаты сотрудников равны");
            }


            Console.ReadLine();
        }
    }
}