// Найти максмальное из 3х чисел

Console.WriteLine("Введите три числа: ") ;
int[] arrValues = Array.ConvertAll(Console.ReadLine().Split (' ',',',';'), elem => {return System.Convert.ToInt32 (elem);}) ;
int max = int.MinValue;
foreach(int a in arrValues)
{
    if (a > max)
    {
        max = a ;
    }
}
Console.WriteLine("Максимальное число: ") ;
Console.WriteLine(max) ;
