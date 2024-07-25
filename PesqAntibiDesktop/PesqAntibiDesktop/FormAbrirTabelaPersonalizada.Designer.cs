
namespace PesqAntibiDesktop
{
    partial class FormAbrirTabelaPersonalizada
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            menuStripTelas = new System.Windows.Forms.MenuStrip();
            tabelaDeAntibióticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabelasPersonalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panelControles = new System.Windows.Forms.Panel();
            splitter1 = new System.Windows.Forms.Splitter();
            panelControlesLabel = new System.Windows.Forms.Panel();
            labelTituloTab = new System.Windows.Forms.Label();
            panelFiltrosPesquisar = new System.Windows.Forms.Panel();
            tableLayoutFiltros = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutTipoBacteria = new System.Windows.Forms.FlowLayoutPanel();
            labelTipoBacteria = new System.Windows.Forms.Label();
            checkBoxGramNegativa = new System.Windows.Forms.CheckBox();
            checkBoxGramPositiva = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            checkBoxCocos = new System.Windows.Forms.CheckBox();
            checkBoxBacilos = new System.Windows.Forms.CheckBox();
            flowLayoutTipoAntibiotico = new System.Windows.Forms.FlowLayoutPanel();
            labelTipoAntibiotico = new System.Windows.Forms.Label();
            checkBoxMacrolideos = new System.Windows.Forms.CheckBox();
            checkBoxPenicilinas = new System.Windows.Forms.CheckBox();
            checkBoxCefalosporinas = new System.Windows.Forms.CheckBox();
            checkBoxCarbapenemicos = new System.Windows.Forms.CheckBox();
            checkBoxAminoglicosideos = new System.Windows.Forms.CheckBox();
            checkBoxQuinolonas = new System.Windows.Forms.CheckBox();
            checkBoxAnfenicois = new System.Windows.Forms.CheckBox();
            checkBoxSulfonamidas = new System.Windows.Forms.CheckBox();
            checkBoxGlicopeptideos = new System.Windows.Forms.CheckBox();
            checkBoxNitroimidazolicos = new System.Windows.Forms.CheckBox();
            checkBoxLicosamidas = new System.Windows.Forms.CheckBox();
            checkBoxPolimixinas = new System.Windows.Forms.CheckBox();
            checkBoxOxazolidinona = new System.Windows.Forms.CheckBox();
            checkBoxGlicilciclina = new System.Windows.Forms.CheckBox();
            checkBoxAntituberculosos = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            buttonSelecionarTodosFiltros = new System.Windows.Forms.Button();
            buttonLimparFiltros = new System.Windows.Forms.Button();
            buttonPesquisar = new System.Windows.Forms.Button();
            textBoxNome = new System.Windows.Forms.TextBox();
            labelPesquisarNome = new System.Windows.Forms.Label();
            splitterControlesGrid = new System.Windows.Forms.Splitter();
            panelGrid = new System.Windows.Forms.Panel();
            gridAntibiotico = new System.Windows.Forms.DataGridView();
            antibioticoBindingSource = new System.Windows.Forms.BindingSource(components);
            menuStripTelas.SuspendLayout();
            panelControles.SuspendLayout();
            panelControlesLabel.SuspendLayout();
            panelFiltrosPesquisar.SuspendLayout();
            tableLayoutFiltros.SuspendLayout();
            flowLayoutTipoBacteria.SuspendLayout();
            flowLayoutTipoAntibiotico.SuspendLayout();
            panel1.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAntibiotico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)antibioticoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStripTelas
            // 
            menuStripTelas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tabelaDeAntibióticosToolStripMenuItem, tabelasPersonalizadasToolStripMenuItem });
            menuStripTelas.Location = new System.Drawing.Point(0, 0);
            menuStripTelas.Name = "menuStripTelas";
            menuStripTelas.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripTelas.Size = new System.Drawing.Size(1070, 24);
            menuStripTelas.TabIndex = 0;
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
            // panelControles
            // 
            panelControles.BackColor = System.Drawing.SystemColors.Control;
            panelControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelControles.Controls.Add(splitter1);
            panelControles.Controls.Add(panelControlesLabel);
            panelControles.Controls.Add(panelFiltrosPesquisar);
            panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            panelControles.Location = new System.Drawing.Point(0, 24);
            panelControles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControles.Name = "panelControles";
            panelControles.Size = new System.Drawing.Size(1070, 273);
            panelControles.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            splitter1.Location = new System.Drawing.Point(0, 140);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1068, 3);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelControlesLabel
            // 
            panelControlesLabel.Controls.Add(labelTituloTab);
            panelControlesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            panelControlesLabel.Location = new System.Drawing.Point(0, 0);
            panelControlesLabel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControlesLabel.Name = "panelControlesLabel";
            panelControlesLabel.Size = new System.Drawing.Size(1068, 74);
            panelControlesLabel.TabIndex = 1;
            // 
            // labelTituloTab
            // 
            labelTituloTab.BackColor = System.Drawing.SystemColors.ScrollBar;
            labelTituloTab.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTituloTab.Location = new System.Drawing.Point(0, 0);
            labelTituloTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTituloTab.Name = "labelTituloTab";
            labelTituloTab.Size = new System.Drawing.Size(1068, 74);
            labelTituloTab.TabIndex = 0;
            labelTituloTab.Text = "Tabela Personalizada";
            labelTituloTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTituloTab.SizeChanged += labelTituloTab_SizeChanged;
            // 
            // panelFiltrosPesquisar
            // 
            panelFiltrosPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panelFiltrosPesquisar.Controls.Add(tableLayoutFiltros);
            panelFiltrosPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelFiltrosPesquisar.Location = new System.Drawing.Point(0, 143);
            panelFiltrosPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelFiltrosPesquisar.Name = "panelFiltrosPesquisar";
            panelFiltrosPesquisar.Size = new System.Drawing.Size(1068, 128);
            panelFiltrosPesquisar.TabIndex = 0;
            // 
            // tableLayoutFiltros
            // 
            tableLayoutFiltros.AutoSize = true;
            tableLayoutFiltros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            tableLayoutFiltros.ColumnCount = 1;
            tableLayoutFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutFiltros.Controls.Add(flowLayoutTipoBacteria, 0, 0);
            tableLayoutFiltros.Controls.Add(flowLayoutTipoAntibiotico, 0, 1);
            tableLayoutFiltros.Controls.Add(panel1, 0, 2);
            tableLayoutFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutFiltros.Location = new System.Drawing.Point(0, 0);
            tableLayoutFiltros.Name = "tableLayoutFiltros";
            tableLayoutFiltros.RowCount = 3;
            tableLayoutFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            tableLayoutFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63F));
            tableLayoutFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            tableLayoutFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutFiltros.Size = new System.Drawing.Size(1068, 128);
            tableLayoutFiltros.TabIndex = 3;
            // 
            // flowLayoutTipoBacteria
            // 
            flowLayoutTipoBacteria.AutoScroll = true;
            flowLayoutTipoBacteria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            flowLayoutTipoBacteria.Controls.Add(labelTipoBacteria);
            flowLayoutTipoBacteria.Controls.Add(checkBoxGramNegativa);
            flowLayoutTipoBacteria.Controls.Add(checkBoxGramPositiva);
            flowLayoutTipoBacteria.Controls.Add(label1);
            flowLayoutTipoBacteria.Controls.Add(checkBoxCocos);
            flowLayoutTipoBacteria.Controls.Add(checkBoxBacilos);
            flowLayoutTipoBacteria.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutTipoBacteria.Location = new System.Drawing.Point(4, 3);
            flowLayoutTipoBacteria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutTipoBacteria.Name = "flowLayoutTipoBacteria";
            flowLayoutTipoBacteria.Size = new System.Drawing.Size(1060, 28);
            flowLayoutTipoBacteria.TabIndex = 11;
            // 
            // labelTipoBacteria
            // 
            labelTipoBacteria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelTipoBacteria.AutoSize = true;
            labelTipoBacteria.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            labelTipoBacteria.Location = new System.Drawing.Point(4, 5);
            labelTipoBacteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTipoBacteria.Name = "labelTipoBacteria";
            labelTipoBacteria.Size = new System.Drawing.Size(118, 20);
            labelTipoBacteria.TabIndex = 2;
            labelTipoBacteria.Text = "Tipo de Bactéria";
            labelTipoBacteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxGramNegativa
            // 
            checkBoxGramNegativa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxGramNegativa.AutoSize = true;
            checkBoxGramNegativa.Checked = true;
            checkBoxGramNegativa.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGramNegativa.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxGramNegativa.Location = new System.Drawing.Point(130, 3);
            checkBoxGramNegativa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGramNegativa.Name = "checkBoxGramNegativa";
            checkBoxGramNegativa.Size = new System.Drawing.Size(128, 24);
            checkBoxGramNegativa.TabIndex = 4;
            checkBoxGramNegativa.Text = "Gram Negativa";
            checkBoxGramNegativa.UseVisualStyleBackColor = true;
            // 
            // checkBoxGramPositiva
            // 
            checkBoxGramPositiva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxGramPositiva.AutoSize = true;
            checkBoxGramPositiva.Checked = true;
            checkBoxGramPositiva.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGramPositiva.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxGramPositiva.Location = new System.Drawing.Point(266, 3);
            checkBoxGramPositiva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGramPositiva.Name = "checkBoxGramPositiva";
            checkBoxGramPositiva.Size = new System.Drawing.Size(118, 24);
            checkBoxGramPositiva.TabIndex = 3;
            checkBoxGramPositiva.Text = "Gram Positiva";
            checkBoxGramPositiva.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            label1.Location = new System.Drawing.Point(392, 5);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 20);
            label1.TabIndex = 8;
            label1.Text = "Morfologia Bacteriana";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxCocos
            // 
            checkBoxCocos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxCocos.AutoSize = true;
            checkBoxCocos.Checked = true;
            checkBoxCocos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCocos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxCocos.Location = new System.Drawing.Point(558, 3);
            checkBoxCocos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxCocos.Name = "checkBoxCocos";
            checkBoxCocos.Size = new System.Drawing.Size(68, 24);
            checkBoxCocos.TabIndex = 10;
            checkBoxCocos.Text = "Cocos";
            checkBoxCocos.UseVisualStyleBackColor = true;
            // 
            // checkBoxBacilos
            // 
            checkBoxBacilos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxBacilos.AutoSize = true;
            checkBoxBacilos.Checked = true;
            checkBoxBacilos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxBacilos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxBacilos.Location = new System.Drawing.Point(634, 3);
            checkBoxBacilos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxBacilos.Name = "checkBoxBacilos";
            checkBoxBacilos.Size = new System.Drawing.Size(75, 24);
            checkBoxBacilos.TabIndex = 9;
            checkBoxBacilos.Text = "Bacilos";
            checkBoxBacilos.UseVisualStyleBackColor = true;
            // 
            // flowLayoutTipoAntibiotico
            // 
            flowLayoutTipoAntibiotico.AutoScroll = true;
            flowLayoutTipoAntibiotico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            flowLayoutTipoAntibiotico.Controls.Add(labelTipoAntibiotico);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxMacrolideos);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxPenicilinas);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxCefalosporinas);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxCarbapenemicos);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxAminoglicosideos);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxQuinolonas);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxAnfenicois);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxSulfonamidas);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxGlicopeptideos);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxNitroimidazolicos);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxLicosamidas);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxPolimixinas);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxOxazolidinona);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxGlicilciclina);
            flowLayoutTipoAntibiotico.Controls.Add(checkBoxAntituberculosos);
            flowLayoutTipoAntibiotico.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutTipoAntibiotico.Location = new System.Drawing.Point(4, 37);
            flowLayoutTipoAntibiotico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutTipoAntibiotico.Name = "flowLayoutTipoAntibiotico";
            flowLayoutTipoAntibiotico.Size = new System.Drawing.Size(1060, 51);
            flowLayoutTipoAntibiotico.TabIndex = 12;
            // 
            // labelTipoAntibiotico
            // 
            labelTipoAntibiotico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelTipoAntibiotico.AutoSize = true;
            labelTipoAntibiotico.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            labelTipoAntibiotico.Location = new System.Drawing.Point(4, 5);
            labelTipoAntibiotico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTipoAntibiotico.Name = "labelTipoAntibiotico";
            labelTipoAntibiotico.Size = new System.Drawing.Size(138, 20);
            labelTipoAntibiotico.TabIndex = 5;
            labelTipoAntibiotico.Text = "Tipo de Antibiótico";
            labelTipoAntibiotico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxMacrolideos
            // 
            checkBoxMacrolideos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxMacrolideos.AutoSize = true;
            checkBoxMacrolideos.Checked = true;
            checkBoxMacrolideos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxMacrolideos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxMacrolideos.Location = new System.Drawing.Point(150, 3);
            checkBoxMacrolideos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxMacrolideos.Name = "checkBoxMacrolideos";
            checkBoxMacrolideos.Size = new System.Drawing.Size(110, 24);
            checkBoxMacrolideos.TabIndex = 6;
            checkBoxMacrolideos.Text = "Macrolídeos";
            checkBoxMacrolideos.UseVisualStyleBackColor = true;
            // 
            // checkBoxPenicilinas
            // 
            checkBoxPenicilinas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxPenicilinas.AutoSize = true;
            checkBoxPenicilinas.Checked = true;
            checkBoxPenicilinas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxPenicilinas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxPenicilinas.Location = new System.Drawing.Point(268, 3);
            checkBoxPenicilinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxPenicilinas.Name = "checkBoxPenicilinas";
            checkBoxPenicilinas.Size = new System.Drawing.Size(96, 24);
            checkBoxPenicilinas.TabIndex = 7;
            checkBoxPenicilinas.Text = "Penicilinas";
            checkBoxPenicilinas.UseVisualStyleBackColor = true;
            // 
            // checkBoxCefalosporinas
            // 
            checkBoxCefalosporinas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxCefalosporinas.AutoSize = true;
            checkBoxCefalosporinas.Checked = true;
            checkBoxCefalosporinas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCefalosporinas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxCefalosporinas.Location = new System.Drawing.Point(372, 3);
            checkBoxCefalosporinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxCefalosporinas.Name = "checkBoxCefalosporinas";
            checkBoxCefalosporinas.Size = new System.Drawing.Size(126, 24);
            checkBoxCefalosporinas.TabIndex = 8;
            checkBoxCefalosporinas.Text = "Cefalosporinas";
            checkBoxCefalosporinas.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarbapenemicos
            // 
            checkBoxCarbapenemicos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxCarbapenemicos.AutoSize = true;
            checkBoxCarbapenemicos.Checked = true;
            checkBoxCarbapenemicos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCarbapenemicos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxCarbapenemicos.Location = new System.Drawing.Point(506, 3);
            checkBoxCarbapenemicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxCarbapenemicos.Name = "checkBoxCarbapenemicos";
            checkBoxCarbapenemicos.Size = new System.Drawing.Size(139, 24);
            checkBoxCarbapenemicos.TabIndex = 9;
            checkBoxCarbapenemicos.Text = "Carbapenêmicos";
            checkBoxCarbapenemicos.UseVisualStyleBackColor = true;
            // 
            // checkBoxAminoglicosideos
            // 
            checkBoxAminoglicosideos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxAminoglicosideos.AutoSize = true;
            checkBoxAminoglicosideos.Checked = true;
            checkBoxAminoglicosideos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAminoglicosideos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxAminoglicosideos.Location = new System.Drawing.Point(653, 3);
            checkBoxAminoglicosideos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxAminoglicosideos.Name = "checkBoxAminoglicosideos";
            checkBoxAminoglicosideos.Size = new System.Drawing.Size(147, 24);
            checkBoxAminoglicosideos.TabIndex = 10;
            checkBoxAminoglicosideos.Text = "Aminoglicosídeos";
            checkBoxAminoglicosideos.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuinolonas
            // 
            checkBoxQuinolonas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxQuinolonas.AutoSize = true;
            checkBoxQuinolonas.Checked = true;
            checkBoxQuinolonas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxQuinolonas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxQuinolonas.Location = new System.Drawing.Point(808, 3);
            checkBoxQuinolonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxQuinolonas.Name = "checkBoxQuinolonas";
            checkBoxQuinolonas.Size = new System.Drawing.Size(103, 24);
            checkBoxQuinolonas.TabIndex = 11;
            checkBoxQuinolonas.Text = "Quinolonas";
            checkBoxQuinolonas.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnfenicois
            // 
            checkBoxAnfenicois.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxAnfenicois.AutoSize = true;
            checkBoxAnfenicois.Checked = true;
            checkBoxAnfenicois.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAnfenicois.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxAnfenicois.Location = new System.Drawing.Point(919, 3);
            checkBoxAnfenicois.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxAnfenicois.Name = "checkBoxAnfenicois";
            checkBoxAnfenicois.Size = new System.Drawing.Size(97, 24);
            checkBoxAnfenicois.TabIndex = 12;
            checkBoxAnfenicois.Text = "Anfenicóis";
            checkBoxAnfenicois.UseVisualStyleBackColor = true;
            // 
            // checkBoxSulfonamidas
            // 
            checkBoxSulfonamidas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxSulfonamidas.AutoSize = true;
            checkBoxSulfonamidas.Checked = true;
            checkBoxSulfonamidas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxSulfonamidas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxSulfonamidas.Location = new System.Drawing.Point(4, 33);
            checkBoxSulfonamidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxSulfonamidas.Name = "checkBoxSulfonamidas";
            checkBoxSulfonamidas.Size = new System.Drawing.Size(118, 24);
            checkBoxSulfonamidas.TabIndex = 20;
            checkBoxSulfonamidas.Text = "Sulfonamidas";
            checkBoxSulfonamidas.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlicopeptideos
            // 
            checkBoxGlicopeptideos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxGlicopeptideos.AutoSize = true;
            checkBoxGlicopeptideos.Checked = true;
            checkBoxGlicopeptideos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGlicopeptideos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxGlicopeptideos.Location = new System.Drawing.Point(130, 33);
            checkBoxGlicopeptideos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGlicopeptideos.Name = "checkBoxGlicopeptideos";
            checkBoxGlicopeptideos.Size = new System.Drawing.Size(129, 24);
            checkBoxGlicopeptideos.TabIndex = 13;
            checkBoxGlicopeptideos.Text = "Glicopeptídeos";
            checkBoxGlicopeptideos.UseVisualStyleBackColor = true;
            // 
            // checkBoxNitroimidazolicos
            // 
            checkBoxNitroimidazolicos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxNitroimidazolicos.AutoSize = true;
            checkBoxNitroimidazolicos.Checked = true;
            checkBoxNitroimidazolicos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxNitroimidazolicos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxNitroimidazolicos.Location = new System.Drawing.Point(267, 33);
            checkBoxNitroimidazolicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxNitroimidazolicos.Name = "checkBoxNitroimidazolicos";
            checkBoxNitroimidazolicos.Size = new System.Drawing.Size(146, 24);
            checkBoxNitroimidazolicos.TabIndex = 14;
            checkBoxNitroimidazolicos.Text = "Nitroimidazólicos";
            checkBoxNitroimidazolicos.UseVisualStyleBackColor = true;
            // 
            // checkBoxLicosamidas
            // 
            checkBoxLicosamidas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxLicosamidas.AutoSize = true;
            checkBoxLicosamidas.Checked = true;
            checkBoxLicosamidas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxLicosamidas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxLicosamidas.Location = new System.Drawing.Point(421, 33);
            checkBoxLicosamidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxLicosamidas.Name = "checkBoxLicosamidas";
            checkBoxLicosamidas.Size = new System.Drawing.Size(109, 24);
            checkBoxLicosamidas.TabIndex = 15;
            checkBoxLicosamidas.Text = "Licosamidas";
            checkBoxLicosamidas.UseVisualStyleBackColor = true;
            // 
            // checkBoxPolimixinas
            // 
            checkBoxPolimixinas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxPolimixinas.AutoSize = true;
            checkBoxPolimixinas.Checked = true;
            checkBoxPolimixinas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxPolimixinas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxPolimixinas.Location = new System.Drawing.Point(538, 33);
            checkBoxPolimixinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxPolimixinas.Name = "checkBoxPolimixinas";
            checkBoxPolimixinas.Size = new System.Drawing.Size(102, 24);
            checkBoxPolimixinas.TabIndex = 16;
            checkBoxPolimixinas.Text = "Polimixinas";
            checkBoxPolimixinas.UseVisualStyleBackColor = true;
            // 
            // checkBoxOxazolidinona
            // 
            checkBoxOxazolidinona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxOxazolidinona.AutoSize = true;
            checkBoxOxazolidinona.Checked = true;
            checkBoxOxazolidinona.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxOxazolidinona.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxOxazolidinona.Location = new System.Drawing.Point(648, 33);
            checkBoxOxazolidinona.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxOxazolidinona.Name = "checkBoxOxazolidinona";
            checkBoxOxazolidinona.Size = new System.Drawing.Size(124, 24);
            checkBoxOxazolidinona.TabIndex = 17;
            checkBoxOxazolidinona.Text = "Oxazolidinona";
            checkBoxOxazolidinona.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlicilciclina
            // 
            checkBoxGlicilciclina.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxGlicilciclina.AutoSize = true;
            checkBoxGlicilciclina.Checked = true;
            checkBoxGlicilciclina.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGlicilciclina.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxGlicilciclina.Location = new System.Drawing.Point(780, 33);
            checkBoxGlicilciclina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGlicilciclina.Name = "checkBoxGlicilciclina";
            checkBoxGlicilciclina.Size = new System.Drawing.Size(103, 24);
            checkBoxGlicilciclina.TabIndex = 18;
            checkBoxGlicilciclina.Text = "Glicilciclina";
            checkBoxGlicilciclina.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntituberculosos
            // 
            checkBoxAntituberculosos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxAntituberculosos.AutoSize = true;
            checkBoxAntituberculosos.Checked = true;
            checkBoxAntituberculosos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAntituberculosos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            checkBoxAntituberculosos.Location = new System.Drawing.Point(891, 33);
            checkBoxAntituberculosos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxAntituberculosos.Name = "checkBoxAntituberculosos";
            checkBoxAntituberculosos.Size = new System.Drawing.Size(139, 24);
            checkBoxAntituberculosos.TabIndex = 19;
            checkBoxAntituberculosos.Text = "Antituberculosos";
            checkBoxAntituberculosos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSelecionarTodosFiltros);
            panel1.Controls.Add(buttonLimparFiltros);
            panel1.Controls.Add(buttonPesquisar);
            panel1.Controls.Add(textBoxNome);
            panel1.Controls.Add(labelPesquisarNome);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 94);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1062, 31);
            panel1.TabIndex = 13;
            // 
            // buttonSelecionarTodosFiltros
            // 
            buttonSelecionarTodosFiltros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            buttonSelecionarTodosFiltros.AutoSize = true;
            buttonSelecionarTodosFiltros.Location = new System.Drawing.Point(98, 3);
            buttonSelecionarTodosFiltros.Name = "buttonSelecionarTodosFiltros";
            buttonSelecionarTodosFiltros.Size = new System.Drawing.Size(106, 25);
            buttonSelecionarTodosFiltros.TabIndex = 10;
            buttonSelecionarTodosFiltros.Text = "Selecionar Filtros";
            buttonSelecionarTodosFiltros.UseVisualStyleBackColor = true;
            buttonSelecionarTodosFiltros.Click += buttonSelecionarTodosFiltros_Click;
            // 
            // buttonLimparFiltros
            // 
            buttonLimparFiltros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            buttonLimparFiltros.AutoSize = true;
            buttonLimparFiltros.Location = new System.Drawing.Point(3, 3);
            buttonLimparFiltros.Name = "buttonLimparFiltros";
            buttonLimparFiltros.Size = new System.Drawing.Size(89, 25);
            buttonLimparFiltros.TabIndex = 9;
            buttonLimparFiltros.Text = "Limpar Filtros";
            buttonLimparFiltros.UseVisualStyleBackColor = true;
            buttonLimparFiltros.Click += buttonLimparFiltros_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            buttonPesquisar.Location = new System.Drawing.Point(965, 2);
            buttonPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new System.Drawing.Size(88, 27);
            buttonPesquisar.TabIndex = 6;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            textBoxNome.Location = new System.Drawing.Point(734, 5);
            textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 12, 3);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new System.Drawing.Size(215, 23);
            textBoxNome.TabIndex = 5;
            // 
            // labelPesquisarNome
            // 
            labelPesquisarNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelPesquisarNome.Location = new System.Drawing.Point(670, 1);
            labelPesquisarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPesquisarNome.Name = "labelPesquisarNome";
            labelPesquisarNome.Size = new System.Drawing.Size(56, 28);
            labelPesquisarNome.TabIndex = 4;
            labelPesquisarNome.Text = "Nome";
            labelPesquisarNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitterControlesGrid
            // 
            splitterControlesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            splitterControlesGrid.Location = new System.Drawing.Point(0, 297);
            splitterControlesGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitterControlesGrid.Name = "splitterControlesGrid";
            splitterControlesGrid.Size = new System.Drawing.Size(1070, 3);
            splitterControlesGrid.TabIndex = 2;
            splitterControlesGrid.TabStop = false;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(gridAntibiotico);
            panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGrid.Location = new System.Drawing.Point(0, 300);
            panelGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new System.Drawing.Size(1070, 274);
            panelGrid.TabIndex = 3;
            // 
            // gridAntibiotico
            // 
            gridAntibiotico.AllowUserToAddRows = false;
            gridAntibiotico.AllowUserToDeleteRows = false;
            gridAntibiotico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            gridAntibiotico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            gridAntibiotico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridAntibiotico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            gridAntibiotico.DefaultCellStyle = dataGridViewCellStyle2;
            gridAntibiotico.Dock = System.Windows.Forms.DockStyle.Fill;
            gridAntibiotico.Location = new System.Drawing.Point(0, 0);
            gridAntibiotico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gridAntibiotico.Name = "gridAntibiotico";
            gridAntibiotico.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            gridAntibiotico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridAntibiotico.Size = new System.Drawing.Size(1070, 274);
            gridAntibiotico.TabIndex = 0;
            // 
            // antibioticoBindingSource
            // 
            antibioticoBindingSource.DataMember = "antibiotico";
            // 
            // FormAbrirTabelaPersonalizada
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 574);
            Controls.Add(panelGrid);
            Controls.Add(splitterControlesGrid);
            Controls.Add(panelControles);
            Controls.Add(menuStripTelas);
            MainMenuStrip = menuStripTelas;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormAbrirTabelaPersonalizada";
            Text = "Pesquisador de Antibióticos";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormTabela_Load;
            menuStripTelas.ResumeLayout(false);
            menuStripTelas.PerformLayout();
            panelControles.ResumeLayout(false);
            panelControlesLabel.ResumeLayout(false);
            panelFiltrosPesquisar.ResumeLayout(false);
            panelFiltrosPesquisar.PerformLayout();
            tableLayoutFiltros.ResumeLayout(false);
            flowLayoutTipoBacteria.ResumeLayout(false);
            flowLayoutTipoBacteria.PerformLayout();
            flowLayoutTipoAntibiotico.ResumeLayout(false);
            flowLayoutTipoAntibiotico.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridAntibiotico).EndInit();
            ((System.ComponentModel.ISupportInitialize)antibioticoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.BindingSource antibioticoBindingSource;
        private System.Windows.Forms.CheckBox checkBoxGramPositiva;
        private System.Windows.Forms.Label labelTipoBacteria;
        private System.Windows.Forms.CheckBox checkBoxGramNegativa;
        private System.Windows.Forms.CheckBox checkBoxMacrolideos;
        private System.Windows.Forms.Label labelTipoAntibiotico;
        private System.Windows.Forms.CheckBox checkBoxCarbapenemicos;
        private System.Windows.Forms.CheckBox checkBoxCefalosporinas;
        private System.Windows.Forms.CheckBox checkBoxPenicilinas;
        private System.Windows.Forms.CheckBox checkBoxAminoglicosideos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTipoAntibiotico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTipoBacteria;
        private System.Windows.Forms.CheckBox checkBoxQuinolonas;
        private System.Windows.Forms.CheckBox checkBoxAnfenicois;
        private System.Windows.Forms.CheckBox checkBoxSulfonamidas;
        private System.Windows.Forms.CheckBox checkBoxGlicopeptideos;
        private System.Windows.Forms.CheckBox checkBoxNitroimidazolicos;
        private System.Windows.Forms.CheckBox checkBoxLicosamidas;
        private System.Windows.Forms.CheckBox checkBoxPolimixinas;
        private System.Windows.Forms.CheckBox checkBoxOxazolidinona;
        private System.Windows.Forms.CheckBox checkBoxGlicilciclina;
        private System.Windows.Forms.CheckBox checkBoxAntituberculosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoantibioticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grampositivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramnegativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn morfologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFiltros;
        private System.Windows.Forms.ToolStripMenuItem tabelasPersonalizadasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelPesquisarNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCocos;
        private System.Windows.Forms.CheckBox checkBoxBacilos;
        private System.Windows.Forms.Button buttonSelecionarTodosFiltros;
        private System.Windows.Forms.Button buttonLimparFiltros;
    }
}