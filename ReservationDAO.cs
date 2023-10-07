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
        public static void UpdateReservation(reservation laReservation, List<chambre> lesChambres)
        {
            laReservation.chambre = lesChambres;
            varglobale.connexion.SaveChanges();
        }

        public static List<reservation> GetLesReservationsDate(DateTime dateDeReservation)
        {
            return varglobale.hotel.reservation.Where(reservation => reservation.datedeb.Value.ToString("d") == dateDeReservation.ToString("d")).ToList();
        }
    }
}
