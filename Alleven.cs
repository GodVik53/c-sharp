// Найти все положительные четные числа до N


Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
 if (N<=1) {
         Console.WriteLine("Введите число больше 1");
     }
int a = 1 ;
while (a <= N) {
    if (a % 2 == 0) {
    Console.Write(a) ;
    Console.Write(" ") ;
    }
    a = a+1 ;
}

