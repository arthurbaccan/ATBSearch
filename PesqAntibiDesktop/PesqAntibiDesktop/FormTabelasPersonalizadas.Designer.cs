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
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            buttonCriar = new System.Windows.Forms.Button();
            menuStripTelas.SuspendLayout();
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
            labelTituloTab.Location = new System.Drawing.Point(0, 24);
            labelTituloTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTituloTab.Name = "labelTituloTab";
            labelTituloTab.Size = new System.Drawing.Size(1070, 74);
            labelTituloTab.TabIndex = 2;
            labelTituloTab.Text = "Tabelas Disponíveis";
            labelTituloTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTituloTab.SizeChanged += labelTituloTab_SizeChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonCriar);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 98);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1070, 476);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonCriar
            // 
            buttonCriar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCriar.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonCriar.Location = new System.Drawing.Point(3, 3);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new System.Drawing.Size(146, 139);
            buttonCriar.TabIndex = 0;
            buttonCriar.Text = "Criar Tabela";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // FormTabelasPersonalizadas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 574);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelTituloTab);
            Controls.Add(menuStripTelas);
            Name = "FormTabelasPersonalizadas";
            Text = "Tabelas Personalizadas";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStripTelas.ResumeLayout(false);
            menuStripTelas.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTelas;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeAntibióticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasPersonalizadasToolStripMenuItem;
        private System.Windows.Forms.Label labelTituloTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCriar;
    }
}