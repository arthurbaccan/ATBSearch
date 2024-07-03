
namespace PesqAntibiDesktop
{
    partial class FormTabela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripTelas = new System.Windows.Forms.MenuStrip();
            this.tabelaDeAntibióticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControles = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelControlesLabel = new System.Windows.Forms.Panel();
            this.labelTituloTab = new System.Windows.Forms.Label();
            this.panelFiltrosPesquisar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPesquisarNome = new System.Windows.Forms.Label();
            this.splitterControlesGrid = new System.Windows.Forms.Splitter();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridAntibiotico = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new PesqAntibiDesktop.Database1DataSet();
            this.antibioticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.antibioticoTableAdapter = new PesqAntibiDesktop.Database1DataSetTableAdapters.antibioticoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoantibioticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grampositivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramnegativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morfologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripTelas.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelControlesLabel.SuspendLayout();
            this.panelFiltrosPesquisar.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAntibiotico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antibioticoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTelas
            // 
            this.menuStripTelas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDeAntibióticosToolStripMenuItem});
            this.menuStripTelas.Location = new System.Drawing.Point(0, 0);
            this.menuStripTelas.Name = "menuStripTelas";
            this.menuStripTelas.Size = new System.Drawing.Size(800, 24);
            this.menuStripTelas.TabIndex = 0;
            this.menuStripTelas.Text = "menuStrip1";
            // 
            // tabelaDeAntibióticosToolStripMenuItem
            // 
            this.tabelaDeAntibióticosToolStripMenuItem.Name = "tabelaDeAntibióticosToolStripMenuItem";
            this.tabelaDeAntibióticosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.tabelaDeAntibióticosToolStripMenuItem.Text = "Tabela de Antibióticos";
            // 
            // panelControles
            // 
            this.panelControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControles.Controls.Add(this.splitter1);
            this.panelControles.Controls.Add(this.panelControlesLabel);
            this.panelControles.Controls.Add(this.panelFiltrosPesquisar);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControles.Location = new System.Drawing.Point(0, 24);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(800, 224);
            this.panelControles.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 151);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(798, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelControlesLabel
            // 
            this.panelControlesLabel.Controls.Add(this.labelTituloTab);
            this.panelControlesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlesLabel.Location = new System.Drawing.Point(0, 0);
            this.panelControlesLabel.Name = "panelControlesLabel";
            this.panelControlesLabel.Size = new System.Drawing.Size(798, 64);
            this.panelControlesLabel.TabIndex = 1;
            // 
            // labelTituloTab
            // 
            this.labelTituloTab.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelTituloTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTituloTab.Location = new System.Drawing.Point(0, 0);
            this.labelTituloTab.Name = "labelTituloTab";
            this.labelTituloTab.Size = new System.Drawing.Size(798, 64);
            this.labelTituloTab.TabIndex = 0;
            this.labelTituloTab.Text = "Filtrar Antibioticos";
            this.labelTituloTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTituloTab.SizeChanged += new System.EventHandler(this.labelTituloTab_SizeChanged);
            // 
            // panelFiltrosPesquisar
            // 
            this.panelFiltrosPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFiltrosPesquisar.Controls.Add(this.textBox1);
            this.panelFiltrosPesquisar.Controls.Add(this.labelPesquisarNome);
            this.panelFiltrosPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFiltrosPesquisar.Location = new System.Drawing.Point(0, 154);
            this.panelFiltrosPesquisar.Name = "panelFiltrosPesquisar";
            this.panelFiltrosPesquisar.Size = new System.Drawing.Size(798, 68);
            this.panelFiltrosPesquisar.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(602, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelPesquisarNome
            // 
            this.labelPesquisarNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPesquisarNome.Location = new System.Drawing.Point(548, 39);
            this.labelPesquisarNome.Name = "labelPesquisarNome";
            this.labelPesquisarNome.Size = new System.Drawing.Size(48, 24);
            this.labelPesquisarNome.TabIndex = 0;
            this.labelPesquisarNome.Text = "Nome";
            this.labelPesquisarNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPesquisarNome.SizeChanged += new System.EventHandler(this.label1Pesquisar_SizeChanged);
            // 
            // splitterControlesGrid
            // 
            this.splitterControlesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControlesGrid.Location = new System.Drawing.Point(0, 248);
            this.splitterControlesGrid.Name = "splitterControlesGrid";
            this.splitterControlesGrid.Size = new System.Drawing.Size(800, 3);
            this.splitterControlesGrid.TabIndex = 2;
            this.splitterControlesGrid.TabStop = false;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridAntibiotico);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 251);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(800, 199);
            this.panelGrid.TabIndex = 3;
            // 
            // gridAntibiotico
            // 
            this.gridAntibiotico.AllowUserToAddRows = false;
            this.gridAntibiotico.AllowUserToDeleteRows = false;
            this.gridAntibiotico.AutoGenerateColumns = false;
            this.gridAntibiotico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAntibiotico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoantibioticoDataGridViewTextBoxColumn,
            this.grampositivaDataGridViewTextBoxColumn,
            this.gramnegativaDataGridViewTextBoxColumn,
            this.morfologiaDataGridViewTextBoxColumn});
            this.gridAntibiotico.DataSource = this.antibioticoBindingSource;
            this.gridAntibiotico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAntibiotico.Location = new System.Drawing.Point(0, 0);
            this.gridAntibiotico.Name = "gridAntibiotico";
            this.gridAntibiotico.ReadOnly = true;
            this.gridAntibiotico.Size = new System.Drawing.Size(800, 199);
            this.gridAntibiotico.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // antibioticoBindingSource
            // 
            this.antibioticoBindingSource.DataMember = "antibiotico";
            this.antibioticoBindingSource.DataSource = this.database1DataSet;
            // 
            // antibioticoTableAdapter
            // 
            this.antibioticoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoantibioticoDataGridViewTextBoxColumn
            // 
            this.tipoantibioticoDataGridViewTextBoxColumn.DataPropertyName = "tipo_antibiotico";
            this.tipoantibioticoDataGridViewTextBoxColumn.HeaderText = "tipo_antibiotico";
            this.tipoantibioticoDataGridViewTextBoxColumn.Name = "tipoantibioticoDataGridViewTextBoxColumn";
            this.tipoantibioticoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grampositivaDataGridViewTextBoxColumn
            // 
            this.grampositivaDataGridViewTextBoxColumn.DataPropertyName = "gram_positiva";
            this.grampositivaDataGridViewTextBoxColumn.HeaderText = "gram_positiva";
            this.grampositivaDataGridViewTextBoxColumn.Name = "grampositivaDataGridViewTextBoxColumn";
            this.grampositivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gramnegativaDataGridViewTextBoxColumn
            // 
            this.gramnegativaDataGridViewTextBoxColumn.DataPropertyName = "gram_negativa";
            this.gramnegativaDataGridViewTextBoxColumn.HeaderText = "gram_negativa";
            this.gramnegativaDataGridViewTextBoxColumn.Name = "gramnegativaDataGridViewTextBoxColumn";
            this.gramnegativaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // morfologiaDataGridViewTextBoxColumn
            // 
            this.morfologiaDataGridViewTextBoxColumn.DataPropertyName = "morfologia";
            this.morfologiaDataGridViewTextBoxColumn.HeaderText = "morfologia";
            this.morfologiaDataGridViewTextBoxColumn.Name = "morfologiaDataGridViewTextBoxColumn";
            this.morfologiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.splitterControlesGrid);
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.menuStripTelas);
            this.MainMenuStrip = this.menuStripTelas;
            this.Name = "FormTabela";
            this.Text = "Pesquisador de Antibióticos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTabela_Load);
            this.menuStripTelas.ResumeLayout(false);
            this.menuStripTelas.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.panelControlesLabel.ResumeLayout(false);
            this.panelFiltrosPesquisar.ResumeLayout(false);
            this.panelFiltrosPesquisar.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAntibiotico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antibioticoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTelas;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeAntibióticosToolStripMenuItem;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Splitter splitterControlesGrid;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView gridAntibiotico;
        private System.Windows.Forms.Panel panelFiltrosPesquisar;
        private System.Windows.Forms.Panel panelControlesLabel;
        private System.Windows.Forms.Label labelTituloTab;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelPesquisarNome;
        private System.Windows.Forms.TextBox textBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource antibioticoBindingSource;
        private Database1DataSetTableAdapters.antibioticoTableAdapter antibioticoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoantibioticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grampositivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramnegativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn morfologiaDataGridViewTextBoxColumn;
    }
}