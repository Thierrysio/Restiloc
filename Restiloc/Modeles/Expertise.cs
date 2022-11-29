using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restiloc.Modeles
{
    public abstract class Expertise
    {
        #region attributs 
        private int _codeDossier;
        private string _lieuRDV;
        private string _adresse;
        private string _immatriculation;
        private string _marque;
        private string _modele;
        private Indisponibilite _laIndisponibilite;
        private DateTime _dateHeureRDV;
        public static ObservableCollection<Expertise> CollClasse = new ObservableCollection<Expertise>();
        #endregion

        #region constructeurs
        public Expertise( string lieuRDV, string adresse, string immatriculation, string marque, string modele,  DateTime dateHeureRDV)
        {
            _codeDossier = Expertise.CollClasse.Count + 1;
            _lieuRDV = lieuRDV;
            _adresse = adresse;
            _immatriculation = immatriculation;
            _marque = marque;
            _modele = modele;
            _dateHeureRDV = dateHeureRDV;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int GetCodeDossier()
        {
            return _codeDossier;
        }
        public string GetLieuRDV()
        {
            return _lieuRDV;
        }
        public string GetAdresse()
        {
            return _adresse;
        }
        public string GetImmatriculation()
        {
            return _immatriculation;
        }
        public string GetMarque()
        {
            return _marque;
        }
        public string GetModele()
        {
            return _modele;
        }
        public Indisponibilite GetLaIndisponibilite()
        {
            return _laIndisponibilite;
        }
        public DateTime GetDateHeureRDV()
        {
            return _dateHeureRDV;
        }
        public void SetLaIndisponibilite(Indisponibilite param)
        {
            _laIndisponibilite = param;
        }
        public void SetDateHeureRDV(DateTime param)
        {
            _dateHeureRDV = param;
        }
        #endregion
        #region Methodes
        #endregion
    }
}
