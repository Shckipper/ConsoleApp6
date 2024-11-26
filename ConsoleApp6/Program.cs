using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class StringComparisonDemo
    {
        static void Main()
        {
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите вторую строку:");
            string str2 = Console.ReadLine();

            Console.WriteLine("Введите подстроку для поиска:");
            string str3 = Console.ReadLine();

            // Сравнение с учетом регистра
            int compareResult = string.Compare(str1, str2);
            Console.WriteLine($"\nCompare: '{str1}' vs '{str2}' -> Result: {compareResult} (0 - равны, <0 - первая строка меньше, >0 - больше)");

            // Сравнение без учета регистра
            int compareOrdinalResult = string.CompareOrdinal(str1, str2);
            Console.WriteLine($"CompareOrdinal: '{str1}' vs '{str2}' -> Result: {compareOrdinalResult}");

            // Проверка на равенство
            bool equalsResult = string.Equals(str1, str2);
            Console.WriteLine($"Equals: '{str1}' == '{str2}' -> {equalsResult}");

            // Операторы == и !=
            Console.WriteLine($"Operator ==: '{str1}' == '{str2}' -> {str1 == str2}");
            Console.WriteLine($"Operator !=: '{str1}' != '{str2}' -> {str1 != str2}");

            // Поиск подстроки
            int index = str1.IndexOf(str3);
            Console.WriteLine($"IndexOf: Подстрока '{str3}' в строке '{str1}' -> Индекс: {index}");

            // Проверка содержимого
            bool containsResult = str1.Contains(str3);
            Console.WriteLine($"Contains: '{str1}' содержит '{str3}' -> {containsResult}");
            Console.ReadKey();
        }
    }
}
