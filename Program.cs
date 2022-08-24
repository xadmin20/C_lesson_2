// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int x = new Random().Next(100, 1000);
void new_prog(int num){
     Console.WriteLine($"{num}");
     string strnum = num.ToString();
     Console.WriteLine($" {strnum[1]}");

}

new_prog(x);