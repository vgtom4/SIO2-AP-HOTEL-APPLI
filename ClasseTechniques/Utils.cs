using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI.ClasseTechniques
{
    internal class Utils
    {
        /// <summary>
        /// Permet de vérifier si un hotel est connecté
        /// </summary>
        /// <returns>true, si un hotel est connecté. Sinon, false</returns>
        public static bool HotelIsConnected()
        {
            try
            {
                return varglobale.hotel != null;
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
                return false;
            }
        }   
        /// <summary>
        /// Permet de supprimer les erreurs providers d'une liste et de la vider
        /// </summary>
        /// <param name="listErrorProviders">Liste contenant les errorProviders d'un formulaire</param>
        public static void RemoveErrorProviders(List<ErrorProvider> listErrorProviders)
        {
            try {
                foreach (var errorProvider in listErrorProviders)
                {
                    errorProvider.Clear();
                }
                listErrorProviders.Clear();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de créer des erreurs providers pour les contrôles invalides
        /// </summary>
        /// <param name="listErrorProviders">Liste contenant les errorProviders d'un formulaire</param>
        /// <param name="invalidControls">Dictionnaire de controls invalides liés à un message d'erreur</param>
        public static void SetErrorProviders(List<ErrorProvider> listErrorProviders, Dictionary<Control, string> invalidControls)
        {
            try {
                foreach (var Control in invalidControls.Keys)
                {
                    ErrorProvider errorProvider = new ErrorProvider();
                    errorProvider.SetError(Control, invalidControls[Control]);
                    listErrorProviders.Add(errorProvider);
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de créer un fichier log en cas d'erreur
        /// </summary>
        /// <param name="message">exception</param>
        public static void GenerateFileError(Exception message)
        {
            // En cas d'erreur, création du fichier log
            using (System.IO.StreamWriter writer = System.IO.File.AppendText(@Application.StartupPath + "\\ErrorLogs\\" + DateTime.Now.ToString("dd-MM-yyyy_HH'h'mm") + ".txt")) { writer.WriteLine(DateTime.Now.ToString() + " - " + message.Message + "\n"); }
            //MessageBox.Show("Une erreur est survenu. Erreur enregistrée dans le dossier ErrorLog.");
        }
    }
}
