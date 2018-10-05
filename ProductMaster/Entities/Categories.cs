using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaster.Entities
{
    [Table("Categories")]
    public class Categories
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("CategoryName")]
        [Key]
        public string CategoryName { get; set; }

        [Column("CategoryDescription")]
        public string CategoryDescription { get; set; }
    }
}
