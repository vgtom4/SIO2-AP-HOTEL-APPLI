//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AP_HOTEL_APPLI
{
    using System;
    using System.Collections.Generic;
    
    public partial class photo
    {
        public int nohotel { get; set; }
        public int nophoto { get; set; }
        public string nomfichier { get; set; }
    
        public virtual hotel hotel { get; set; }
    }
}
