using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    [Table("UTILISATEUR")]
    class Utilisateur
    {
        public enum DROIT
        {
            ADMIN,
            USER,
            GUEST
        }

        public Utilisateur()
        {
        }

        public Utilisateur(string pseudo, string password, DROIT right = DROIT.GUEST)
        {
            Pseudo = pseudo;
            Password = password;
            Droit = right;
            if (Pseudo == "ADMIN" && Password == "ADMIN")
            {
                Droit = DROIT.ADMIN;
            }
        }

        [Key]
        public int Id { get; set; }

        [Column("Pseudo")]
        public string Pseudo { get; set; }
        [Column("Password")]
        public string Password { get; set; }

        [Column("Right")]
        public DROIT Droit { get; set; }
    }
}
