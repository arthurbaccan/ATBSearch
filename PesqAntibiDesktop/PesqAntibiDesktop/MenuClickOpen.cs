using System;
using System.Linq;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public class MenuClickOpen
    {
        public static void tabelasPersonalizadasOpen()
        {
            //check if there are any FormTabelasPersonalizadas open
            if (Application.OpenForms.OfType<FormTabelasPersonalizadas>().Count() == 0)
            {
                FormTabelasPersonalizadas formTabelasPersonalizadas = new FormTabelasPersonalizadas();
                formTabelasPersonalizadas.Show();
            }
            else
            {
                Application.OpenForms.OfType<FormTabelasPersonalizadas>().First().Focus();
            }
        }

        public static void tabelaDeAntibióticosOpen()
        {
            //check if there are any FormFiltrarAntibiotico open
            if (Application.OpenForms.OfType<FormTabela>().Count() == 0)
            {
                FormTabela formTabela = new FormTabela();
                formTabela.Show();
            }
            else
            {
                Application.OpenForms.OfType<FormTabela>().First().Focus();
            }
        }
    }
}
