using System.ComponentModel.DataAnnotations.Schema;

namespace ApiClient.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; } // URL изображения продукта

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Дата и время создания записи
    }
}
