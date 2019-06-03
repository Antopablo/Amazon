using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Commande
    {
        private List<Article> _Panier_Client;
        public List<Article> Panier_Client
        {
            get { return _Panier_Client; }
            set { _Panier_Client = value; }
        }
    }
}
