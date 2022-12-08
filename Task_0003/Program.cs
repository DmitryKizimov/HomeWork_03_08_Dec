//функция для вывода массива в квадратных скобках для красоты восприятия
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 1;
    Console.Write("[");

    while (position < count)
    {
        Console.Write(array[position] + "  ");
        position++;
    }
    Console.Write("]");
    return;
}

//Запросим у пользователя число N
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

//Создаем новый массив n 
int[] n = new int[N + 1];

//заполням массив кубами чисел от 1 до введенного нами N
for (int i = 1; i <= N; i = i + 1)
{
    n[i] = i * i * i;
}

//обращаемся к функции вывода на экран
PrintArray(n);