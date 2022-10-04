// See https://aka.ms/new-console-template for more information
/*void - невозвратный метод, для его использования не нужно использовать функцию return*/
void FillArray(int[] collection) // collection - наименование переменной
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //col - наименование переменной
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);