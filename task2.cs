// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int Function(){
Console.WriteLine("введите число");
int sum = 0;
for (int number = Convert.ToInt32(Console.ReadLine()); number>0; number = number/10){
    sum+=number%10;
}
return sum;
}
Console.WriteLine(Function());