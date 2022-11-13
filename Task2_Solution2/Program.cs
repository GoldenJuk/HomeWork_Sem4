//Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
//Для решения задания использование цикла for является обязательным условием

Console.Clear();
int GetSumNumbers(int n)
{
    n = Math.Abs(n);    
    string nStr = Convert.ToString(n);
    int length = nStr.Length;
    int res = 0;
    for (int i = 0; i < length; i++)
    {
        res += Convert.ToInt32(nStr[i].ToString());
    }
    return res;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = GetSumNumbers(number);
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе: {number} = {sum}");
Console.WriteLine();