Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a,b,c,d;
bool ok;

do
{
    Console.WriteLine("Введіть число a = ");
    ok = double.TryParse(Console.ReadLine(), out a);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

do
{
    Console.WriteLine("Введіть число b = ");
    ok = double.TryParse(Console.ReadLine(), out b);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

do
{
    Console.WriteLine("Введіть число c = ");
    ok = double.TryParse(Console.ReadLine(), out c);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

do
{
    Console.WriteLine("Введіть число d = ");
    ok = double.TryParse(Console.ReadLine(), out d);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

double x, y, z, r;

x = ((a + 2*b-c+d)/c*d) + ((a+b)/(c-d)) - ((Math.Pow(a,2))/(Math.Pow(b,2)));

y = ((5*(a+b)*(c-d))/(0.5*c)) + Math.Pow(d,2)*((Math.Pow(a,2)-Math.Pow(b,2))/(b-a));

z = (((Math.Pow(Math.Pow(x,2)-2*x,3))-4*(Math.Pow(x,4)+1))*(1-b)) / (5*a+3*d);

r = (((0.5 * a + (3 / 4) * b - (7 / 5)) / (3 * c + 1)) + (1 / (a - c)));

Console.WriteLine($"\nX = {x:F2}");
Console.WriteLine($"\nY = {y:F2}");
Console.WriteLine($"\nZ = {z:F2}");
Console.WriteLine($"\nR = {r:F2}");
