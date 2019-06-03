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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Amazon
{
  
    public partial class Page_Shop : Page
    {
        public MainWindow mw { get; set; }
        List<Article> ListeTEMP { get; set; }
        public Page_Shop()
        {
            InitializeComponent();
            ListeTEMP = new List<Article>();
        }

        private void Bouton_Login_Click(object sender, RoutedEventArgs e)
        {
            Page_Connexion PC = new Page_Connexion(mw);
            PC.Show();
        }

        private void Bouton_Sinscrire_Click(object sender, RoutedEventArgs e)
        {
            Page_Inscription PI = new Page_Inscription(mw);
            PI.Show();
        }

        private void Ajoute_panier_Click (object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Data_Grid_Article.SelectedCells[0].Item.GetType().ToString());
            if (mw.Connected_user != null)
            {
                mw.Connected_user.Panier = ListeTEMP;
                mw.Connected_user.Panier.Add((Article)Data_Grid_Article.SelectedCells[0].Item);
                MessageBox.Show("ok");
            } else
            {
                MessageBox.Show("Vous devez vous connecter", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Bouton_Logout_Click(object sender, RoutedEventArgs e)
        {
            mw.Connected_user.Droit = DROIT.GUEST;
            mw.StatusBar.Text = mw.Connected_user.Droit.ToString();
            mw.Connected_user = null;
            Bouton_Login.Visibility = Visibility.Visible;
            Bouton_Sinscrire.Visibility = Visibility.Visible;
            Bouton_Logout.Visibility = Visibility.Collapsed;
        }

        private void Bouton_Panier_Click(object sender, RoutedEventArgs e)
        {
            double tot = 0;

            foreach (Article item in mw.Connected_user.Panier)
            {
                tot += item.PrixU;
            }

            mw.StatusBar.Text = tot.ToString();
        }
    }
}
