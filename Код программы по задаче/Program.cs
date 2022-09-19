Console.WriteLine("Введите колличество данных");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] firstArray = FirstArray(arraySize);
PrintArr(firstArray);
string[] secondArray = SecondArray(firstArray);
Console.WriteLine();
Console.WriteLine("Второй массив");
PrintArr(secondArray);

string[] FirstArray(int arrSize)
{
Console.WriteLine("Введите данные");
string[] firstArr = new string[arraySize];
for(int i = 0; i < arraySize; i++)
{
    string input = Console.ReadLine();
    if(!String.IsNullOrEmpty(input))
    firstArr[i] = input;
    else
    {
         Console.WriteLine("Нельзя вводить пустые строки, введите значение заново");
         i--;
    }
}
Console.WriteLine("Первоначальный массив");
return firstArr;
}

void PrintArr(string[] Arr)
{
    Console.Write("[");
    for(int i = 0; i < Arr.GetLength(0); i++)
    {
        if(i < Arr.GetLength(0) - 1) Console.Write($"{Arr[i]}, ");
        else Console.Write($"{Arr[i]}]");
    }
}

string[] SecondArray(string[] Arr)
{
    int sum = 0;
    for(int i = 0; i < Arr.GetLength(0); i++)
    {
        if(Arr[i].Length <= 3)
        {
            sum = sum + 1;
        }
    }
    string[] secondArr = new string[sum];
    int j = 0;
    for(int i = 0; i < Arr.GetLength(0); i++)
    {
        if(Arr[i].Length <= 3)
        {
            secondArr[j] = Arr[i];
            j++;
        }
    }
    return secondArr;
}
