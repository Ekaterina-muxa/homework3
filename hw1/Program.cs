Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;
int min = numberB;

if (numberA > numberB) max = numberA; min = numberB;
if (numberB > numberA) max = numberB; min = numberA;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);




