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
using Metier;

namespace ProjetVoiture
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

       
        
        /// <summary>
        /// Ajout d'une marque 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouter(object sender, RoutedEventArgs e)
        {
            // Parametre dans le constructeur pour l'ajout 
            var windowAddMarque = new AddMarque();
            windowAddMarque.ShowDialog();
        }

        /// <summary>
        /// Ajout d'un modele 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ajouter_Modele(object sender, RoutedEventArgs e)
        {
            var windowAddModele = new AddModele((Marque)mListBoxMarques.SelectedItem);
            windowAddModele.ShowDialog();
        }

        /// <summary>
        /// Supprimer une marque 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supprimer_Marque(object sender, RoutedEventArgs e)
        {
            Marque.supprimerMarque((Marque)mListBoxMarques.SelectedItem);
        }

        /// <summary>
        /// Supprimer un modele 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supprimer_Modele(object sender, RoutedEventArgs e)
        {
            Marque m = (mListBoxMarques.SelectedItem as Marque);

            m.Modeles.Remove((Modele)ListBoxModele.SelectedItem);
        }

        /// <summary>
        /// Affiche la premiere image de marque 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Passage_Sur_Liste(object sender, RoutedEventArgs e)
        {
            ImageMarque.Visibility = Visibility.Visible;
            ImageVoiture.Visibility = Visibility.Hidden;
            DetailMarque.Visibility = Visibility.Visible;
            DetailModele.Visibility = Visibility.Hidden;
            BorderDetail.Visibility = Visibility.Visible;
        }

        private void Passage_Sur_Liste_Voiture(object sender, RoutedEventArgs e)
        {
            ImageVoiture.Visibility = Visibility.Visible;
            ImageMarque.Visibility = Visibility.Hidden;
            DetailMarque.Visibility = Visibility.Hidden;
            DetailModele.Visibility = Visibility.Visible;
            BorderDetail.Visibility = Visibility.Visible;
            
        }

        
       
    }
}
