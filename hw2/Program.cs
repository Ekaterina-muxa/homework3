Console.WriteLine("Введите число numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число numberC: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > numberB) max = numberA; 
if (numberB > numberA) max = numberB; 
if (numberC > numberA) max = numberC; 
if (numberC > numberB) max = numberC; 
Console.Write("max = ");
Console.WriteLine(max);