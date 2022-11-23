Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;


while (count <= N)
{
   int result = count % 2; 
   if(result == 0)
        {
         Console.WriteLine (count);
        }
    count ++;
}
