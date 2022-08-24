// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int x = new Random().Next(1, 8);

void new_prog(int num){
     Console.WriteLine($"{num}");
     if (num == 6 | num == 7) Console.WriteLine("да");
     else Console.WriteLine($"нет");
}

new_prog(x);