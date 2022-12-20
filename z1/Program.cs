/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите количество чисел: ");
int number = int.Parse(Console.ReadLine()!);

int[] array = new int[number];
int[] arrayNum = NumberOfNumbers(array);
PrintArray(arrayNum);
AboveZero(arrayNum);

int[] NumberOfNumbers(int[] arr)
{   
    int[] arrayNew = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write((i+1) + "-ое: ");
        arrayNew[i] = int.Parse(Console.ReadLine()!);
    }
    return arrayNew;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int AboveZero(int[] arrN)
{
    int count = 0;
    for (int i = 0; i < arrN.Length; i++)
    {
        if (arrN[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Колличество элементов > 0 = " + count);
    return count;
}