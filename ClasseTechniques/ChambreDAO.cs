using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_HOTEL_APPLI
{
    internal class ChambreDAO
    {
        /// <summary>
        /// Retourne la liste des chambres disponible de l'hôtel pour les dates [dateTimeDebut, dateTimeFin] et/ou la réservation lareservation
        /// </summary>
        /// <param name="dateTimeDebut"></param>
        /// <param name="dateTimeFin"></param>
        /// <param name="lareservation">[optionnel]</param>
        /// <returns></returns>
        public static List<chambre> GetLesChambresDisponibles(List<chambre> lesChambresHotel, DateTime dateTimeDebut, DateTime dateTimeFin, reservation lareservation = null)
        {
            try {
                if (lareservation == null)
                {
                    // Filtrer les chambres qui n'ont pas de réservation qui chevauche la période [dateTimeDebut, dateTimeFin]
                    return lesChambresHotel.Where(chambre =>
                                !chambre.reservation.Any(reservation =>
                                    !(dateTimeDebut >= reservation.datefin || dateTimeFin <= reservation.datedeb)
                                )
                            ).OrderBy(c => c.nochambre).ToList();
                }
                else
                {
                    // Filtrer les chambres qui n'ont pas de réservation qui chevauche la période [lareservation.datedeb, lareservation.datefin]
                    // ou qui font partie de la réservation lareservation
                    return lesChambresHotel.Where(chambre =>
                                chambre.reservation.Contains(lareservation) ||
                                !chambre.reservation.Any(reservation =>
                                    (reservation.datedeb <= lareservation.datefin && reservation.datefin >= lareservation.datedeb)
                                )
                            ).OrderBy(c => c.nochambre).ToList();
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
                return null;
            }
        }
    }
}
