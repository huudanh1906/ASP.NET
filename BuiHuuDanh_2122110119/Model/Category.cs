namespace BuiHuuDanh_2122110119.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Mối quan hệ 1-N: Một Category có nhiều Products
        public List<Product> Products { get; set; }
    }
}
