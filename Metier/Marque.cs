using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    /// <summary>
    /// Doit implementer INotifyPropertyChanged
    /// </summary>
    public class Marque  : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }
        /// <summary>
        /// Nom de la marque 
        /// </summary>
        public string Nom
        {
            get{ return mNom; }
            set
            {
                mNom = value;
                OnPropertyChanged("Nom");
            }
        }
        public string mNom= String.Empty;

        /// <summary>
        /// Pays d'origine de la marque 
        /// </summary>
        public string Pays
        {
            get { return mPays; }
            set { mPays = value;
            OnPropertyChanged("Pays");
            }
        }
        public string mPays;

        /// <summary>
        /// Nom du Fondateur de la marque 
        /// </summary>
        public string Fondateur
        {
            get { return mFondateur; }
            set
            {
                mFondateur = value;
                OnPropertyChanged("Fondateur");
            }
        }
        public string mFondateur;

        /// <summary>
        /// Image de la marque 
        /// </summary>
        public string ImageSource
        {
            get;
            set;
        }

        /// <summary>
        /// Collection observable des modeles de la marque 
        /// </summary>
        public ObservableCollection<Modele> Modeles
        {
            get;
            set;
        }

        /// <summary>
        /// Constructeur de marque sans collection de modele 
        /// Une collection de modele est initailisé à null 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pays"></param>
        /// <param name="fonda"></param>
        /// <param name="image"></param>
        public Marque(string nom, string pays, string fonda, string image)
        {
            Nom = nom;
            Pays = pays;
            Fondateur = fonda;
            ImageSource = image;
            Modeles = new ObservableCollection<Modele>();
        }

        /// <summary>
        /// Constructeur de marque avec une collection de modeles 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pays"></param>
        /// <param name="fonda"></param>
        /// <param name="image"></param>
        /// <param name="l"></param>
        public Marque(string nom, string pays, string fonda, string image, ObservableCollection<Modele> l)
        {
            Nom = nom;
            Pays = pays;
            Fondateur = fonda;
            ImageSource = image;
            Modeles = l;
        }

        /// <summary>
        /// Ajout d'une marque 
        /// </summary>
        /// <param name="m"></param>
        public static void AjouterMarque(Marque m)
        {
            Marques.Add(m);
        }

        /// <summary>
        /// Suppression d'une marque 
        /// </summary>
        /// <param name="m"></param>
        public static void supprimerMarque(Marque m)
        {
            Marques.Remove(m);
        }
       
        /// <summary>
        /// Collection statique observable de marque  
        /// </summary>
        public static ObservableCollection<Marque> Marques = new ObservableCollection<Marque>{

            new Marque("Aston Martin", "Allemagne","Lionel Martin","Image/MarqueAstonmartin.jpg",new ObservableCollection<Modele>(){
                new Modele("DB9","280","2003","Image/AstonMartinDB9.jpg"),
            }),

            new Marque("BMW", "Allemagne","Gustav Otto","Image/MarqueBMW.jpg",new ObservableCollection<Modele>(){
                new Modele("M3","280","2003","Image/M3.jpg"),
            }),

            new Marque("Bugatti", "France","Ettore Bugatti","Image/MarqueBugatti.jpg",new ObservableCollection<Modele>(){
                new Modele("Veyron","280","2003","Image/Veyron.jpg"),
            }),

            new Marque("Koenigsegg", "Suède","Christian von Koenigsegg","Image/MarqueKoenigsegg.jpg",new ObservableCollection<Modele>(){
                new Modele("R34","280","2003","Image/R34.jpg"),
            }),

            new Marque("Nissan", "Japon","Yoshisuke Aikawa","Image/MarqueNissan.jpg",new ObservableCollection<Modele>(){
                new Modele("R34","280","2003","Image/pointinterrogation.jpg"),
            }),

            new Marque("Ferrari", "Italie","Enzo Ferrari","Image/MarqueFerrari1.jpg",new ObservableCollection<Modele>(){
                new Modele("F430","500","2005","Image/FerrariF430.jpg"),
            }),

            
            

            /**
             new Marque("Nissan", "japon","Monsieur Nissan"new Uri("MarqueNissan.jpg"),new List<Modele>(){
             new Modele("r34","280","2003",new Uri("R34.jpg",UriKind.Relative)),
            }),
            **/
        };

        
    }
}
