int a = 22;
int b = 3;
int c = 9;
int max = a;

if (b > a) max = b;
if (c > b) max = c;
if (a > c) max = a;

Console.Write("max=");
Console.WriteLine(max);

// Все 3 варианта в коммитах: 5202bed (2,3,7); ebd3309 (44,5,78); 15dbea5 (22,3,9).