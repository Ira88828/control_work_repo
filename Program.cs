// using System;

// class Program
// {
// static void Main()
// {
// Console.WriteLine("Введите элементы массива через запятую:");
// string input = Console.ReadLine();
// string[] words = input.Split(',');

//     int count = 0;
//     for (int i = 0; i < words.Length; i++)
//     {
//         if (words[i].Length <= 3)
//         {
//             count++;
//         }
//     }
    
//     string[] result = new string[count];
//     int index = 0;
//     for (int i = 0; i < words.Length; i++)
//     {
//         if (words[i].Length <= 3)
//         {
//             result[index] = words[i];
//             index++;
//         }
//     }
    
//     Console.WriteLine("Новый массив из строк длиной не более 3 символов:");
//     Console.WriteLine(string.Join(", ", result));
// }
// }


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] words = input.Split(',');

        int count = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= 3)
            {
                result[index] = words[i];
                index++;
            }
        }

        Console.WriteLine("Новый массив из строк длиной не более 3 символов:");
        Console.WriteLine(string.Join(", ", result));
    }
}






