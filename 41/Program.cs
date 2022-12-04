// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через запятую ");
string? input = Console.ReadLine();
int result = 0;

int[] numbers = ParseStringToArray(input);
PrintArray(numbers);

int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
    numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}

int GetCountNumbersInString(string input)
{
    int count;
    if(input[input.Length - 1] == ',')
    count = 0;
    else
    count = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    result++;
}
Console.WriteLine();
Console.WriteLine($"Количетво чесел больше 0 = {result}");
