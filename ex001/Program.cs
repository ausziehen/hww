// // Task 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// //Напишите программу, которая покажет количество чётных чисел в массиве.
// Console.Write("Input array length: ");
// int arr = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[arr];

// void Array(int arr)
// {
// for (int i = 0; i < arr; i++)
// {
// randomArray[i] = new Random().Next(100,1000);
// Console.Write(randomArray[i] + " ");
// }
// }
// int Amount(int[] randomArray)
// {
// int Amount = 0;
// for (int i = 0; i < randomArray.Length; i++)
// {
// if (randomArray[i] % 2 == 0)
// Amount = Amount + 1;
// }
// return Amount;
// }
// Array(arr);
// Console.WriteLine(" ");
// Console.WriteLine($"Количество чётных чисел в массиве: {Amount(randomArray)}");




// // Task 36. Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// Console.Write("Input array length: ");
// int arr = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[arr];
// void Array(int arr)
// {
// for (int i = 0; i < arr; i++)
// {
// randomArray[i] = new Random().Next(1,10);
// Console.Write(randomArray[i] + " ");
// }
// }
// int Amount(int[] randomArray)
// {
// int sum = 0;
// int i = 1;
// while (i < randomArray.Length)
// {
// sum = sum + randomArray[i];
// i = i + 2;
// }
// return sum;
// }
// Array(arr);
// Console.WriteLine("");
// Console.Write($"Cумма элементов, стоящих на нечётных позициях: {Amount(randomArray)}");




// // Task 38. Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// Console.Write("Input array length: ");
// int arr = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[arr];
// void Array(int arr)
// {
//     Random rand = new Random();
//     for (int i = 0; i < arr; i++)
//     {
//         randomArray[i] = rand.NextDouble();
//         Console.Write($"{Math.Round(randomArray[i],2)} ");
//     }
// }
// double Diff(double[] randomArray)
// {
//     double min = randomArray[0];
//     double max = randomArray[0];
//     int i = 1;
//     while (i < randomArray.Length)
//     {
//         if (max < randomArray[i])
//             max = randomArray[i];
//         if (min > randomArray[i])
//             min = randomArray[i];
//         i = i + 1;
//     }
//     return max - min;
// }
// Array(arr);
// Console.WriteLine("");
// Console.Write($"Difference of min and max values: {Math.Round(Diff(randomArray), 2)}");