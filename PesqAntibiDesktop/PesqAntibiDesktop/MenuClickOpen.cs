using System;
using System.Linq;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public abstract class MenuClickOpen
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
                FormShow.forceShowform(Application.OpenForms.OfType<FormTabelasPersonalizadas>().First());
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
                FormShow.forceShowform(Application.OpenForms.OfType<FormTabela>().First());
            }
        }

        public static void formLoginOpen()
        {
            //check if there are any FormLogin open
            if (Application.OpenForms.OfType<FormLoginLocal>().Count() == 0)
            {
                FormLoginLocal formLogin = new FormLoginLocal();
                formLogin.Show();
            }
            else
            {
                FormShow.forceShowform(Application.OpenForms.OfType<FormLoginLocal>().First());
            }
        }
    }
}
