// // Завдання 1
// // Вивести на екран номери всіх елементів, що не потрапляють в заданий інтервал. Використовуючи одновимірний масив і двовимірний


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Виберіть розмірність масиву: ");
//         Console.WriteLine("1. Одновимірний");
//         Console.WriteLine("2. Двовимірний");
//         int choice = int.Parse(Console.ReadLine());

//         if (choice == 1)
//         {
//             Console.WriteLine("Введіть розмірність одновимірного масиву:");
//             int size = int.Parse(Console.ReadLine());
//             int[] array = new int[size];

//             Console.WriteLine($"Введіть {size} елементів масиву:");

//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = int.Parse(Console.ReadLine());
//             }

//             Console.WriteLine("Введіть початок інтервалу:");
//             int startInterval = int.Parse(Console.ReadLine());

//             Console.WriteLine("Введіть кінець інтервалу:");
//             int endInterval = int.Parse(Console.ReadLine());

//             Console.WriteLine("Елементи, що не потрапляють в інтервал:");

//             for (int i = 0; i < size; i++)
//             {
//                 if (array[i] < startInterval || array[i] > endInterval)
//                 {
//                     Console.WriteLine($"Елемент {i}: {array[i]}");
//                 }
//             }
//         }
//         else if (choice == 2)
//         {
//             Console.WriteLine("Введіть кількість рядків для двовимірного масиву:");
//             int rows = int.Parse(Console.ReadLine());

//             Console.WriteLine("Введіть кількість стовпців для двовимірного масиву:");
//             int cols = int.Parse(Console.ReadLine());

//             int[,] array2D = new int[rows, cols];

//             Console.WriteLine($"Введіть {rows} рядків по {cols} елементів кожен:");

//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < cols; j++)
//                 {
//                     array2D[i, j] = int.Parse(Console.ReadLine());
//                 }
//             }

//             Console.WriteLine("Введіть початок інтервалу:");
//             int startInterval = int.Parse(Console.ReadLine());

//             Console.WriteLine("Введіть кінець інтервалу:");
//             int endInterval = int.Parse(Console.ReadLine());

//             Console.WriteLine("Елементи, що не потрапляють в інтервал:");

//             for (int i = 0; i < rows; i++)
//             {
//                 for (int j = 0; j < cols; j++)
//                 {
//                     if (array2D[i, j] < startInterval || array2D[i, j] > endInterval)
//                     {
//                         Console.WriteLine($"Елемент [{i},{j}]: {array2D[i, j]}");
//                     }
//                 }
//             }
//         }
//         else
//         {
//             Console.WriteLine("Невірний вибір. Будь ласка, виберіть 1 або 2.");
//         }
//     }
// }


// // Завдання 2
// // Дана послідовність з n дійсних чисел. Знайти кількість пар сусідніх елементів, різниця між якими  дорівнює заданому числу. При вирішенні завдання використовувати одновимірний масив


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Запитуємо користувача про розмірність масиву
//         Console.Write("Введіть розмірність масиву: ");
//         int n = int.Parse(Console.ReadLine());

//         // Ініціалізуємо масив та заповнюємо його значеннями
//         double[] sequence = new double[n];
//         Console.WriteLine("Введіть елементи масиву:");
//         for (int i = 0; i < n; i++)
//         {
//             Console.Write($"Елемент {i + 1}: ");
//             sequence[i] = double.Parse(Console.ReadLine());
//         }

//         // Запитуємо користувача про задане число
//         Console.Write("Введіть задане число: ");
//         double targetDifference = double.Parse(Console.ReadLine());

//         // Лічильник пар
//         int pairCount = 0;

//         // Шукаємо пари сусідніх елементів, різниця між якими дорівнює заданому числу
//         for (int i = 0; i < n - 1; i++)
//         {
//             if (Math.Abs(sequence[i] - sequence[i + 1]) == targetDifference)
//             {
//                 pairCount++;
//             }
//         }

//         // Виводимо результат
//         Console.WriteLine($"Кількість пар сусідніх елементів з різницею {targetDifference}: {pairCount}");
//     }
// }


// // Завдання 3
// // Дано масив розміром n×n, елементи якого цілі  числа. Підрахувати середнє арифметичне парних елементів, розташованих нижче головної діагоналі. При вирішенні завдання використовувати двовимірний масив


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Розмірність квадратної матриці
//         int n = 4; // Можна ввести будь-яке значення

//         // Ініціалізація матриці
//         int[,] matrix = new int[n, n];

//         // Заповнення матриці випадковими значеннями (для демонстрації)
//         Random rnd = new Random();
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 matrix[i, j] = rnd.Next(1, 101); // Генерувати випадкові числа від 1 до 100
//             }
//         }

//         // Виведення початкової матриці на консоль (для перевірки)
//         Console.WriteLine("Початкова матриця:");
//         PrintMatrix(matrix);

//         // Підрахунок середнього арифметичного парних елементів нижче головної діагоналі
//         double sum = 0;
//         int count = 0;
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if (i > j && matrix[i, j] % 2 == 0)
//                 {
//                     sum += matrix[i, j];
//                     count++;
//                 }
//             }
//         }

//         // Обробка випадку, коли немає парних елементів нижче головної діагоналі
//         double average = count > 0 ? sum / count : 0;

//         // Виведення результату
//         Console.WriteLine($"Середнє арифметичне парних елементів нижче головної діагоналі: {average}");

//         Console.ReadLine();
//     }

//     // Метод для виведення матриці на консоль
//     static void PrintMatrix(int[,] matrix)
//     {
//         int n = matrix.GetLength(0);
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// // Завдання 4
// // Дано східчастий масив з n рядків, у рядках по mj (j=1..n) елементів. Знайти мінімальний елемент в кожному стовпці і записати дані в новий масив.

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Оголошення і введення розмірів масиву
//         Console.WriteLine("Введіть кількість рядків: ");
//         int n = int.Parse(Console.ReadLine());
//         Console.WriteLine("Введіть кількість стовпців: ");
//         int m = int.Parse(Console.ReadLine());

//         // Створення східчастого масиву
//         int[,] array = new int[n, m];
//         Console.WriteLine("Введіть елементи масиву:");

//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < m; j++)
//             {
//                 Console.Write($"Елемент [{i},{j}]: ");
//                 array[i, j] = int.Parse(Console.ReadLine());
//             }
//         }

//         // Створення масиву для зберігання мінімальних елементів з кожного стовпця
//         int[] minElements = new int[m];

//         // Знаходження мінімального елемента в кожному стовпці
//         for (int j = 0; j < m; j++)
//         {
//             int min = array[0, j];
//             for (int i = 1; i < n; i++)
//             {
//                 if (array[i, j] < min)
//                 {
//                     min = array[i, j];
//                 }
//             }
//             minElements[j] = min;
//         }

//         // Виведення мінімальних елементів кожного стовпця
//         Console.WriteLine("\nМінімальні елементи кожного стовпця:");
//         for (int j = 0; j < m; j++)
//         {
//             Console.WriteLine($"Стовпець {j + 1}: {minElements[j]}");
//         }
//     }
// }
