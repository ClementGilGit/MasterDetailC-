using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Modele : INotifyPropertyChanged 
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
        /// Nom du modele 
        /// </summary>
        public string Nomm
        {
            get { return mNomm; }
            set
            {
                mNomm = value;
                OnPropertyChanged("Nomm");
            }
        }
        public string mNomm;

        /// <summary>
        /// Puissance du modele de voiture 
        /// </summary>
        public string Puissance
        {
            get { return mPuissance; }
            set
            {
                mPuissance = value;
                OnPropertyChanged("Puissance");
            }
        }
        public string mPuissance;

        /// <summary>
        /// Année de création de la voiture 
        /// </summary>
        public string Annee
        {
            get { return mAnnee; }
            set
            {
                mAnnee = value;
                OnPropertyChanged("Annee");
            }
        }
        public string mAnnee;

        /// <summary>
        /// Image de la voiture 
        /// </summary>
        public string ImageSource
        {
            get;
            set;
        }

        /// <summary>
        /// Constructeur du modele 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="puiss"></param>
        /// <param name="annee"></param>
        /// <param name="image"></param>
        public Modele(string nom, string puiss, string annee, string image)
        {
            Nomm = nom;
            Puissance = puiss;
            Annee = annee;
            ImageSource = image;
        }


       
    }
}
