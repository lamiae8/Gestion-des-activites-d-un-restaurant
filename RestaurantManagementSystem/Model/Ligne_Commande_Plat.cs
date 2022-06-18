using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Model
{

    [Table("ligne_commande_plat")]
    class Ligne_Commande_Plat
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("quantite")]
        public int quantite { get; set; }

        public int plat_id { get; set; }

        public int commande_id { get; set; }




    }
}
