Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов ");
for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i,3)+ " ");
}