using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_HOTEL_APPLI
{
    internal class ReservationDAO
    {
        public static void UpdateReservation(reservation laReservation, List<chambre> lesChambres)
        {
            laReservation.chambre = lesChambres;
            varglobale.connexion.SaveChanges();
        }
    }
}
