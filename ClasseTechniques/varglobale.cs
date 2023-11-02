using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_HOTEL_APPLI
{
    public class varglobale
    {
        // Instance de la connexion à la base de données
        public static connexiondb connexion = new connexiondb();
        // Instance de la classe hotel
        public static hotel hotel;
    }
}
