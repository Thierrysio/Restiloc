using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restiloc.Modeles
{
    public class SocieteFinancement
    {
        #region attributs 
        private int _code;
        private string _nom;
        private List<Expertise> _lesExpertises;
        public static ObservableCollection<SocieteFinancement> CollClasse = new ObservableCollection<SocieteFinancement>();
        #endregion

        #region constructeurs
        public SocieteFinancement(int code, string nom)
        {
            _code = code;
            _nom = nom;
            _lesExpertises = new List<Expertise>();
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int GetCode()
        {
            return _code;
        }
        public string GetNom()
        {
            return _nom;
        }
        public List<Expertise> GetLesExpertises()
        {
            return _lesExpertises;
        }
        public void SetNom(string param)
        {
            _nom = param;
        }
        public void SetLesExpertises(List<Expertise> param)
        {
            _lesExpertises = param;
        }
        #endregion
        #region Methodes
        public  void  AjouterExpertisePool(string dossier, DateTime dateHeure, string lieu,string adresse, string immat, string marque, string modele)
        {
            this.GetLesExpertises().Add(new Pool_Garage( lieu, adresse, immat, marque, modele, null, dateHeure));
        }

        public List<Expertise> LesExpertisesIndispos()
        {
            List<Expertise> resultat = new List<Expertise>();

            foreach(Expertise uneExpertise in this.GetLesExpertises()) 
            { 
            if(uneExpertise.GetLaIndisponibilite() != null)
                {
                    resultat.Add(uneExpertise);
                }
            }

            return  resultat;

        }

        #endregion
    }
}
