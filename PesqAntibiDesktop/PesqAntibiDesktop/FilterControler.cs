using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public abstract class FilterControler
    {
        public static void uncheckCheckBoxes(Control control)
        {

            if (control is CheckBox)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Checked = false;
            }

        }

        public static void checkCheckBoxes(Control control)
        {

            if (control is CheckBox)
            {
                CheckBox checkBox = (CheckBox)control;
                checkBox.Checked = true;
            }

        }

        public static void cleanFilters(FlowLayoutPanel flowLayoutTipoAntibiotico, FlowLayoutPanel flowLayoutTipoBacteria, TextBox textBoxNome)
        {
            // uncheck all check boxes and clear the text box
            foreach (Control control in flowLayoutTipoAntibiotico.Controls)
            {
                uncheckCheckBoxes(control);
            }

            foreach (Control control in flowLayoutTipoBacteria.Controls)
            {
                uncheckCheckBoxes(control);
            }

            textBoxNome.Clear();

        }

        public static void selectAllFilters(FlowLayoutPanel flowLayoutTipoAntibiotico, FlowLayoutPanel flowLayoutTipoBacteria)
        {
            // check all check boxes
            foreach (Control control in flowLayoutTipoAntibiotico.Controls)
            {
                checkCheckBoxes(control);
            }

            foreach (Control control in flowLayoutTipoBacteria.Controls)
            {
                checkCheckBoxes(control);
            }
        }
    }
}
