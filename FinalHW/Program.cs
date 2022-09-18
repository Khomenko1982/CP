//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


int f = 0;
Console.WriteLine("Введите количество элементов массива, которые будете вводить далее :");
     
  int z = int.Parse(Console.ReadLine());           
            string[] array = new string[z];
 Index(array,z,f);

    static string[] Index(string[] array,int z,int f)
        {
             f = 0;
            do
            {
                if (f < z)
                {
                  Console.Write($"Введите  {z+1-z+f}-е значение массива " );
                
                     array[f] = Console.ReadLine();
                   f++;
                }
            } while (f < z);
            return array; 
        }
        Console.WriteLine("Исходный массив :");
        Console.WriteLine(String.Join(", ",array));

           string[] array2 = new string[array.Length];
        LessThree(array, array2); // Вызов метода
// метод поиска значений массива длиной меньше либо равно 3
void LessThree(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Значения меньше либо равные длине 3 : ");
PrintArray(array2);