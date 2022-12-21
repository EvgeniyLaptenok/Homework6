/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Write("Введите k1: ");
int numberK1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
int numberB1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите k2: ");
int numberK2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
int numberB2 = int.Parse(Console.ReadLine()!);

IntersectionPoint(numberK1, numberB1, numberK2, numberB2);
void IntersectionPoint(int numK1, int numB1, int numK2, int numB2)
{
    double B = numB1 - numB2;
    double K = numK2 - numK1;
    double x = Math.Round(B / K, 2);
    double y = Math.Round((numK2 * x) + numB2, 2);
    Console.WriteLine(x + " ; " + y);
}