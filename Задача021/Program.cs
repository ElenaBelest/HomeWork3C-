Console.Write("Enter X1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y1 : ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Z1 : ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter X2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y2 : ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Z2 : ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt (Math.Pow((x1-x2),2)+ Math.Pow((y1-y2),2)+ Math.Pow((z1-z2),2));

Console.WriteLine($"A({x1},{y1},{z1});B({x2},{y2},{z2}) -> {result}");