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
    public partial class FormTabela : Form
    {
        public FormTabela()
        {
            InitializeComponent();
        }

        private void FormTabela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.antibiotico' table. You can move, or remove it, as needed.
            this.antibioticoTableAdapter.Fill(this.database1DataSet.antibiotico);

        }

        private void updateFontSize(Label label)
        {
            // Desired font size and adjustment factor (you may adjust these as needed)
            float scaleFactor = Math.Min(label.Width / TextRenderer.MeasureText(label.Text, label.Font).Width,
                                         label.Height / TextRenderer.MeasureText(label.Text, label.Font).Height);
            float sizeIncrease = 1;

            // Calculate the new font size
            float newFontSize = label.Font.Size * scaleFactor * sizeIncrease; 

            // Create a new font instance with the new size
            label.Font = new Font(label.Font.FontFamily, newFontSize, label.Font.Style);
        }

        private void labelTituloTab_SizeChanged(object sender, EventArgs e)
        {
            updateFontSize(labelTituloTab);
        }

        private void label1Pesquisar_SizeChanged(object sender, EventArgs e)
        {
            updateFontSize(labelPesquisarNome);
        }
    }
}
