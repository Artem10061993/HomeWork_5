// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray (int [] arr)
{
    int i = 0;
        //int Length = arr.Length;
        while(i<arr.Length)
    {
        arr[i] = new Random().Next(100,1000);
        Console.Write(arr[i]+" ");
        i++;
    }
}
int []array = new int[4];
FillArray(array);
Console.WriteLine();
int i = 0;
int count = 0;
for(i=0; i<array.Length; i++)
{
if(array[i]%2==0)
{
    count++;
}
}
Console.WriteLine("Число четных чисел в массиве = "+count);