using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public partial class FormTabelasPersonalizadas : Form
    {
        private int maxFontSize = 20;
        public FormTabelasPersonalizadas()
        {
            InitializeComponent();
        }

        private void tabelasPersonalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MenuClickOpen.tabelasPersonalizadasOpen();
        }

        private void tabelaDeAntibióticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MenuClickOpen.tabelaDeAntibióticosOpen();
        }

        private void labelTituloTab_SizeChanged(object sender, EventArgs e)
        {
            FontSizer.updateFontSize(labelTituloTab, maxFontSize);
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            
            //check if there are any FormFiltrarAntibiotico open
            if (Application.OpenForms.OfType<FormCriarTabela>().Count() == 0)
            {
                FormCriarTabela formCriarTabela = new FormCriarTabela();
                formCriarTabela.Show();
            }
            else
            {
                Application.OpenForms.OfType<FormCriarTabela>().First().Focus();
            }
        }
    }
}
