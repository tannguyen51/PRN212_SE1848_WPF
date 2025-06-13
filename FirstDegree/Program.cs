void first_degree_solution(double a, double b)
{
    if(a==0 && b == 0)
    {
        //0x+0=0
        Console.WriteLine("Vô số nghiệm");

    }
    else if(a==0 && b != 0){
        //ox+b = 0 && b !=0
        Console.WriteLine("Vô nghiệm");

    }
    else
    {
        Console.WriteLine("X={0}", -b / a);
        
    }
}
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Phương trình bậc 1 : ax +b = 0");
Console.WriteLine("Nhập a");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x+{1}=0",a,b);
first_degree_solution(a, b);
Console.ReadLine();