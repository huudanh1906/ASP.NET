namespace BuiHuuDanh_2122110119.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        // Khóa ngoại cho Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Khóa ngoại cho Brand
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
