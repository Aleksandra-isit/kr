Console.Clear();

void Input(string[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void Output(string[] array, int n)
{
    Console.WriteLine("Итоговый массив: ");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int kolichestvo(string[] array1, int n)
{
    int k = 0, i;
    for (i = 0; i < n; i++)
    {
        if (array1[i].Length < 4)
        {
            k++;
        }
    }
    return k;
}

string[] process(string[] array1, int n, int k)
{
    int i, j = 0;
    string[] array2 = new string[k];
    for (i = 0; i < n; i++)
    {
        if (array1[i].Length < 4)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;    
}

Console.Write("Сколько строк вы хотит ввести: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите {n} строк:");
string[] array1 = new string[n];
Input(array1, n);
int k = kolichestvo(array1, n);
string[] array2 = process(array1, n, k);
Output(array2, k);
