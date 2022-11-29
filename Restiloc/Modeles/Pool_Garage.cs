using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restiloc.Modeles
{
    public class Pool_Garage : Expertise
    {
        #region attributs 
        #endregion

        #region constructeurs
        public Pool_Garage(int codeDossier, string lieuRDV, string adresse, string immatriculation, string marque, string modele, Indisponibilite laIndisponibilite, DateTime dateHeureRDV) : base(codeDossier, lieuRDV, adresse, immatriculation, marque, modele, laIndisponibilite, dateHeureRDV)
        {
        }
        #endregion

        #region Getters-Setters
        #endregion
        #region Methodes
        #endregion

    }
}
