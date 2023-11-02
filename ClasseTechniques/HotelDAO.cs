using System;
using System.Collections.Generic;
using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;

namespace AP_HOTEL_APPLI
{
    internal class HotelDAO
    {
        /// <summary>
        /// Permet de modifier les informations de l'hotel connecté dans la base de données.
        /// </summary>
        public static void UpdateHotel(string nom, string password, string adresse1, string adresse2, string ville, string cp, string tel, string descriptionLongue, string descriptionCourte, Single prix, List<equipement> lesEquipements)
        {
            try
            {
                varglobale.hotel.nom = nom;
                varglobale.hotel.password = password;
                varglobale.hotel.adr1 = adresse1;
                varglobale.hotel.adr2 = adresse2;
                varglobale.hotel.ville = ville;
                varglobale.hotel.cp = cp;
                varglobale.hotel.tel = tel;
                varglobale.hotel.deslong = descriptionLongue;
                varglobale.hotel.descourt = descriptionCourte;
                varglobale.hotel.prix = prix;
                varglobale.hotel.equipement = lesEquipements;
                varglobale.connexion.SaveChanges();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }
    }
}
