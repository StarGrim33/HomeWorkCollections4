using System.Collections.Generic;

namespace HomeWorkCollections4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandAddDosier = "1";
            const string CommandShowAllDosiers = "2";
            const string CommandDeleteDosier = "3";
            const string CommandExit = "4";

            Dictionary<string, string> empoloyees = new();
            bool isProgrammOn = true;
            
            Console.SetCursorPosition(40, 0);
            Console.ForegroundColor = ConsoleColor.Red;

            while (isProgrammOn)
            {
                Console.WriteLine($"Меню: \n{CommandAddDosier}-Добавить досье\n{CommandShowAllDosiers}-Показать все досье\n{CommandDeleteDosier}-Удалить досье\n{CommandExit}-Выход");
                Console.WriteLine("Напишите нужную команду: ");
                string? userMenuNavigate = Console.ReadLine();

                switch (userMenuNavigate)
                {
                    case CommandAddDosier:
                        AddDosier(empoloyees);
                        break;
                    case CommandShowAllDosiers:
                        ShowAllDosiers(empoloyees);
                        break;
                    case CommandDeleteDosier:
                        DeleteDosier(empoloyees);
                        break;
                    case CommandExit:
                        isProgrammOn = false;
                        break;
                    default:
                        Console.WriteLine("Не введено релеватного значения. Попробуйте еще раз.");
                        break;
                }
            }
        }

        static void AddDosier(Dictionary<string, string> employees)
        {
            Console.WriteLine("Введите ФИО: ");
            string? fullName = Console.ReadLine();

            if (employees.ContainsKey(fullName))
            {
                Console.WriteLine("Такое досье уже есть");
            }
            else
            {
                Console.WriteLine("Введите должность: ");
                string? position = Console.ReadLine();
                employees.Add(fullName, position);
            }

            Console.Clear();
        }

        static void ShowAllDosiers(Dictionary<string, string> employees)
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