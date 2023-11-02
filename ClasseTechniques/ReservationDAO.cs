using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    internal class ReservationDAO
    {
        /// <summary>
        /// Permet de modifier les informations d'une réservation
        /// </summary>
        /// <param name="laReservation"></param>
        /// <param name="lesChambres"></param>
        public static void UpdateReservation(reservation laReservation, List<chambre> lesChambres)
        {
            try {
                laReservation.chambre = lesChambres;
                varglobale.connexion.SaveChanges();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de renvoyer la liste des réservations correspondants à la date saisie en paramètre
        /// </summary>
        /// <param name="dateDeReservation"></param>
        /// <returns>Liste de réservation</returns>
        public static List<reservation> GetLesReservationsDate(DateTime dateDeReservation)
        {
            try {
                // Renvoie la liste des réservations se déroulant pendant la date saisie en paramètre
                return varglobale.hotel.reservation.Where(reservation =>
                               reservation.datedeb.Value.Date <= dateDeReservation.Date && dateDeReservation.Date <= reservation.datefin.Value.Date
                                          ).OrderBy(reservation => reservation.datedeb).ToList();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
                return null;
            }
        }
    }
}
