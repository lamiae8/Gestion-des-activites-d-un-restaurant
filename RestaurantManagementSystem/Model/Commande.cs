using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Model
{

    [Table("commande")]
    class Commande
    {

        [Key]
        [Column("id")]
        public int num_commande { get; set; }

        [Column("date_enregistrement")]
        public DateTime date_enregistrement { get; set; }

        [Column("date_paiement")]
        public DateTime date_paiement { get; set; }

        [Column("mode_paiement")]
        public string mode_paiement { get; set; }

        [Column("nombre_personne")]
        public int nombre_personne { get; set; }

        public int table_id { get; set; }

    }
}
