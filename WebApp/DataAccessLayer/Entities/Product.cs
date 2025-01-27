using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
  
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; } //int

        [Column(TypeName = "varchar(200)")]
        public string ProductCode { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; } //nvarchar(max)

        public decimal Price { get; set; } //decimal(18,2)

        [ForeignKey("Category")]
        public int CategoryId { get; set; } //int

        //Navigate to Category
        public Category Category { get; set; }

    }
}
