using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Model
{
    [Table("_tables")]
    class Table
    {
        [Key]
        [Column("num_table")]
        public int num_table { get; set; }

        [Column("nombre_place")]
        public int nombre_place { get; set; }

        [Column("reserved")]
        public bool reserved { get; set; }
    }

}
