using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Model
{

    [Table("serveur")]
    class Serveur
    {

        [Key]
        [Column("code_serveur")]
        public int code_serveur { get; set; }


        [Column("nom")]
        public string nom { get; set; } 


        [Column("prenom")]
        public string prenom { get; set; }


        public List<Affecter> affectations { get; set; }


    }
}
