/* Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] RandomArray()
{
    double[] array = new double[5];
    Random rnd = new Random();
    for (int i = 0; i < 5; i++)
    {
        array[i] = rnd.Next(-10, 100);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");        
    }
}

(double, double) GetMinMax (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}

double GetDifference (double max, double min)
{
    double result = max - min;
    return result;
}


double[] arr = RandomArray();
PrintArray(arr);
(double max, double min) = GetMinMax(arr);
double result = GetDifference(max, min);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {result}");