void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        //0x+0=0
        Console.WriteLine("Vô số nghiệm");

    }
    else if (a == 0 && b != 0)
    {
        //ox+b = 0 && b !=0
        Console.WriteLine("Vô nghiệm");

    }
    else
    {
        Console.WriteLine("X={0}", -b / a);

    }
}
void PtBac2(double a, double b,double c)
{
    if (a == 0)
    {
        first_degree_solution(b, c);

    }
    else
    {
           var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
            Console.WriteLine("Vo nghiem");
        else if (delta == 0)
            Console.WriteLine("Nghiem kep x1=x2={0}", -b / (2 * a));
       
        else { 
        var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        var x2= (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1={0},x2={1}", x1, x2);
        }
    }

}
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Phương trình bậc 2 :");
Console.WriteLine("Nhập a");
var a= double.Parse(Console.ReadLine());
Console.WriteLine("Nhập b");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập c");
var c = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x^2+{1}x+{2}=0", a, b, c);
PtBac2(a, b, c);
Console.ReadLine();
//Console.OutputEncoding = System.Text.Encoding.UTF8;
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Nhập b");
//double b = double.Parse(Console.ReadLine());
//Console.WriteLine("{0}x+{1}=0", a, b);
//first_degree_solution(a, b);
//Console.ReadLine();