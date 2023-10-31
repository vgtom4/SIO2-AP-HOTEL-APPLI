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
        public static void RemoveErrorsProvider(List<ErrorProvider> listErrorProviders)
        {
            foreach (var errorProvider in listErrorProviders)
            {
                errorProvider.Clear();
            }
            listErrorProviders.Clear();
        }

        public static void SetErrorProviders(List<ErrorProvider> listErrorProviders, Dictionary<Control, string> invalidControls)
        {
            foreach (var Control in invalidControls.Keys)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(Control, invalidControls[Control]);
                listErrorProviders.Add(errorProvider);
            }
        }
    }
}
