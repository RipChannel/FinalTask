Console.WriteLine("Введите колличество данных");
int arraySize = Convert.ToInt32(Console.ReadLine());

string[] firstArr = new string[arraySize];

for(int i = 0; i < arraySize; i++)
{
    string input = Console.ReadLine();
    if(!String.IsNullOrEmpty(input))
    firstArr[i] = input;
    else
    {
         Console.WriteLine("Неккоректные данные");
         break;
    }
}