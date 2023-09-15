using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public class passerelle
    {
        public static bool initConnexion(string id, string password)
        {
            try
            {
                if (varglobale.connexion.hotel.Where(hotel => hotel.nom == id && hotel.password == password).Any())
                {
                    varglobale.hotel = varglobale.connexion.hotel.Where(hotel => hotel.nom == id && hotel.password == password).FirstOrDefault();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            
            
        }
    }
}
