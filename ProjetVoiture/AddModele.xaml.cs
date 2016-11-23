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
using Metier;

namespace ProjetVoiture
{
    /// <summary>
    /// Logique d'interaction pour AddModele.xaml
    /// </summary>
    public partial class AddModele : Window
    {
        private Marque p;
        public string Image;

        public AddModele()
        {
            InitializeComponent();
        }

        /// <summary>
        /// constructeur qui permet de connaitre la marque sélectionnée 
        /// </summary>
        /// <param name="p"></param>
        public AddModele(Marque p)
        {
           
            this.p = p;
            InitializeComponent();
        }

        /// <summary>
        ///  Bouton quitter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Annuler_Modele(object sender, RoutedEventArgs e)
        {
           this.Close();
        }

        /// <summary>
        /// Permet d'enlever la phrase dans la textbox au moment ou l'utilisateur va écrire 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox send = sender as TextBox;
            send.Text = "";
            send.Foreground = Brushes.Black;
        }

        /// <summary>
        /// Bouton parcourir 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parcourir_Marque(object sender, RoutedEventArgs e)
        {
            //recopié de l'exemple 069_008
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);// "C:\\Users\\Public\\Pictures\\Sample Pictures";
            dlg.FileName = "Image"; // Default file name
            dlg.DefaultExt = ".jpg | .png | .gif"; // Default file extension
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif"; // Filter files by extension 

            // Show open file dialog box
            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;

                //copie du fichier sélectionné dans le dossier contenant les images de notre application MAIS NE MARCHE PAS !!!!!!!!!!!!!!!!!!! JE SAIS PAS POURQUOI
                //System.IO.File.Copy(filename, string.Format("{0}\\Image\\{1}", System.IO.Directory.GetCurrentDirectory(), System.IO.Path.GetFileName(filename)), true);
                Image = filename;
                mCheminImageBlock.Text = filename;
            }
        }

        /// <summary>
        /// Ajout d'un modele 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ajouter_Modele(object sender, RoutedEventArgs e)
        {

            bool b1;
            int i;

            if (mNomm.Text.Trim() == "" || mAnnee.Text.Trim() == "" || mPuissance.Text.Trim() == "" || mNomm.Text.Trim() == "Entrez le modèle" || mPuissance.Text.Trim() == "Entrez la puissance" || mAnnee.Text.Trim() == "Entrez l'année de création")
            {
                MessageBox.Show("Des champs ne sont pas renseignés !");
                return;
            }

            b1 = int.TryParse(mAnnee.Text.Trim(), out i);
            if (b1 == false)
            {
                MessageBox.Show("Certains champs sont invalides !");
                return;
            }

            if (Image == null)
            {
                p.Modeles.Add(new Modele(mNomm.Text.Trim(), mPuissance.Text.Trim(), mAnnee.Text.Trim(),"Image/pointinterrogation.jpg"));
            }
            else
            {
                p.Modeles.Add(new Modele(mNomm.Text.Trim(), mPuissance.Text.Trim(), mAnnee.Text.Trim(),Image ));

            }
            this.Close();
        }
    }
}
