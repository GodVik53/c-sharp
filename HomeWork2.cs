// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int num = Int32.Parse(Console.ReadLine());
if(num == 1 ){
    Console.WriteLine("НЕТ");
}
else if(num == 2){
    Console.WriteLine("НЕТ");
}
else if(num == 3){
    Console.WriteLine("НЕТ");
}
else if(num == 4){
    Console.WriteLine("НЕТ");
}
else if(num == 5){
    Console.WriteLine("НЕТ");
}
else if(num == 6){	
    Console.WriteLine("ДА");
}
else if(num == 7){
    Console.WriteLine("ДА");
}
else {
    Console.WriteLine("Нет такого дня");
}




// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 //645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введи число: ");
 int Number = Convert.ToInt32(Console.ReadLine());
 string NumberText = Convert.ToString(Number);
 if (NumberText.Length > 2){
   Console.WriteLine("третья цифра - " + NumberText[2]);
 }
 else {
   Console.WriteLine("третьей цифры нет");
 }


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ") ;
int number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(number) ;
 if (NumberText.Length == 3) {
   Console.WriteLine("вторая цифра - " + NumberText[1]);
 }
else {
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число");
}

