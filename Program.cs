// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа

Console.WriteLine("Введите длину массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива");
    array[i] = Console.ReadLine();
}

int newArrayLength = 0;

for (int j = 0; j < arrayLength; j++)
{
    if (array[j].Length <= 3) newArrayLength++;
}

Console.WriteLine($"Длина нового массива {newArrayLength}");
string[] newArray = new string[newArrayLength];

int a = 0; //переменная для счета в новом массиве
for (int k = 0; k < arrayLength; k++)
{
    if (array[k].Length <= 3)
    {
        newArray[a] = array[k];
        a++;
    }
}

for (int i = 0; i < newArrayLength; i++)
{
    Console.Write(newArray[i]);
    if (i < newArrayLength - 1) Console.Write(", ");
}