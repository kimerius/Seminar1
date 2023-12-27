Console.Write("Введите число ");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 0)
{
    num1 = num1 * (-1);
}
int counter = - num1;
while (counter<= num1 )
{
    Console.Write($" {counter} ");
    counter++;
}