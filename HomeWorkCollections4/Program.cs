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
                        AddDosier(ref empoloyees);
                        break;
                    case CommandShowAllDosier:
                        ShowAllDosier(empoloyees);
                        break;
                    case CommandDeleteDosier:
                        DeleteDosier(ref empoloyees);
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
            Console.WriteLine("1 - Добавить досье");
            Console.WriteLine("2 - Вывести все досье");
            Console.WriteLine("3 - Удалить досье");
            Console.WriteLine("4 - Выход");
        }

        static void AddDosier(ref Dictionary<string, string> employees)
        {
            Console.WriteLine("Введите ФИО и должность: ");
            employees.Add(Console.ReadLine(), Console.ReadLine());
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

        static void DeleteDosier(ref Dictionary<string, string> employees)
        {
            Console.WriteLine("Введите ФИО, чье досье Вы хотите удалить: ");
            employees.Remove(Console.ReadLine());
        }
    }
}