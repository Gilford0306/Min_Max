//Задание 2
//Дан двумерный массив размерностью 5x5, заполнен-
//ный случайными числами из диапазона от –100 до 100. 
//Определить сумму элементов массива, расположенных 
//между минимальным и максимальным элементами.

Random random = new Random();
int minRandom = -100;
int maxRandom = 100;
int sizeR = 5;
int sizeC = 5;
int[,] arr = new int[sizeR, sizeC];
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        arr[i, j] = random.Next(minRandom, maxRandom);
    }
}

for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}

int min = arr[0, 0];
int min_i = 0;
int min_j = 0;
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        if (min > arr[i, j])
        {
            min = arr[i, j];
            min_i = i;
            min_j = j;
        }
    }
}
Console.WriteLine("Min - " + min + " - Arr["+min_i+"]["+min_j+"]");
int max = arr[0, 0];
int max_i = 0;
int max_j = 0;
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        if (max < arr[i, j])
        {
            max = arr[i, j];
            max_i = i;
            max_j = j;
        }
    }
}
Console.WriteLine("Max - " + max + " - Arr[" + max_i + "][" + max_j + "]");

if (max_i < min_i)
{
    int tempi = max_i;
    int tempj = max_j;
    max_i = min_i;  
    max_j = min_j;
    min_i = tempi;
    min_j = tempj;
}
int sum = 0;
for (int i = 0; i < sizeR; i++)
{
    for (int j = 0; j < sizeC; j++)
    {
        if (max_i == min_i)
        {
            if (j >= min_j && j <= max_j)
            {
                sum += arr[i, j];
            }
        }
        else
        {
            if (i > min_i && i < max_i)
            {
                sum += arr[i, j];
            }
            else if (i == min_i && j >= min_j)
            {
                sum += arr[i, j];
            }
            else if (i == max_i && j <= max_j)
            {
                sum += arr[i, j];
            }
        }

    }
}
Console.WriteLine("Sum between min and max - " + sum);