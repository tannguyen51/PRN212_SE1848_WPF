/*
* Đề bài:
* Nhập vào 1 số >= 0; nếu nhấp sai bắt nhập lại
* nếu nhập đúng ==> tính gia thừa
* 
  */
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int n = -1;
while (n < 0)
{
    Console.WriteLine("Nhập N >= 0");
    String s = Console.ReadLine();
    if (int.TryParse(s, out n) == false){
        Console.WriteLine("bạn phải nhập số");
    }
    else
    {
        if (n < 0)
        {
            Console.WriteLine("Bạn phải  nhập n lớn hơn 0");
        }
    }
}
int gt = 1;
for (int i = 1; i <= n; i++)
    gt *= i;
Console.WriteLine($"{n}!={gt}");