// See https://aka.ms/new-console-template for more information
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] a=new int[5];
int sum=0;
 Random rand = new Random();
 void summa()
 {
 for (int i=0; i <a.Length; i++)
 {
 a[i] = rand.Next(1, 50);
     Console.WriteLine( " " + a[i]); 
  if (i % 2== 1)
  {

   sum +=a[i];
            }
 }
 }
 summa();
            Console.WriteLine(sum);