// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int x = new Random().Next(1, 999999);

void new_prog(int num){
     Console.WriteLine($"{num}");
     string strnum = num.ToString();
     if (num/100 == 0) Console.WriteLine($"третьей цифры нет");
     else { Console.WriteLine($"третья цифра в числе {num} - [{strnum[2]}]");
            Console.WriteLine($"                       {'↑'.ToString()}");
     }
}

new_prog(x);