int f = 0;
Console.WriteLine("Введите количество элементов массива, которые будете вводить далее :");
//  int z = Console.ReadLine();      
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
                    // array[f] = int.Parse(Console.ReadLine());
                     array[f] = Console.ReadLine();
                   f++;
                }
            } while (f < z);
            return array; 
        }
        Console.WriteLine("Значения по порядку которые ввел пользователь :");
        Console.WriteLine(String.Join(", ",array));