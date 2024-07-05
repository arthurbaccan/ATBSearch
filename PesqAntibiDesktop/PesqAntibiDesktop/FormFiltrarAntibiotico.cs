using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dados;
using System.Globalization;
using Org.BouncyCastle.Crypto;

namespace PesqAntibiDesktop
{
    public partial class FormTabela : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable
        {
            Locale = CultureInfo.InvariantCulture
        };
        private int maxFontSize = 20;
        private int maxHeigth = 50;

        public FormTabela()
        {
            InitializeComponent();
            Load += new EventHandler(FormTabela_Load);
        }

        private void GetDataLocal(string selectCommand)
        {
            table.Clear();
            try
            {
                // Specify a connection string.
                String connectionString =
                    "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arthu\\source\\repos\\Pesquisador-de-Antibioticos\\PesqAntibiDesktop\\PesqAntibiDesktop\\APP_DATA\\Database1.mdf;Integrated Security=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate the data table and bind it to the BindingSource.
                dataAdapter.Fill(table);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Erro ao acessar banco de dados!");
            }
        }

        private void FormTabela_Load(object sender, EventArgs e)
        {

            GetDataLocal("select * from antibiotico");
            updateDataGrid();

        }

        private void updateDataGrid()
        {
            if (gridAntibiotico.Columns.Count != 0)
            {
                return;
            }
            // Create the columns with the desired names
            gridAntibiotico.Columns.Add("nome", "Nome do Antibiótico");
            gridAntibiotico.Columns.Add("tipo_antibiotico", "Tipo de Antibiótico");
            gridAntibiotico.Columns.Add("gram_positiva", "Age em Gram Positiva");
            gridAntibiotico.Columns.Add("gram_negativa", "Age em Gram Negativa");
            gridAntibiotico.Columns.Add("morfologia", "Morfologia Bacteriana");

            // Populate the columns with formatted the data from the data table
            foreach (DataRow row in table.Rows)
            {
                string tipoAntibiotico = Enum.GetName(typeof(TipoAntibiotico), row["tipo_antibiotico"]);

                string gramPositiva = "Não informado";
                if ((byte)row["gram_positiva"] == 0)
                {
                    gramPositiva = "❌";
                }
                else if ((byte)row["gram_positiva"] == 1)
                {
                    gramPositiva = "✅";
                }

                string gramNegativa = "Não informado";
                if ((byte)row["gram_negativa"] == 0)
                {
                    gramNegativa = "❌";
                }
                else if ((byte)row["gram_negativa"] == 1)
                {
                    gramNegativa = "✅";
                }

                // Change the antibioitc name(char[100]) to a correctly sized string (removes blank spaces)
                string nome = row["nome"].ToString().Trim();

                gridAntibiotico.Rows.Add(nome, tipoAntibiotico, gramPositiva, gramNegativa, row["morfologia"]);

                // change the color of the gram_positva and gram_negativa cells font. Puts the text in green
                // for the checmark and red for the X
                if (gramNegativa == "❌")
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_negativa"].Style.ForeColor = Color.Red;
                }
                else
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_negativa"].Style.ForeColor = Color.Green;
                }

                if (gramPositiva == "❌")
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_positiva"].Style.ForeColor = Color.Red;
                }
                else
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_positiva"].Style.ForeColor = Color.Green;
                }

            }

            gridAntibiotico.Refresh();

        }

        private void updateFontSize(Control label)
        {
            // Desired font size and adjustment factor (you may adjust these as needed)
            float scaleFactor = Math.Min(label.Width / TextRenderer.MeasureText(label.Text, label.Font).Width,
                                         label.Height / TextRenderer.MeasureText(label.Text, label.Font).Height);
            float sizeIncrease = 1.0f;

            // Calculate the new font size
            float newFontSize = label.Font.Size * scaleFactor * sizeIncrease;

            if (newFontSize < 8)
            {
                newFontSize = 8;
            }

            if (newFontSize > maxFontSize)
            {
                newFontSize = maxFontSize;
            }

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
        private string getTextNome()
        {
            string nome = textBoxNome.Text;
            return nome;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string selectCommand = "select * from antibiotico where";
            bool useAnd = false;
            bool filterSeected = false;

            if (!string.IsNullOrEmpty(getTextNome()))
            {
                selectCommand += " nome like '%" + getTextNome() + "%'";
                useAnd = true;
                filterSeected = true;
            }

            // if the box is not checked, it means that it should not show gram negativa antibiotics
            if (!checkBoxGramNegativa.Checked)
            {                 
                if (useAnd)
                {
                    selectCommand += " and gram_negativa = 0";
                }
                else
                {
                    selectCommand += " gram_negativa = 0";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxGramPositiva.Checked)
            {
                if (useAnd)
                {
                    selectCommand += " and gram_positiva = 0";
                }
                else
                {
                    selectCommand += " gram_positiva = 0";
                    useAnd = true;
                }
                filterSeected = true;
            }

            

            if (!checkBoxMacrolideos.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Macrolídeos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Macrolídeos)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxPenicilinas.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Penicilinas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Penicilinas)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxCefalosporinas.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Cefalosporinas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Cefalosporinas)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxCarbapenemicos.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Carbapenêmicos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Carbapenêmicos)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxAminoglicosideos.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Aminoglicosídeos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Aminoglicosídeos)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxQuinolonas.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Quinolonas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Quinolonas)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxAnfenicois.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Anfenicóis)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Anfenicóis)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxSulfonamidas.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Sulfonamidas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Sulfonamidas)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxGlicopeptideos.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Glicopeptídeos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Glicopeptídeos)}";
                    useAnd = true;
                }
                filterSeected = true;
            }
            

            if (!checkBoxNitroimidazolicos.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Nitroimidazólicos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Nitroimidazólicos)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxLicosamidas.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Licosamidas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Licosamidas)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxPolimixinas.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Polimixinas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Polimixinas)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxOxazolidinona.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Oxazolidinona)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Oxazolidinona)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxGlicilciclina.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Glicilciclina)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Glicilciclina)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!checkBoxAntituberculosos.Checked)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Antituberculosos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Antituberculosos)}";
                    useAnd = true;
                }
                filterSeected = true;
            }

            if (!filterSeected)
            {
                selectCommand = "select * from antibiotico";
            }

            GetDataLocal(selectCommand);
            gridAntibiotico.Rows.Clear();
            gridAntibiotico.Columns.Clear();
            updateDataGrid();
        }

        

        /*private void updateCheckBoxFonts(object sender, EventArgs e)
        {
            updateFontSize((Control)sender);
        }

        private void resizeFiltersInFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel)
        {
            // Resize all the components in the flow layout panel to fill it

            // get the ammount of controls in the flow layout panel
            int count = flowLayoutPanel.Controls.Count;

            int totalWidthControls = 0;

            foreach (Control control in flowLayoutPanel.Controls)
            {
                // get the original aspect ratio to factor in when risizing
                float aspectRatio = (float)control.Width / control.Height;

                control.Height = flowLayoutPanel.Height;

                if (control.Height > maxHeigth)
                {
                    control.Height = maxHeigth;
                }

                // calculates the width considering the aspect ration so the controls dont get too wide
                control.Width = (int)(control.Height * aspectRatio);

                totalWidthControls += control.Width;

            }

            int rows = 1;
            int loops = 0;
            int maxLoops = 5;
            while (totalWidthControls > flowLayoutPanel.Width * rows)
            {
                loops++;

                if (loops > maxLoops)
                {
                    break;
                }

                totalWidthControls = 0;
                rows++;
                // if the controls are too wide, resize them to fit the flow layout panel, adding a new row
                foreach (Control control in flowLayoutPanel.Controls)
                {
                    // get the original aspect ratio to factor in when risizing
                    float aspectRatio = (float)control.Width / control.Height;

                    int height = flowLayoutPanel.Height / rows;
                    control.Height = height;

                    if (control.Height > maxHeigth)
                    {
                        control.Height = maxHeigth;
                    }

                    // calculates the width considering the aspect ratio so the controls dont get too wide
                    control.Width = (int)(control.Height * aspectRatio);

                    totalWidthControls += control.Width;

                }
            }
        }

        private void flowLayoutTipoBacteria_SizeChanged(object sender, EventArgs e)
        {
            resizeFiltersInFlowLayoutPanel(flowLayoutTipoBacteria);
        }

        private void flowLayoutTipoAntibiotico_SizeChanged(object sender, EventArgs e)
        {
            resizeFiltersInFlowLayoutPanel(flowLayoutTipoAntibiotico);
        }*/

    }
}
