// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
void FillArray (int [] arr)
{
    int i = 0;
        //int Length = arr.Length;
        while(i<arr.Length)
    {
        arr[i] = new Random().Next(0,100);
        Console.Write(arr[i]+" ");
        i++;
    }
}
int []array = new int[5];
FillArray(array);
Console.WriteLine();
int i = 0;
int x_max = array[0];
int x_min = array[1];
while(i<array.Length)
{
    if(array[i]>x_max)
    {
        x_max=array[i];
    }
    else
    {
    if(array[i]<x_min)
    {
        x_min=array[i];
    }
    }
    i++;
}
Console.WriteLine("Максимальный элемент массива = "+x_max);
Console.WriteLine("Минимальный элемент массива = "+x_min);
int dif = x_max-x_min;
Console.WriteLine("Разница между максимальным и минимальным значением массива = "+dif);