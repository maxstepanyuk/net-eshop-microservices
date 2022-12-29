namespace ProductService.Models
{
    public class Product : Base
    {
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; } = null!;
        public bool Avaliadble { get; set; }
        public double Price { get; set; }
        public double StockLeft { get; set; }
        public string? PhotoLink { get; set; } = null!;
    }
}

// todo
// ! = from Nullable to Non-Nullable
// ? = from Non-Nullable to Nullable
//https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-7.0&tabs=visual-studio-code