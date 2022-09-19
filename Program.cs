Console.WriteLine("Введите колличество данных");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] firstArray = FirstArray(arraySize);
PrintArr(firstArray);

string[] FirstArray(int arrSize)
{
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