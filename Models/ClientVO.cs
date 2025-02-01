using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMVC.Models
{
    class ClientVO
    {
        #region Variables et Objets de Cours
        /// <summary>
        /// Désigne le numéro du client.
        /// </summary>
        private int numeroClient;


        private string Prenom;
        private string Nom;
        private string DateNaissance;
        private string Description;
        private string Adresse;
        private string Telephone;
        #endregion

        #region Constructeur de Cours
        /// <summary>
        /// Initializes a new instance of the <see cref="CoursVO"/> class.
        /// Constructeur de CoursVO créant un objet ayant les attributs 
        /// passé en paramètres provenant de CoursDAO - qui accède la base de donnée.
        /// </summary>
        public ClientVO()
        {
        }
        #endregion

        #region Accesseurs et Mutateurs pour Cours
        /// <summary>
        /// Gets or sets pour numeroCours.
        /// </summary>
        public int NumeroClient
        {
            get { return this.numeroClient; }
            set { this.numeroClient = value; }
        }

        /// <summary>
        /// Gets or sets pour titreCours.
        /// </summary>
        public string NomClient
        {
            get { return this.Nom; }
            set { this.Nom = value; }
        }

        public string PrenomClient
        {
            get { return this.Prenom; }
            set { this.Prenom = value; }
        }

        public string DateNaissanceClient
        {
            get { return this.DateNaissance; }
            set { this.DateNaissance = value; }
        }

        public string DescriptionClient
        {
            get { return this.Description; }
            set { this.Description = value; }
        }

        public string AdresseClient
        {
            get { return this.Adresse; }
            set { this.Adresse = value; }
        }

        public string TelephoneClient
        {
            get { return this.Telephone; }
            set { this.Telephone = value; }
        }
        #endregion
    }
}