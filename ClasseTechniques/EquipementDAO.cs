using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    internal class EquipementDAO
    {
        public static List<equipement> GetLesEquipementsDGV(DataGridView grdEquipements)
        {
            try
            {
                List<equipement> lesEquipements = new List<equipement>();
                foreach (DataGridViewRow row in grdEquipements.Rows)
                {
                    if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                    {
                        // Ajouter l'équipement dans la liste des équipements de l'hotel
                        string lib = row.Cells[1].Value.ToString();
                        lesEquipements.Add(varglobale.connexion.equipement.Where(equip => equip.lib == lib).FirstOrDefault());
                    }
                }
                return lesEquipements;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
