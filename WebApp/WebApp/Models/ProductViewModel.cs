using Microsoft.AspNetCore.Cors;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebApp.Custom;

namespace WebApp.Models
{
    public class ProductViewModel
    {
        [Required]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage ="Product Name is mandatory.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Product code is invalid.")]
        public string? ProductName { get; set; }
        
        
        [DisplayName("Product Code")]
        [Required(ErrorMessage = "Product Code is mandatory")]
        [CodeValidator(Character = "P", ErrorMessage = "Product code start with P")]
        public string? ProductCode { get; set; }
        
        [Required]
        [DisplayName("Product Price")]
        [Range(1,double.MaxValue)]
        public decimal Price { get; set; }
    }
}
