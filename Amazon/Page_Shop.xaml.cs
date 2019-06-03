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
            if (mw.Connected_user != null)
            {
                mw.Connected_user.Panier = ListeTEMP;
                mw.Connected_user.Panier.Add((Article)Data_Grid_Article.SelectedCells[0].Item);
                Bouton_Panier.Content = "Panier : " + mw.Connected_user.Panier.Count + " Article(s)";
                CalculPanier();

            } else
            {
                MessageBox.Show("Vous devez vous connecter", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                Page_Connexion pc = new Page_Connexion(mw);
                pc.Show();
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
            Data_Grid_Article_PANIER.Items.Refresh();
            Data_Grid_Article_PANIER.ItemsSource = mw.Connected_user.Panier;
            Data_Grid_Article_PANIER.Visibility = Visibility.Visible;
            Bouton_Retour_Shop.Visibility = Visibility.Visible;
        }

        private void Supprimer_panier_Click(object sender, RoutedEventArgs e)
        {
            if (mw.Connected_user != null)
            {
                mw.Connected_user.Panier.Remove((Article)Data_Grid_Article_PANIER.SelectedCells[0].Item);
                Bouton_Panier.Content = "Panier : " + mw.Connected_user.Panier.Count + " Article(s)";
                CalculPanier();
                Data_Grid_Article_PANIER.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Vous devez vous connecter", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                Page_Connexion pc = new Page_Connexion(mw);
                pc.Show();
            }
        }

        private void CalculPanier()
        {
            double tot = 0;
            foreach (Article item in mw.Connected_user.Panier)
            {
                tot += item.PrixU;
            }
            mw.total_BasDePage.Text = "Total du panier " + tot.ToString() + " €";
        }

        private void Bouton_Retour_Shop_Click(object sender, RoutedEventArgs e)
        {
            Data_Grid_Article_PANIER.Visibility = Visibility.Collapsed;
            Bouton_Retour_Shop.Visibility = Visibility.Collapsed;
        }
    }
}
