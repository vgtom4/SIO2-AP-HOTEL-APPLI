using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AP_HOTEL_APPLI
{
    class passerelleReservation
    {
        public static connexiondb connexion = new connexiondb();
        public static chambre getLaChambre(int nochambre, int nohotel) 
        { 
            return varglobale.hotel.chambre.Where(c => c.nochambre == nochambre).FirstOrDefault();
        }

        public static bool IsChambreReservee(chambre lachambre, DateTime dateDebut, DateTime dateFin)
        {
            // Récupération des réservations de la chambre

            // true si il existe une réservation pour la chambre 'nochambre' pour la période donnée (dateDebut, dateFin) ou false sinon
            return lachambre.reservation.Any(reservation => reservation.datedeb <= dateDebut && dateDebut <= reservation.datefin && reservation.datedeb <= dateFin && dateFin <= reservation.datefin);



            //// vérifier si la chambre est réservée pour la période donnée (dateDebut, dateFin) et retourner true si c'est le cas ou false sinon

            ////SqlParameter paramDateDebut = new SqlParameter("@newDateDebut", dateDebut);
            ////SqlParameter paramDateFin = new SqlParameter("@newDateFin", dateFin);

            ////bool reservationExists = varglobale.connexion.reservation
            ////    .SqlQuery("DECLARE @newDateDebut DATETIME = @p0; " +
            ////                "DECLARE @newDateFin DATETIME = @p1; " +
            ////                "SELECT CASE " +
            ////                "WHEN EXISTS (" +
            ////                "    SELECT Id FROM reservation " +
            ////                "    WHERE (@newDateDebut BETWEEN DateDebut AND DateFin OR @newDateFin BETWEEN DateDebut AND DateFin) " +
            ////                "    AND NOT EXISTS (" +
            ////                "        SELECT Id FROM reservation " +
            ////                "        WHERE DateFin BETWEEN DATEADD(HOUR, 1, @newDateDebut) AND DATEADD(HOUR, 1, @newDateFin)" +
            ////                "    )" +
            ////                ") THEN 1 " +
            ////                "ELSE 0 " +
            ////                "END AS reservationExists;", paramDateDebut, paramDateFin)
            ////    .AsEnumerable()
            ////    .FirstOrDefault().Equals(1);

            ////// 'query' est maintenant un booléen représentant le résultat de votre requête
            //bool reservationExists = true;

            //// 'query' est maintenant un booléen représentant le résultat de votre requête
            ////bool reservationExists = query == 1;
            //return reservationExists;
        }
    }
}
