namespace PesqAntibiDesktop
{
    partial class FormTabelasPersonalizadas
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
            menuStripTelas = new System.Windows.Forms.MenuStrip();
            tabelaDeAntibióticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabelasPersonalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            labelTituloTab = new System.Windows.Forms.Label();
            flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            buttonCriar = new System.Windows.Forms.Button();
            panelTopWindow = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonRecarregar = new System.Windows.Forms.Button();
            buttonSelecionarTabelas = new System.Windows.Forms.Button();
            buttonCancelarSelecao = new System.Windows.Forms.Button();
            buttonDeletarTabela = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            menuStripTelas.SuspendLayout();
            flowLayoutPanelTables.SuspendLayout();
            panelTopWindow.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTelas
            // 
            menuStripTelas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tabelaDeAntibióticosToolStripMenuItem, tabelasPersonalizadasToolStripMenuItem });
            menuStripTelas.Location = new System.Drawing.Point(0, 0);
            menuStripTelas.Name = "menuStripTelas";
            menuStripTelas.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripTelas.Size = new System.Drawing.Size(1070, 24);
            menuStripTelas.TabIndex = 1;
            menuStripTelas.Text = "menuStrip1";
            // 
            // tabelaDeAntibióticosToolStripMenuItem
            // 
            tabelaDeAntibióticosToolStripMenuItem.Name = "tabelaDeAntibióticosToolStripMenuItem";
            tabelaDeAntibióticosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            tabelaDeAntibióticosToolStripMenuItem.Text = "Tabela de Antibióticos";
            tabelaDeAntibióticosToolStripMenuItem.Click += tabelaDeAntibióticosToolStripMenuItem_Click;
            // 
            // tabelasPersonalizadasToolStripMenuItem
            // 
            tabelasPersonalizadasToolStripMenuItem.Name = "tabelasPersonalizadasToolStripMenuItem";
            tabelasPersonalizadasToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            tabelasPersonalizadasToolStripMenuItem.Text = "Tabelas Personalizadas";
            tabelasPersonalizadasToolStripMenuItem.Click += tabelasPersonalizadasToolStripMenuItem_Click;
            // 
            // labelTituloTab
            // 
            labelTituloTab.BackColor = System.Drawing.SystemColors.ScrollBar;
            labelTituloTab.Dock = System.Windows.Forms.DockStyle.Top;
            labelTituloTab.Location = new System.Drawing.Point(0, 0);
            labelTituloTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTituloTab.Name = "labelTituloTab";
            labelTituloTab.Size = new System.Drawing.Size(1070, 78);
            labelTituloTab.TabIndex = 2;
            labelTituloTab.Text = "Tabelas Disponíveis";
            labelTituloTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTituloTab.SizeChanged += labelTituloTab_SizeChanged;
            // 
            // flowLayoutPanelTables
            // 
            flowLayoutPanelTables.AutoScroll = true;
            flowLayoutPanelTables.Controls.Add(buttonCriar);
            flowLayoutPanelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanelTables.Location = new System.Drawing.Point(0, 193);
            flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            flowLayoutPanelTables.Size = new System.Drawing.Size(1070, 381);
            flowLayoutPanelTables.TabIndex = 3;
            // 
            // buttonCriar
            // 
            buttonCriar.BackColor = System.Drawing.SystemColors.Control;
            buttonCriar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            buttonCriar.FlatAppearance.BorderSize = 0;
            buttonCriar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonCriar.ForeColor = System.Drawing.Color.SteelBlue;
            buttonCriar.Location = new System.Drawing.Point(3, 3);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new System.Drawing.Size(146, 139);
            buttonCriar.TabIndex = 0;
            buttonCriar.Text = "Criar Tabela";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // panelTopWindow
            // 
            panelTopWindow.Controls.Add(flowLayoutPanel1);
            panelTopWindow.Controls.Add(panel3);
            panelTopWindow.Controls.Add(panel2);
            panelTopWindow.Controls.Add(labelTituloTab);
            panelTopWindow.Dock = System.Windows.Forms.DockStyle.Top;
            panelTopWindow.Location = new System.Drawing.Point(0, 24);
            panelTopWindow.Name = "panelTopWindow";
            panelTopWindow.Size = new System.Drawing.Size(1070, 169);
            panelTopWindow.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(buttonRecarregar);
            flowLayoutPanel1.Controls.Add(buttonSelecionarTabelas);
            flowLayoutPanel1.Controls.Add(buttonCancelarSelecao);
            flowLayoutPanel1.Controls.Add(buttonDeletarTabela);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1070, 43);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonRecarregar
            // 
            buttonRecarregar.AutoSize = true;
            buttonRecarregar.Location = new System.Drawing.Point(3, 3);
            buttonRecarregar.Name = "buttonRecarregar";
            buttonRecarregar.Size = new System.Drawing.Size(124, 25);
            buttonRecarregar.TabIndex = 0;
            buttonRecarregar.Text = "Regarregar Tabelas";
            buttonRecarregar.UseVisualStyleBackColor = true;
            buttonRecarregar.Click += buttonRecarregar_Click;
            // 
            // buttonSelecionarTabelas
            // 
            buttonSelecionarTabelas.AutoSize = true;
            buttonSelecionarTabelas.Location = new System.Drawing.Point(133, 3);
            buttonSelecionarTabelas.Name = "buttonSelecionarTabelas";
            buttonSelecionarTabelas.Size = new System.Drawing.Size(112, 25);
            buttonSelecionarTabelas.TabIndex = 2;
            buttonSelecionarTabelas.Text = "Selecionar Tabelas";
            buttonSelecionarTabelas.UseVisualStyleBackColor = true;
            buttonSelecionarTabelas.Click += buttonSelecionarTabelas_Click;
            // 
            // buttonCancelarSelecao
            // 
            buttonCancelarSelecao.AutoSize = true;
            buttonCancelarSelecao.BackColor = System.Drawing.SystemColors.Control;
            buttonCancelarSelecao.Location = new System.Drawing.Point(251, 3);
            buttonCancelarSelecao.Name = "buttonCancelarSelecao";
            buttonCancelarSelecao.Size = new System.Drawing.Size(106, 25);
            buttonCancelarSelecao.TabIndex = 3;
            buttonCancelarSelecao.Text = "Cancelar Seleção";
            buttonCancelarSelecao.UseVisualStyleBackColor = false;
            buttonCancelarSelecao.Click += buttonCancelarSelecao_Click;
            // 
            // buttonDeletarTabela
            // 
            buttonDeletarTabela.AutoSize = true;
            buttonDeletarTabela.BackColor = System.Drawing.SystemColors.Control;
            buttonDeletarTabela.Location = new System.Drawing.Point(363, 3);
            buttonDeletarTabela.Name = "buttonDeletarTabela";
            buttonDeletarTabela.Size = new System.Drawing.Size(95, 25);
            buttonDeletarTabela.TabIndex = 1;
            buttonDeletarTabela.Text = "Deletar Tabelas";
            buttonDeletarTabela.UseVisualStyleBackColor = false;
            buttonDeletarTabela.Click += buttonDeletarTabela_Click;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1070, 33);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 154);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1070, 15);
            panel2.TabIndex = 4;
            // 
            // FormTabelasPersonalizadas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 574);
            Controls.Add(flowLayoutPanelTables);
            Controls.Add(panelTopWindow);
            Controls.Add(menuStripTelas);
            Name = "FormTabelasPersonalizadas";
            Text = "Tabelas Personalizadas";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormTabelasPersonalizadas_Load;
            menuStripTelas.ResumeLayout(false);
            menuStripTelas.PerformLayout();
            flowLayoutPanelTables.ResumeLayout(false);
            panelTopWindow.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTelas;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeAntibióticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasPersonalizadasToolStripMenuItem;
        private System.Windows.Forms.Label labelTituloTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
        private System.Windows.Forms.Button buttonCriar;
        private System.Windows.Forms.Panel panelTopWindow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonRecarregar;
        private System.Windows.Forms.Button buttonDeletarTabela;
        private System.Windows.Forms.Button buttonSelecionarTabelas;
        private System.Windows.Forms.Button buttonCancelarSelecao;
    }
}