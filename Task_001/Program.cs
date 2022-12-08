//Запросим число
Console.Write("Введите пятизначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

//проверка - пятизначное или нет
int digit5 = digit / 1000;
if (digit5 >= 10 && digit5 <= 100)
{
    int halfdigit = digit / 1000;

    //вводим две переменных firstdigit и seconddigit - первое и второе число
    int firstdigit = digit / 10000;
    int seconddigit = halfdigit % 10;

    //вводим две переменных lastdigit и prelastdigit - последнее и предпоследнее число
    int lastdigit = digit % 10;

    int tempprelastdigit = digit % 100;
    int prelastdigit = tempprelastdigit / 10;

    //проверяем на условия полиндрома: firstdigit = lastdigit и seconddigit = prelastdigit
    if (firstdigit == lastdigit && seconddigit == prelastdigit)
    {
         Console.WriteLine("Число, которое вы ввели, является полиндромом");
    }
    else
    {
        Console.WriteLine("Число, которое вы ввели, НЕ является полиндромом");
    }
}
else
{
Console.WriteLine("Прошу ввести пятизначное число!");
}