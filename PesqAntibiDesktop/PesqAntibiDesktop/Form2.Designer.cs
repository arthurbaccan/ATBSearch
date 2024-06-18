
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
            this.menuStripTelas = new System.Windows.Forms.MenuStrip();
            this.tabelaDeAntibióticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControles = new System.Windows.Forms.Panel();
            this.splitterControlesGrid = new System.Windows.Forms.Splitter();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.gridAntibiotico = new System.Windows.Forms.DataGridView();
            this.panelFiltrosPesquisar = new System.Windows.Forms.Panel();
            this.panelControlesLabel = new System.Windows.Forms.Panel();
            this.labelTituloTab = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1Pesquisar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStripTelas.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAntibiotico)).BeginInit();
            this.panelFiltrosPesquisar.SuspendLayout();
            this.panelControlesLabel.SuspendLayout();
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
            this.gridAntibiotico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAntibiotico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAntibiotico.Location = new System.Drawing.Point(0, 0);
            this.gridAntibiotico.Name = "gridAntibiotico";
            this.gridAntibiotico.ReadOnly = true;
            this.gridAntibiotico.Size = new System.Drawing.Size(800, 199);
            this.gridAntibiotico.TabIndex = 0;
            // 
            // panelFiltrosPesquisar
            // 
            this.panelFiltrosPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFiltrosPesquisar.Controls.Add(this.textBox1);
            this.panelFiltrosPesquisar.Controls.Add(this.label1Pesquisar);
            this.panelFiltrosPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFiltrosPesquisar.Location = new System.Drawing.Point(0, 194);
            this.panelFiltrosPesquisar.Name = "panelFiltrosPesquisar";
            this.panelFiltrosPesquisar.Size = new System.Drawing.Size(798, 28);
            this.panelFiltrosPesquisar.TabIndex = 0;
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 191);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(798, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1Pesquisar
            // 
            this.label1Pesquisar.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1Pesquisar.Location = new System.Drawing.Point(0, 0);
            this.label1Pesquisar.Name = "label1Pesquisar";
            this.label1Pesquisar.Size = new System.Drawing.Size(100, 28);
            this.label1Pesquisar.TabIndex = 0;
            this.label1Pesquisar.Text = "Pesquisar";
            this.label1Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1Pesquisar.SizeChanged += new System.EventHandler(this.label1Pesquisar_SizeChanged);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(100, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAntibiotico)).EndInit();
            this.panelFiltrosPesquisar.ResumeLayout(false);
            this.panelFiltrosPesquisar.PerformLayout();
            this.panelControlesLabel.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1Pesquisar;
        private System.Windows.Forms.TextBox textBox1;
    }
}