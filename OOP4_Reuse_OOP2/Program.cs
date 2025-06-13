using System.Text;
using OOP2;
using OOP4_Reuse_OOP2;
Console.OutputEncoding = System.Text.Encoding.UTF8;

FulltimeEmployee fe = new FulltimeEmployee();
fe.Id = 1;
fe.Name = "Putin";
fe.BirthDay = new DateTime(1980, 1, 1);
Console.WriteLine(fe);
Console.WriteLine($"Tuổi: {fe.Tuoi()}");

bool isBirthdayThisMonth = fe.BirthDay.Month == DateTime.Now.Month;
Console.WriteLine(isBirthdayThisMonth);
