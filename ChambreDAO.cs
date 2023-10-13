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
                                dateTimeFin <= reservation.datedeb))
                        ).OrderBy(c=> c.nochambre).ToList();
            }

            else
            {
                //return varglobale.hotel.chambre.Where(chambre =>
                //        !chambre.reservation.Any(reservation =>
                //                reservation.datedeb.Value.ToString("d") == lareservation.datedeb.Value.ToString("d")) ||
                //                chambre.reservation.Contains(lareservation))
                //    .OrderBy(c => c.nochambre).ToList();

                // On récupère les chambres qui ne sont pas réservées pour la période [datedeb, datefin] et qui sont les chambres de la réservation
                //return varglobale.hotel.chambre.Where(chambre =>
                //        chambre.reservation.Contains(lareservation) ||
                //        //Filtrer les chambres qui n'ont pas de réservation qui chevauche la période [dateTimeDebut, dateTimeFin]
                //        !chambre.reservation.Any(reservation =>
                //                (reservation.datedeb > dateTimeDebut && reservation.datefin > dateTimeDebut) ||
                //                (reservation.datedeb < dateTimeFin && reservation.datefin < dateTimeFin)))
                //        .OrderBy(c => c.nochambre).ToList();

                return varglobale.hotel.chambre.Where(chambre =>
                            chambre.reservation.Contains(lareservation) ||
                            !chambre.reservation.Any(reservation =>
                                (reservation.datedeb <= dateTimeFin && reservation.datefin >= dateTimeDebut))
                        ).OrderBy(c => c.nochambre).ToList();
            }
        }
    }
}
