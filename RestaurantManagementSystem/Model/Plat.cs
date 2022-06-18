using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Model
{

    [Table("plat")]
    class Plat
    {
        [Key]
        [Column("code_plat")]
        public int code_plat { get; set; }


        [Column("libelle")]
        public string libelle { get; set; }


        [Column("type")]
        public string type { get; set; }


        [Column("prix_unitaire")]
        public double prix_unitaire { get; set; }

    }


}
