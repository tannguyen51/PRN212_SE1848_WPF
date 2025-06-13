using System.ComponentModel.DataAnnotations;
using System.Text;
using OOP1;

Console.OutputEncoding = System.Text.Encoding.UTF8;
// tạo đối tượng
Category category1 = new Category();
category1.Id = 1;
category1.Name = "Nước mắm";
// xuất thông tin bằng cách gọi hàm
category1.PrintInFor();

// giả sử đổi giá trị trong ô nhớ
category1.Name= "Nước mắm Phú Quốc";
Console.WriteLine(" Sau khi đổi gt");
category1.PrintInFor();
// xử dụng lớp Employyee
Console.WriteLine("------------EMPLOYEE---------------");
Employee e1 = new Employee();
e1.Id = 1;
e1.Id_card = "789";
e1.Name = "Nguyễn Văn A";
e1.Email = " Tan@gmail.com";
e1.Phone = "0123456789";
e1.PrintInfo();
Employee e2 = new Employee()
{
    Id = 2,
    Id_card = "123",
    Name = "Nguyễn Văn B",
    Email = " Huy@gmail.com",
    Phone = "0123456789"

};
Console.WriteLine("------------------EMPLOYEE 2-----------------");
e2.PrintInfo();
Employee e3 = new Employee();
Console.WriteLine("-------------------EMPLOYEE 3----------------");
e3.PrintInfo();

Employee e4 = new Employee(4, "004","Tun","tun@gmail","12345"); ;
e4.PrintInfo();
Console.WriteLine("-------------------EMPLOYEE 4----------------");
Console.WriteLine(e4);// tự động gọi hàm ToString

Console.WriteLine("-------------CUSTOMER--------------");
Customer c1 = new Customer()
{
    Id = "Cus1",
    Name = "Tan",
    Email ="Tan@gmail",
    Phone = "123231232",
    Address = " HCM"
};
c1.PrinInfor();
c1.Address = "HN";
Console.WriteLine("C1 sau khi sua address");
c1.PrinInfor();

    
