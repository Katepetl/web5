// See https://aka.ms/new-console-template for more information
 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[]numbers=new double[10];
Random rnd=new Random();
double min=numbers[0], minIndex=0;
double max=numbers[0], maxIndex=0;
void minmax(){
for (int i=0;  i<numbers.Length; i++)
{
numbers[i]=5-rnd.Next(11)+rnd.NextDouble();
Console.WriteLine(numbers[i]);
}
for (int i=0;  i<numbers.Length; i++)
{
    if(min>numbers[i])
    {
        min=numbers[i];
    minIndex = i;
}

if(max <numbers[i])
{
    max=numbers[i];
    maxIndex=i;
}
}
}
minmax();
double dif=0;
dif=max-min;
Console.WriteLine("Макс={0}", max);
Console.WriteLine("Мин={0}", min);
Console.WriteLine("Разница макс и мин значения={0}", dif);