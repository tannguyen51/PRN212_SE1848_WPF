/*
 * SỬ dụng Generic List để quản lí nhân sự với đầy đủ các chức năng
 * tính năng CRUD
 * C: Create --> tạo mới dữ liệu
 * R: Read --> xem, lọc , tìm kiếm , sắp xếp , thông kê...
 * U: Update --> cập nhật, sửa dữ liệu
 * D: Delete ---> Xóa dữ liệu
 */
//Câu 1 : Tạo 5 nv trong đó có 3 nhân viên chính thức và 2 thời vụ
// lưu vào Generic List
using System.Text;
using OOP2;


List < Employee >  employees = new List<Employee>();

FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123456789",
    Name = "Nguyen Van A",
    BirthDay = new DateTime(1990, 1, 1)
};
employees.Add(fe1);

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    IdCard = "987654321",
    Name = "Nguyen Van B",
    BirthDay = new DateTime(1991, 3, 2)
};
employees.Add(fe2);
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    IdCard = "456789123",
    Name = "Nguyen Van C",
    BirthDay = new DateTime(1980, 7, 1)
};
employees.Add(fe3);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 4,
    IdCard = "654321987",
    Name = "Nguyen Van D",
    BirthDay = new DateTime(1995, 5, 5),
    WorkingHours = 15 // Example working hours for part-time employee
};
employees.Add(pe1);
ParttimeEmployee pe2 = new ParttimeEmployee()
{
    Id = 5,
    IdCard = "321987654",
    Name = "Nguyen Van E",
    BirthDay = new DateTime(1997, 8, 5),
    WorkingHours = 20 // Example working hours for part-time employee
};
employees.Add(pe2);



Console.OutputEncoding = System.Text.Encoding.UTF8;
// Câu 2: Hiển thị danh sách nhân viên
Console.WriteLine("câu 2 : B ---> Xuất toàn bộ nhân viên");
// cách 1
employees.ForEach(e => Console.WriteLine(e));

// Câu 3 : Lọc ra các nhân sự chính thức
//cách 1:
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine(" Câu 3 : R --> lọc ra các nhân sự chính thức");
foreach(FulltimeEmployee fe in fe_list)
    Console.WriteLine(fe);

// Câu 4 : Tổng lương nhân viên chính thức:
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Câu 4 tổng lương nhân viên chính thức");
Console.WriteLine(fe_sum_salary);
// Câu 5 : Tổng lương nhân viên thời vụ
double Parttime_sum_salary = employees.OfType<ParttimeEmployee>().Sum(e => e.calSalary());
Console.WriteLine("Câu 5 : Tổng lương nhân viên thời vụ");
Console.WriteLine(Parttime_sum_salary);