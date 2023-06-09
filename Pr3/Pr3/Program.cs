Console.WriteLine("Введите количество целых положительных числе:");
int n = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Сумма первых {n} целых положительных чисел равна {sum}")