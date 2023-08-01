// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int Function(){

Console.WriteLine("введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int result=1;
for (int i = 1; i<=b; i++){
    result=result*a;
}

return result;
}
Console.WriteLine(Function());