// Функции(Методы) и массивы 
int Max(int arg1, int arg2, int arg3) // Начало функции
{
    int result = arg1;                  //Условия функции
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


Console.WriteLine("Enter 9 integer");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());
int number6 = Convert.ToInt32(Console.ReadLine());
int number7 = Convert.ToInt32(Console.ReadLine());
int number8 = Convert.ToInt32(Console.ReadLine());
int number9 = Convert.ToInt32(Console.ReadLine());

/* Варик 1
int maxnumber1 = Max(number1, number2, number3);
int maxnumber2 = Max(number4, number5, number6);
int maxnumber3 = Max(number7, number8, number9);
int supermax = Max(maxnumber1, maxnumber2, maxnumber3);
*/

//Варик 2, компактный
int supermax = Max(Max(number1, number2, number3), Max(number4, number5, number6), Max(number7, number8, number9));
Console.WriteLine(supermax);