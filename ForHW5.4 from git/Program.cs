// Задача 38. Задайте массив вещественных чисел. Найдите разницу между макс и минимальным элементами массива.
Console.Clear();
Console.WriteLine("This program finds difference between Max and Min elements of the array.");
Console.Write("Enter array dimension:");
int arrayDim = Convert.ToInt32(Console.ReadLine());//enter dimension of an array
float [] newArray = FillArray(arrayDim);// get filled array
newArray = SortArray(newArray);// get sorted array
Console.Write("Sorted array: ");

for (int i=0; i<newArray.Length;i++)//print sorted array
  {
    Console.Write($"{newArray[i]} ");
  }
Console.WriteLine();
Console.WriteLine($"Difference between Max and Min elements of your array is {newArray[newArray.Length-1] - newArray[0]}.");

//***********************************************//
float [] FillArray(int dim)
{
 float [] arrayWarning ={0};
    if(dim>0)// if dimension>0 then continue with filling
      { 
        float [] array = new float[dim];
        Console.Write("Your original array is: ");
          for(int index=0; index<dim; index++)
             {
              Console.Write($"{array[index]=new Random().Next(-100,101)} ");// fill array with random numbers
             }
        Console.WriteLine();
        return array;
      }
      else
      {
        Console.WriteLine("Warning! The entered dimesion is wrong. Please check and try again!"); 
        return arrayWarning;
      }
 
}
//***********************************************//


//***********************************************//
float [] SortArray (float [] array)
{ float buffer=0;
  for(int index=0; index<array.Length; index++)
     {
      for (int index_2=1; index_2<array.Length; index_2++)
         {
           if (array[index_2]<array[index_2-1])
              {
               buffer=array[index_2-1];
               array[index_2-1]=array[index_2];
               array[index_2]=buffer;
              }
        }
     }
  return array;
}
//***********************************************//