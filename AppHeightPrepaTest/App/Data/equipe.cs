//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipe
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string logo { get; set; }
        public string siteweb { get; set; }
        public string id_listeJoueurEquipe { get; set; }
        public Nullable<short> complete { get; set; }
        public int idadmin { get; set; }
        public int id_sport { get; set; }
        public System.DateTime DateCreation { get; set; }
        public System.DateTime DateModification { get; set; }
    }
}
