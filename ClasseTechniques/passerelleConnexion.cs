using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_HOTEL_APPLI.EntityModel;

namespace AP_HOTEL_APPLI
{
    public class passerelleConnexion
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
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
