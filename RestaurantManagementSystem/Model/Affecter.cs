using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Model
{
    [Table("affecter")]
    class Affecter
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("date_affectation")]
        public DateTime date_affectation { get; set; }

        [Required]
        public int table_id { get; set; }

        [Required]
        public int serveur_id { get; set; }

    }
}
