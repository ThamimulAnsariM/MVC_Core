using Microsoft.AspNetCore.Cors;
using System.ComponentModel;

namespace WebApp.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        public string? ProductName { get; set; }

        [DisplayName("Product Code")]
        public string? ProductCode { get; set; }

        [DisplayName("Product ID")]
        public decimal Price { get; set; }
    }
}
