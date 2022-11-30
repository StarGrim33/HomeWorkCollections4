using System.Collections.Generic;

namespace HomeWorkCollections4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> empoloyees = new();
            bool isProgrammOn = true;
            const string CommandAddDosier = "Добавить досье";
            const string CommandShowAllDosier = "Вывести все досье";
            const string CommandDeleteDosier = "Удалить досье";
            const string CommandExit = "Выход";

            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Напишите нужную команду");

            while (isProgrammOn)
            {
                ShowMenu();
                string? userMenuNavigate = Console.ReadLine();

                switch (userMenuNavigate)
                {
                    case CommandAddDosier:
                        AddDosier(empoloyees);
                        break;
                    case CommandShowAllDosier:
                        ShowAllDosier(empoloyees);
                        break;
                    case CommandDeleteDosier:
                        DeleteDosier(empoloyees);
                        break;
                    case CommandExit:
                        Console.Clear();
                        Console.SetCursorPosition(40, 5);
                        Console.WriteLine("Работа программы завершена.");
                        isProgrammOn = false;
                        break;
                    default:
                        Console.WriteLine("Не введено релеватного значения. Попробуйте еще раз.");
                        break;
                }

            }
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Меню: ");
            Console.WriteLine("-Добавить досье");
            Console.WriteLine("-Вывести все досье");
            Console.WriteLine("-Удалить досье");
            Console.WriteLine("-Выход");
        }

        static void AddDosier(Dictionary<string, string> employees)
        {
            Console.WriteLine("Введите ФИО: ");
            string? fullName = Console.ReadLine();
            
            if(employees.ContainsKey(fullName))
            {
                Console.WriteLine("Такое досье уже есть");
            }
            else
            {
                Console.WriteLine("Введите должность: ");
                string? position = Console.ReadLine();
                employees.Add(fullName, position);
            }
        }

        static void ShowAllDosier(Dictionary<string, string> employees)
        {
            Console.Clear();
            Console.WriteLine("Имеющиеся досье: ");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key + " - " + employee.Value);
            }
        }

        static void DeleteDosier(Dictionary<string, string> employees)
        {
            Console.WriteLine("Введите ФИО, чье досье Вы хотите удалить: ");
            string? userChoice = Console.ReadLine();

            if (employees.ContainsKey(userChoice))
            {
                employees.Remove(userChoice);
                Console.WriteLine("Удалено");
            }
            else
            {
                Console.WriteLine("Нет такого досье");
            }    
        }
    }
}