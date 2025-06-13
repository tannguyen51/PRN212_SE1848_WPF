using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{Name}";

        }
        public  Category()
        {
            Products = new Dictionary<int, Product> ();
        }

      

        /* khi quản lý moi đối tượng ta đều phải đáp ứng
* đầy đủ tính năng CRUD
*/
        public void AddProduct(Product p)
        {
            //kiểm tra nếu Id của Product chưa tồn tại
            //thì thêm mới
            if (p == null)
            {
                return;// dữ liêu đầu vào null
            }
            if (Products.ContainsKey(p.Id))
            {

                return;
            }
            //thêm mới Product vào DIctionary
            Products.Add(p.Id, p);
        }
        public void PrintAllProducts()
        {


            foreach (KeyValuePair<int, Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
            
        }
        //lọc các sản phẩm có giá từ min tới max
        public Dictionary<int,Product> FilterProductsByPrice(double min, double max)
        {
            return Products
                .Where(item =>  item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int,Product> ();
        }
        //Sắp xếp sản phẩm theo đơn giá tăng dần
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item=> item.Value.Price).ToDictionary<int,Product> ();
        }
        //hãy sắp xếp sản phẩm đơn giá tăng dần , nếu đơn trùng nhau hãy sắp xếp số lượng giảm dần
        public Dictionary<int, Product> SortComplex() {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }
        public bool UpdateProduct(Product p)
        {
            if (p == null)
                return false;//nhập null
            if(Products.ContainsKey(p.Id)==false)
            {
                return false; // không tìm thấy sản phẩm
            }    
            //cập nhật giá trị tại ô nhớ chưa p.Id
            Products[p.Id] = p;
            return true; // cập nhật thành công
        }
        public bool RemoveProduct(int id)
        {
            
                if (Products.ContainsKey(id) == false)
                
                    return false; // không tìm thấy sản phẩm
                    Products.Remove(id);
                    return true;
                
            
        }
       
            
        
        // viết hàm xóa các sản phẩm có số lượng từ a->b
    }
}
