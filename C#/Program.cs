Console.Clear();

string[] array = AskArray();        //Массив введённый пользователем
string[] result = SearchValue(array, 3);    //Массив который имеет длинну значений не больше n символов
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");     //Результат

string[] SearchValue(string[] array, int n)      //Формирование массива с длинной значений меньше и равное n символов
{
    string[] output = new string[ValueLessThan(array, n)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            output[j] = array[i];
            j++;
        }
    }
    return output;
}

int ValueLessThan(string[] input, int n)    //Функция для поиска длинны массива для значений, не длиннее n символов.
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] AskArray()      //Ввод данных в массив
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}