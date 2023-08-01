// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Function(){
int [] test = new int[8];
for (int i = 0; i<test.Length; i++){
    test[i] = new Random().Next(0,100);
    Console.Write(test[i] + " ");
}
}
Function();