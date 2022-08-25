// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray (int [] arr)
{
    int i = 0;
        //int Length = arr.Length;
        while(i<arr.Length)
    {
        arr[i] = new Random().Next(-99,100);
        Console.Write(arr[i]+" ");
        i++;
    }
}
int []array = new int[4];
FillArray(array);
Console.WriteLine();
int i = 0;
int result = 0;
for(i=0; i<array.Length; i++)
{
if(i%2>0)
{
    result = result + array[i];
}
}
Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях =  "+result);
