using System;
using System.Linq;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            //// Случайно генерируем числа N и M
            //int N = random.Next(-100, 100);
            //int M = random.Next(-100, 100);

            //// Создаем массив чисел от N до M
            //int[] numbers = new int[Math.Abs(M - N) + 1];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = N + i;
            //}

            //// Выводим квадраты чисел на экран
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine($"Квадрат числа {num}: {num * num}");
            //}

            //// Запрашиваем у пользователя пять чисел
            //Console.WriteLine("Введите пять чисел:");
            //int[] userNumbers = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    userNumbers[i] = int.Parse(Console.ReadLine());
            //}

            //// Выводим сумму, среднее арифметическое и произведение
            //int sum = userNumbers.Sum();
            //double average = userNumbers.Average();
            //int product = userNumbers.Aggregate((x, y) => x * y);
            //Console.WriteLine($"Сумма: {sum}");
            //Console.WriteLine($"Среднее арифметическое: {average}");
            //Console.WriteLine($"Произведение: {product}");

            //// Опрашиваем пять пользователей об их именах и возрасте
            //string[] names = new string[5];
            //int[] ages = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Введите имя пользователя {i + 1}:");
            //    names[i] = Console.ReadLine();
            //    Console.WriteLine($"Введите возраст пользователя {i + 1}:");
            //    ages[i] = int.Parse(Console.ReadLine());
            //}

            //// Вычисляем общий возраст, средний возраст
            //int totalAge = ages.Sum();
            //double averageAge = ages.Average();

            //// Находим самых старых и молодых пользователей
            //int maxAge = ages.Max();
            //int minAge = ages.Min();
            //string oldestPerson = names[Array.IndexOf(ages, maxAge)];
            //string youngestPerson = names[Array.IndexOf(ages, minAge)];

            //// Выводим результаты
            //Console.WriteLine($"Общий возраст: {totalAge}");
            //Console.WriteLine($"Средний возраст: {averageAge}");
            //Console.WriteLine($"Самый старший пользователь: {oldestPerson}, возраст {maxAge}");
            //Console.WriteLine($"Самый молодой пользователь: {youngestPerson}, возраст {minAge}");

            //// Скажите пользователю «Купи слона!» до тех пор, пока он не напишет «слон»
            //string input;
            //do
            //{
            //    Console.WriteLine("Купи слона!");
            //    input = Console.ReadLine();
            //} while (input.ToLower() != "слон");

            //// Выводим пять случайных чисел
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Случайное число {i + 1}: {random.Next()}");
            //}

            // Запросите у пользователя 4 числа и выведите наибольшее четырехзначное число, составленное из них
            Console.WriteLine("Введите четыре четырехзначных числа через пробел:");
            string[] userInputs = Console.ReadLine().Split(' ');
            int maxFourDigitNumber = userInputs.Select(int.Parse).Where(x => x >= 1000 && x <= 9999).Max();
            Console.WriteLine($"Наибольшее четырехзначное число: {maxFourDigitNumber}");

            // Выведите таблицу умножения на экран
            Console.WriteLine("Таблица умножения:");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
