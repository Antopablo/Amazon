using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Amazon
{
    /// <summary>
    /// Logique d'interaction pour Page_Connexion.xaml
    /// </summary>
    public partial class Page_Connexion : Window
    {
        public MainWindow  mw { get; set; }
        public Page_Connexion(MainWindow m)
        {
            InitializeComponent();
            mw = m;
        }

        private void CO_boutonSeConnecter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = from u in mw.DB.Liste_Utilisateur
                            where u.Pseudo == CO_Pseudo.Text && u.Password == CO_Password.Password
                            select u;

                Utilisateur usr = query.FirstOrDefault();

                if (usr.Droit != DROIT.ADMIN)
                {
                    usr.Droit = DROIT.USER;
                }
              ((MainWindow)System.Windows.Application.Current.MainWindow).StatusBar.Text = usr.Pseudo + " - " + usr.Droit.ToString();
                mw.Connected_user = usr;
                mw.name_monCompte.Visibility = Visibility.Visible;
                if (usr.Droit == DROIT.ADMIN)
                {
                    mw.name_Admin.Visibility = Visibility.Visible;
                }
               
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("MDP ou User invalides");
            }
        }
    }
}
