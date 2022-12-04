Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double m, n, a, b ,x;
bool ok;

do
{
    Console.WriteLine("Введіть число m = ");
    ok = double.TryParse(Console.ReadLine(), out m);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

do
{
    Console.WriteLine("Введіть число n = ");
    ok = double.TryParse(Console.ReadLine(), out n);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

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
    Console.WriteLine("Введіть число x = ");
    ok = double.TryParse(Console.ReadLine(), out x);
    if (!ok) Console.WriteLine("Число введено неправельно , повторить спробу!\n");
} while (!ok);

double z1, z2, y;

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / (m);

y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2)*(x - b);


Console.WriteLine($"\nz2 = {z1:F2}");
Console.WriteLine($"\nz1 = {z2:F2}");
Console.WriteLine($"\ny = {y:F2}");
