                    // 1
// using System;

// class Program
// {
//     static void Main(){
//         Console/WriteLine("sdfadfa")
//         Console/WriteLine("sdfadfa")
//         Console/WriteLine("sdfadfa")
//     }
// }
                     //2
// using System;

// Class Program
// {
//     static void Main(){
//         Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
//         double num1 =  Convert to double(Console.RreadLine());

//         Console.WriteLine("введите 2 число")
//         double num2 = Convert to double(Console.ReadLine());

//         Console.WriteLine("введите операцию");
//         string op = Console.Readline();
        
//         string op = Console.ReadLine();

//         if (op == "+") Console.WriteLine(num1 + num2);
//         else if (op == "-") Console.WriteLine(num1 - num2);
//         else if (op == "*") Console.WriteLine(num1 * num2);
//         else if (op == "/") Console.WriteLine(num1 / num2);
//         }
//     }
//3
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество баллов (от 0 до 100): ");
        
        
//         if (int.TryParse(Console.ReadLine(), out int score))
//         {
//             string result = GetGrade(score);
//             Console.WriteLine($"Результат: {result}");
//         }
//         else
//         {
//             Console.WriteLine("Ошибка: введите целое число.");
//         }
//     }

//     static string GetGrade(int score)
//     {
        
//         if (score < 0 || score > 100)
//         {
//             return "Ошибка: баллы должны быть в диапазоне от 0 до 100.";
//         }

       
//         if (score >= 90)
//         {
//             return "отлично";
//         }
//         else if (score >= 75)
//         {
//             return "хорошо";
//         }
//         else if (score >= 60)
//         {
//             return "+";
//         }
//         else
//         {
//             return "-";
//         }
//     }
// }
//4
// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int secretNumber = random.Next(1, 101); 
//         int attempts = 0;

//         Console.WriteLine("Игра «Угадай число»!");
//         Console.WriteLine("Я загадал число от 1 до 100.");
//         Console.WriteLine("Для выхода из игры введите: exit");
//         Console.WriteLine("----------------------------------");

//         while (true)
//         {
//             Console.Write("Введите ваше число: ");
//             string input = Console.ReadLine()?.Trim();

            
//             if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
//             {
//                 Console.WriteLine($"Вы вышли из игры. Загаданное число было: {secretNumber}.");
//                 break;
//             }

            
//             if (!int.TryParse(input, out int guess))
//             {
//                 Console.WriteLine("Ошибка! Введите целое число от 1 до 100 или 'exit' для выхода.");
//                 continue;
//             }

//             attempts++; 
//             if (guess < secretNumber)
//             {
//                 Console.WriteLine("Больше!");
//             }
//             else if (guess > secretNumber)
//             {
//                 Console.WriteLine("Меньше!");
//             }
//             else
//             {
//                 Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток.");
//                 break;
//             }
//         }
//     }
// }
//5
// using System;
// class Program
// {
//     static void Main()
//     {
//         string name = ReadString("Введите ваше имя: ");
//         int age = ReadInt("Введите ваш возраст: ");
//         string city = ReadString("Введите ваш город: ");
//         string profile = CreateProfileText(name, age, city);
//         PrintProfile(profile);
//     }
//     static string ReadString(string prompt)
// }
    