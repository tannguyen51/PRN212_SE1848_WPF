using System.Data.Common;
using System.Text;
using OOP2;
Console.OutputEncoding = System.Text.Encoding.UTF8;

FulltimeEmployee obama = new FulltimeEmployee();
obama.Id = 1;
obama.Name = "Barack Obama";
obama.IdCard = "124";
obama.BirthDay = new DateTime(1960, 12, 25);
Console.WriteLine("Thông tin của Obama");
Console.WriteLine("ID = "+obama.Id);
Console.WriteLine("ID Card = " +obama.IdCard);
Console.WriteLine("Name = " +obama.Name);
Console.WriteLine("Birthday = "+obama.BirthDay.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của Obama => " + obama.calSalary());
Console.WriteLine("------------------------------------");

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    IdCard = "125",
    Name = "Donald Trump",
    BirthDay = new DateTime(1946, 6, 14),
    WorkingHours = 2
};
Console.WriteLine("Thông tin của Trump");
Console.WriteLine("ID = " + trump.Id);
Console.WriteLine("ID Card = " + trump.IdCard);
Console.WriteLine("Name = " + trump.Name);
Console.WriteLine("Birthday = " + trump.BirthDay.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của Trump => " + trump.calSalary());
Console.WriteLine("-----------------------");

Console.WriteLine("----- Thông tin cách 2 của nhân sự---------");
Console.WriteLine(obama);
Console.WriteLine(trump);
