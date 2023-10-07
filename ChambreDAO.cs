using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_HOTEL_APPLI
{
    internal class ChambreDAO
    {
        public static List<chambre> GetLesChambresDisponibles(DateTime dateTimeDebut, DateTime dateTimeFin, reservation lareservation = null)
        {
            if (lareservation == null)
            {
                return varglobale.hotel.chambre.Where(chambre =>
                        // Filtrer les chambres qui n'ont pas de réservation qui chevauche la période [dateTimeDebut, dateTimeFin]
                        !chambre.reservation.Any(reservation =>
                                !(dateTimeDebut >= reservation.datefin || 
                                dateTimeFin <= reservation.datedeb))).ToList();
            }

            else
            {
                return varglobale.hotel.chambre.Where(chambre => 
                        !chambre.reservation.Any(reservation => 
                                reservation.datedeb.Value.ToString("d") == lareservation.datedeb.Value.ToString("d")) || 
                                chambre.reservation.Contains(lareservation)).ToList();
            }
        }
    }
}
