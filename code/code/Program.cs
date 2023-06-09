Console.WriteLine("Введите количество первых целых положительных чисел: ");
int count = int.Parse(Console.ReadLine());
int sum = 0;
int i = 1;
while (count >= i)
{
    sum += i;
    i++;
}    
Console.WriteLine("Сумма первых {0} целых положительных чисел = {1}", count, sum);
Console.ReadKey();