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
    
    public partial class hotel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hotel()
        {
            this.chambre = new HashSet<chambre>();
            this.photo = new HashSet<photo>();
            this.reservation = new HashSet<reservation>();
            this.equipement = new HashSet<equipement>();
        }
    
        public int nohotel { get; set; }
        public string nom { get; set; }
        public string adr1 { get; set; }
        public string adr2 { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string tel { get; set; }
        public string descourt { get; set; }
        public string deslong { get; set; }
        public Nullable<double> prix { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chambre> chambre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<photo> photo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipement> equipement { get; set; }
    }
}
