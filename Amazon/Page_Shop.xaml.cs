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
        public Page_Shop()
        {
            InitializeComponent();
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

    }
}
