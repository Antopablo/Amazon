using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ApplicationContext _db;
        public ApplicationContext DB
        {
            get { return _db; }
            set { _db = value; }
        }

        private Utilisateur _Connected_user;
        public Utilisateur Connected_user
        {
            get { return _Connected_user; }
            set { _Connected_user = value; }

        }
        public MainWindow()
        {
            InitializeComponent();
            DB = new ApplicationContext();
            DB.Liste_Article.ToList();
            DB.Liste_Utilisateur.ToList();
        }

        private void Name_pageShop_Loaded(object sender, RoutedEventArgs e)
        {
            ((Page_Shop)name_pageShop.Content).Data_Grid_Article.ItemsSource = DB.Liste_Article.Local;
            ((Page_Shop)name_pageShop.Content).mw = this;
            ((Page_Admin)name_Admin_Frame.Content).mw = this;
        }
    }
}
