using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    class Article
    {
        [Key]
        public int Id { get; set; }

        private bool _EstVendable;
        private string _Nom;
        private int _PrixU;
        private string _Description;

        [Column("Description")]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [Column("PrixU")]
        public int PrixU
        {
            get { return _PrixU; }
            set { _PrixU = value; }
        }

        [Column("Nom")]
        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        [Column("EstVendable")]
        public bool EstVendable
        {
            get { return _EstVendable; }
            set { _EstVendable = value; }
        }

    }
}
