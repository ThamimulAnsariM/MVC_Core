using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    [Table("tblCategory")]
    public class Category
    {
        
        public int CategoryId { get; set; }

        [Column(TypeName ="varchar(200)")]
        public string CategoryName { get; set; }

    }
}
