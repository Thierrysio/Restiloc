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
        public Pool_Garage( string lieuRDV, string adresse, string immatriculation, string marque, string modele, DateTime dateHeureRDV) : base( lieuRDV, adresse, immatriculation, marque, modele, dateHeureRDV)
        {
        }
        #endregion

        #region Getters-Setters
        #endregion
        #region Methodes
        #endregion

    }
}
