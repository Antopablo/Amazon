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
    /// <summary>
    /// Logique d'interaction pour Page_Admin.xaml
    /// </summary>
    public partial class Page_Admin : Page
    {
        public MainWindow mw { get; set; }

        public Page_Admin()
        {
            InitializeComponent();
        }

        private void Button_Ajout_Click(object sender, RoutedEventArgs e)
        {
            Content_Ajout_Article.Visibility = Visibility.Visible;
            Content_Edit_Article.Visibility = Visibility.Collapsed;
            Content_Supr_Article.Visibility = Visibility.Collapsed;
        }

        
        private void Valider_Ajouter_Click(object sender, RoutedEventArgs e)
            {
                int price = Int32.Parse(Champ_Prix.Text);
                mw.DB.Liste_Article.Add(new Article(Champ_nom.Text, price, Champ_Description.Text, (bool)CheckBox_vendable.IsChecked));
                mw.DB.SaveChanges();
                Champ_Description.Text = "";
                Champ_nom.Text = "";
                Champ_Prix.Text = "";
                MessageBox.Show(Champ_nom.Text + " enregistré", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        private void Bouton_Supr_Click(object sender, RoutedEventArgs e)
        {
            Content_Supr_Article.Visibility = Visibility.Visible;
            Content_Ajout_Article.Visibility = Visibility.Collapsed;
            Content_Edit_Article.Visibility = Visibility.Collapsed;
            Content_Supr_Article.ItemsSource = mw.DB.Liste_Article.Local;
        }

        private void Bouton_Edit_Click(object sender, RoutedEventArgs e)
        {
            Content_Ajout_Article.Visibility = Visibility.Collapsed;
            Content_Edit_Article.Visibility = Visibility.Visible;
            Content_Supr_Article.Visibility = Visibility.Collapsed;
            Content_Edit_Article.ItemsSource = mw.DB.Liste_Article.Local;
        }

        private void Suprimer_ADMIN_Click(object sender, RoutedEventArgs e)
        {
            mw.DB.Liste_Article.Remove((Article)Content_Supr_Article.SelectedCells[0].Item);
            Content_Supr_Article.Items.Refresh();
        }
    }
}
