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
    /// Logique d'interaction pour Page_Inscription.xaml
    /// </summary>
    public partial class Page_Inscription : Window
    {
        private MainWindow mw { get; set; }

        public Page_Inscription(MainWindow m)
        {
            InitializeComponent();
            mw = m;
        }

        private void Insc_boutonSeConnecter_Click(object sender, RoutedEventArgs e)
        {
            bool pseudoDejaPris = false;

            Utilisateur user = new Utilisateur(Insc_Pseudo.Text, Insc_Password.Password);

            foreach (Utilisateur item in mw.DB.Liste_Utilisateur)
            {
                if (Insc_Pseudo.Text == item.Pseudo)
                {
                    pseudoDejaPris = true;
                }
            }

            if (!pseudoDejaPris)
            {
                mw.DB.Liste_Utilisateur.Add(user);
                mw.DB.SaveChanges();
                MessageBox.Show("Vous vous êtes bien enregistré", "Bien enregistré", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Pseudo déjà utilisé", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
