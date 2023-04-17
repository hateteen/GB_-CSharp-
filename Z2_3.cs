int number = 0;

Console.WriteLine("Введите номер дня недели");
number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.WriteLine("пн - не выходной");
}
if(number == 2)
{
    Console.WriteLine("вт - не выходной");
}
if(number == 3)
{
    Console.WriteLine("ср - не выходной");
}
if(number == 4)
{
    Console.WriteLine("чт - не выходной");
}
if(number == 5)
{
    Console.WriteLine("пт - не выходной");
}
if(number == 6)
{
    Console.WriteLine("сб - выходной");
}
if(number == 7)
{
    Console.WriteLine("вс - выходной");
}