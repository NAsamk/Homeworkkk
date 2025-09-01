

Console.WriteLine("შეამოწმეთ იყოფა თუ არა რიცხვი 5ზე უნაშთოდ");
Console.WriteLine("Enter a Number");
int k = int.Parse(Console.ReadLine());

if (k % 5 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}





Console.WriteLine();
Console.WriteLine("ჯამის, სხვაობის,ნამრავლის და გაყოფის მოქმედებები");
Console.WriteLine("Enter Num1");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Num2");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("x+y = " + (x + y));
Console.WriteLine("x*y = " + (x * y));
if (x >= y)
{
    Console.WriteLine("x-y = " + (x - y));
}
else
{
    Console.WriteLine("y-x = " + (y - x));
}

if (x >= y && y != 0)
{
    Console.WriteLine("x/y = " + (x / y));
}
else if (y >= x && x != 0)
{
    Console.WriteLine("y/x = " + (y / x));

}
else
{
    Console.WriteLine("შეცდომა 0 გაყოფა არ შეიძლება");
}



Console.WriteLine();
Console.WriteLine("გაუცვალეთ ორ ცვლადს შორის მნიშვნელობები");
var z = 0;
z = x;
x = y;
y = z;

Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine();

/*x = x + y;
y = x - y;
x = x - y;*/




Console.WriteLine();
Console.WriteLine("გამრავლების ტაბულა");
Console.WriteLine("enter a num: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 9; i++)
{
    Console.WriteLine($"{n} * {i} = {i * n}");
}

Console.WriteLine();
Console.WriteLine("პროგრამა რომელიც იპოვის ყველა ლუწ რიცხვს 1-დან n-მდე და დაბეჭდავს მათ კვადრატებს");
for (int i = 1; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i * i);
    }
}