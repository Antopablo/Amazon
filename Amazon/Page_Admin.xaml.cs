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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int price = Int32.Parse(Champ_Prix.Text);
            mw.DB.Liste_Article.Add(new Article(Champ_nom.Text, price, Champ_Description.Text));
        }
    }
}
