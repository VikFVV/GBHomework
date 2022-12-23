using static System.Console;
Clear();

WriteLine("Введите число");
int a = int.Parse(ReadLine());
if (a % 2 == 0)
{
                  Write("Четное");
}
else Write("Нечетное");