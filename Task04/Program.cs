using static System.Console;
Clear();

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine());
Write("Введите число b: ");
int b = int.Parse(ReadLine());
Write("Введите число c: ");
int c = int.Parse(ReadLine());
   
if (a > c && a > c)
{
    Write(a);
}
    else if  (b > a && b > c)
    {
    Write(b);
    }
      else if (c > a && c > b)
      {
      Write(c);
      }