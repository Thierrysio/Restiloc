using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restiloc.Modeles
{
    public class Indisponibilite
    {
        #region attributs 
        private string _clientResponsable;
        private string _motif;
        public static ObservableCollection<Indisponibilite> CollClasse = new ObservableCollection<Indisponibilite>();
        #endregion

        #region constructeurs
        public Indisponibilite(string clientResponsable, string motif)
        {
            _clientResponsable = clientResponsable;
            _motif = motif;
            CollClasse.Add(this);
        }
        #endregion

        #region Getters-Setters
        public string GetClientResponsable()
        {
            return _clientResponsable;
        }
        public string GetMotif()
        {
            return _motif;
        }
        #endregion
        #region Methodes
        #endregion
    }
}
