using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class Form1 : Form
    {
        connexiondb maconnexion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maconnexion = new connexiondb();
            hotel unhotel = new hotel();
            unhotel.nohotel = 1;
            unhotel.nom = "Love Hotel";
            unhotel.adr1 = "test";
            unhotel.adr2 = "test2";
            unhotel.cp = 69100;
            unhotel.ville = "Villeurbanne";
            unhotel.tel = 0669696969;
            unhotel.descourt = "Hotel ";
            unhotel.deslong = "ede";
            unhotel.prix = 1000;
            unhotel.password = "JESUSETAITFRANCMACON";
            Console.WriteLine(unhotel.nom);
            maconnexion.hotel.Add(unhotel);
            maconnexion.SaveChanges();

        }
    }
}
