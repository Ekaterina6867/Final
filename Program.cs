// аписать программу, которая из имеющегося массива строк, формирует массив строк,
// длинна которого меньше или равна 3 символа. Первоначальный массив можно ввести с калвиатуры,
// либо задать на старте выполнения алгоритма.
string[] firstArray = new string[6] {"mon", "monday", "wen", "wensday", "sun", "sunday"};
string[] secondArray = new string[firstArray.Length];
void TwoArray (string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
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
TwoArray(firstArray, secondArray);
PrintArray(secondArray);
