// Ex005v1 Selection with condition
Console.WriteLine("Enter your name");
string username = Console.ReadLine();

if(username.ToLower() == "alex") // ToLower - переводит все символы строки в нижний регистр
{
    Console.WriteLine("Hello, dear Alex!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}