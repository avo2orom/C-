// Ex Kettlebell problem
Console.WriteLine ("Enter 5 integer");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());
int maxnumber = number1;

if (number1 > maxnumber) maxnumber = number1;
if (number2 > maxnumber) maxnumber = number2;
if (number3 > maxnumber) maxnumber = number3;
if (number4 > maxnumber) maxnumber = number4;
if (number5 > maxnumber) maxnumber = number5;

Console.Write("maxnumber = ");
Console.WriteLine(maxnumber);