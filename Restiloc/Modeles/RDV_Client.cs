﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restiloc.Modeles
{
    public class RDV_Client : Expertise
    {
        #region attributs 
        private string _nomContact;
        private string _telephone;
        private string _mail;


        #endregion

        #region constructeurs

        public RDV_Client(string nomContact, string telephone, string mail, string lieuRDV, string adresse, string immatriculation, string marque, string modele, DateTime dateHeureRDV) : base( lieuRDV, adresse, immatriculation, marque, modele, dateHeureRDV)
        {
            _nomContact = nomContact;
            _telephone = telephone;
            _mail = mail;
        }
        #endregion

        #region Getters-Setters
        public string GetNomContact()
        {
            return _nomContact;
        }
        public string GetTelephone()
        {
            return _telephone;
        }
        public string GetMail()
        {
            return _mail;
        }
        #endregion
        #region Methodes
        public override void ChangerEtatExpertiseAbstract()
        {
            string x = "riri";
        }
        #endregion
    }
}
