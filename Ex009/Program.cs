// Array
// Функции(Методы) и массивы 
int Max(int arg1, int arg2, int arg3) // Начало функции
{
    int result = arg1;                  //Условия функции
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
             //0   1  2   3  4  5  6  7  8
int[] array = {43,99,182,43,830,4,26,74,555};

/*
array[0] = 12;    //присвоить значение 0 элементу массива
Console.WriteLine(array[0]); // Вывести 0 элемент массива
*/

int supermax = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(supermax);