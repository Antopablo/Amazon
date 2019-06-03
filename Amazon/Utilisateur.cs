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

    public enum DROIT
    {
        ADMIN,
        USER,
        GUEST
    }

    [Table("UTILISATEUR")]
    public class Utilisateur : INotifyPropertyChanged
    {
       
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
            Panier = new List<Article>();
        }

        [Key]
        public int Id { get; set; }

        [Column("Pseudo")]
        private string _pseudo;

        public string Pseudo
        {
            get { return _pseudo; }
            set
            {
                if (this._pseudo != value)
                {
                    this._pseudo = value;
                    this.NotifyPropertyChanged("Pseudo");
                }
            }
        }

        [Column("Password")]
        private string _password;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Password
        {
            get { return _password; }
            set
            {
                if (this._password != value)
                {
                    this._password = value;
                    this.NotifyPropertyChanged("Password");
                }
            }
        }


        [Column("Droit")]
        public DROIT Droit { get; set; }

        //[InverseProperty("Commande")]
        //virtual public List<Commande> Liste_Panier { get; set; }


        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private List<Article> _Panier;
        public List<Article> Panier
        {
            get { return _Panier; }
            set { _Panier = value; }
        }

    }
}
