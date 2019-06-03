using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    [Table("Articles")]
    public class Article : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        private bool _EstVendable;
        private string _Nom;
        private int _PrixU;
        private string _Description;

        public event PropertyChangedEventHandler PropertyChanged;

        public Article(string Nom, int PrixU, string Description, bool Estvendable)
        {
            _EstVendable = Estvendable;
            _Nom = Nom;
            _PrixU = PrixU;
            _Description = Description;
        }

        public Article()
        { }

        [Column("Description")]
        public string Description
        {
            get { return _Description; }
            set {
                if (this._Description != value)
                {
                    this._Description = value;
                    this.NotifyPropertyChanged("Description");
                }
            }
        }

        [Column("PrixU")]
        public int PrixU
        {
            get { return _PrixU; }
            set
            {
                if (this._PrixU != value)
                {
                    this._PrixU = value;
                    this.NotifyPropertyChanged("PrixU");
                }
            }
        }

        [Column("Nom")]
        public string Nom
        {
            get { return _Nom; }
            set {
                if (this._Nom != value)
                {
                    this._Nom = value;
                    this.NotifyPropertyChanged("Nom");
                }
            }
        }

        [Column("EstVendable")]
        public bool EstVendable
        {
            get { return _EstVendable; }
            set { _EstVendable = value; }
        }

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
