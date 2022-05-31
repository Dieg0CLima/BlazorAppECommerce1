using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppECommerce.Shared
{
    public class Product
    {

        public int id { get; set; }

        public string? title { get; set; }

        public string? description { get; set; }

        public string? image { get; set; } = "https://via.placeholder.com/300x300";

        public decimal? price { get; set; }

        public decimal? originalPrice { get; set; }

        public bool? isDeleted { get; set; }

        public bool? isPublic { get; set; }

        public Category? category { get; set; }

        public int? CategoryId { get; set; }

        public DateTime dateCreated { get; set; } = DateTime.UtcNow;

        public DateTime dateUpdate { get; set; }
    }
}
