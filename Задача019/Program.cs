Console.Write("Enter number: ");
string? number = Console.ReadLine();

void Number (string number)
{
if (number[0] == number [4] && number[1] == number[3])
{
    Console.WriteLine("Число является палиндромом!");
}
else
{
   Console.WriteLine("Число не является палиндромом!"); 
}
}

if (number.Length == 5)
{
    Number(number);
}
else
{
    Console.Write("Введите пятизначное число");
}

