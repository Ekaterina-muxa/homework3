Console.WriteLine("Введите число numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = numberA % 2; 

if(result == 0)
{
    Console.WriteLine ("четное число");
}
else
{
    Console.Write("нечетное число");
}
