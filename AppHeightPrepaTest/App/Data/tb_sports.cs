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
    
    public partial class tb_sports
    {
        public int id { get; set; }
        public string sporttitre { get; set; }
        public Nullable<int> FK_Subclasse_sport { get; set; }
        public Nullable<int> FK_classifications_sport { get; set; }
        public string typeSport { get; set; }
    }
}
