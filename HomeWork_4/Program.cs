// Задача 3. 
// Напишите программу, которая задает массив из произвольного количества элементов и выводит их на экран

/*int [] NewArray (int size)
{
    int [] randomArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        randomArray [i] = new Random(). Next(-100, 100);
    }
    return randomArray;
}
 void PrintArray (int [] array2)
 {
    for (int i = 0; i < array2.Length; i++)
    Console.Write(array2 [i] + " ");
 }

 Console.WriteLine("Input length of array: ");
 int user_length = Convert.ToInt32(Console.ReadLine());

 int [] array3 = NewArray(user_length);
 PrintArray(array3);
 */

 // Задача 2. Напишите программу. которая принимает на вход число и выдает сумму цифр в числе.

 int SummofNumbers (int number)
 {
    int sum = 0;

    while (number > 0)
    {
        int num1 = number % 10;
        sum = sum + num1;
        number = number / 10;
    }
    return sum;

 }

 Console.WriteLine("Input your number: ");
 int user_number = Convert.ToInt32(Console.ReadLine());

 if (user_number < 0)
    Console.Write("Your number is incorrect");
else
 Console.Write($"Summ of digit {user_number} is {SummofNumbers(user_number)}");


/*int SummofNumbers (int number)
 {
    int sum = 0;

    while (number > 0)

    {
        int num1 = number % 10;
        sum = sum + num1;
        number = number / 10;
    }
    return sum;

 }

 Console.WriteLine("Input your number: ");
 int user_number = Convert.ToInt32(Console.ReadLine());

 int user_number1 = (-1) * user_number;

 if (user_number > 0)
    Console.Write($"Summ of digit {user_number} is {SummofNumbers(user_number)}");

 else
    Console.Write($"Summ of digit {user_number} is {SummofNumbers(user_number1)}");
    */


// Задача 1.
// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степнь В.


/*int Degree (int a, int b)
{
    int count = 1;
    int current = a;

    while (count < b)
    {
        int degree = current * a;
        current = degree;
        count++;
    }
    return current;
}

Console.WriteLine("Input first number: ");
 int first_number = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input second number: ");
 int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > 0 && second_number > 0)
    Console.Write($"Digit {first_number} in degree {second_number} is {Degree(first_number, second_number)}");

else 
    Console.Write("Your numbers is incorrect");
*/


    
/*void Stepen (int a, int b)
{
    if (a > 0 && b > 0)
    {
        double result = Math.Pow(a, b);
        Console.Write($"Digit {a} in degree {b} is {result}");
    }
    else
        Console.Write("your numbers is incorrect");

}

Console.WriteLine("Input first number: ");
 int first_number = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input second number: ");
 int second_number = Convert.ToInt32(Console.ReadLine());

 Stepen (first_number, second_number);
 */