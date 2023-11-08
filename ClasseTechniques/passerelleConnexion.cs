using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;

namespace AP_HOTEL_APPLI
{
    public class PasserelleConnexion
    {
        /// <summary>
        /// Permet d'initialiser la connexion à un hôtel en fonction de l'identifiant et du mot de passe.
        /// </summary>
        /// <param name="id">Identifiant d'hotel</param>
        /// <param name="password">Mot de passe d'hotel</param>
        /// <returns>true, si un hôtel correspond à l'identifiant et au mot de passe. Sinon, false</returns>
        public static bool InitConnexion(string id, string password)
        {
            try
            {
                // Vérifie si l'identifiant et le mot de passe saisis par l'utilisateur correspondent à un hôtel
                if (varglobale.connexion.hotel.Where(hotel => hotel.nom == id && hotel.password == password).Any())
                {
                    // Initialise la connexion à l'hôtel correspondant à l'identifiant et au mot de passe
                    varglobale.hotel = varglobale.connexion.hotel.Where(hotel => hotel.nom == id && hotel.password == password).FirstOrDefault();
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
                return false;
            }
        }
    }
}
