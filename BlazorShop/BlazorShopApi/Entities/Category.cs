namespace BlazorShopApi.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? IconCSS { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
