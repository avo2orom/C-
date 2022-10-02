/*
// Ex003v1 Sum of 2 intereg numbers
int numberA = 3; //int = целое число
int numberB = 5;
Console.WriteLine(numberA + numberB);
*/

/*
// Ex003v2 Sum of 2 intereg numbers
int numberA = 3; //int = целое число
int numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);
*/

/*
// Ex003v3 Sum of 2 intereg numbers
Console.WriteLine("Enter a integer 1");
int numberA = Convert.ToInt32(Console.ReadLine()); //int = целое число
Console.WriteLine("Enter a integer 2");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA + numberB;
Console.WriteLine("Checkout sum:");
Console.WriteLine(result);
*/

// Ex003v4 Sum of 2 RANDOM intereg numbers
int numberA = new Random().Next(1, 10); //Next() - уровни дидапозона данных!!! Max число = 9 (max-1)
Console.WriteLine(numberA); // выводит значения рандомного числа 1
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB); // выводит значения рандомного числа 2
Console.WriteLine(numberA + numberB); // Выводит резик