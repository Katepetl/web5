// See https://aka.ms/new-console-template for more information
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//например [345, 897, 568, 234] -> 2

 int[] a=new int[10];
 int count =0;
 Random rand = new Random();
 void number()
 {
 for (int i=0; i <a.Length; i++)
 {
 a[i] = rand.Next(100, 900);
 Console.WriteLine( " " + a[i]);
 }
 for (int i = 0; i < a.Length; i++)
 {               
  if ((a[i] % 2) == 0)
   count++;
            }
 }
 number();
            Console.Write(count);