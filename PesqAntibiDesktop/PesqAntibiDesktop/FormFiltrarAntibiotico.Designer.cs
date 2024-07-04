
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            menuStripTelas = new System.Windows.Forms.MenuStrip();
            tabelaDeAntibióticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panelControles = new System.Windows.Forms.Panel();
            splitter1 = new System.Windows.Forms.Splitter();
            panelControlesLabel = new System.Windows.Forms.Panel();
            labelTituloTab = new System.Windows.Forms.Label();
            panelFiltrosPesquisar = new System.Windows.Forms.Panel();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            buttonPesquisar = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            labelPesquisarNome = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            labelTipoAntibiotico = new System.Windows.Forms.Label();
            checkBoxMacrolideos = new System.Windows.Forms.CheckBox();
            checkBoxPenicilinas = new System.Windows.Forms.CheckBox();
            checkBoxCefalosporinas = new System.Windows.Forms.CheckBox();
            checkBoxCarbapenêmicos = new System.Windows.Forms.CheckBox();
            checkBoxAminoglicosídeos = new System.Windows.Forms.CheckBox();
            checkBoxQuinolonas = new System.Windows.Forms.CheckBox();
            checkBoxAnfenicóis = new System.Windows.Forms.CheckBox();
            checkBoxSulfonamidas = new System.Windows.Forms.CheckBox();
            checkBoxGlicopeptídeos = new System.Windows.Forms.CheckBox();
            checkBoxNitroimidazólicos = new System.Windows.Forms.CheckBox();
            checkBoxLicosamidas = new System.Windows.Forms.CheckBox();
            checkBoxPolimixinas = new System.Windows.Forms.CheckBox();
            checkBoxOxazolidinona = new System.Windows.Forms.CheckBox();
            checkBoxGlicilciclina = new System.Windows.Forms.CheckBox();
            checkBoxAntituberculosos = new System.Windows.Forms.CheckBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            labelTipoBacteria = new System.Windows.Forms.Label();
            checkBoxGramPositiva = new System.Windows.Forms.CheckBox();
            checkBoxGramNegativa = new System.Windows.Forms.CheckBox();
            splitterControlesGrid = new System.Windows.Forms.Splitter();
            panelGrid = new System.Windows.Forms.Panel();
            gridAntibiotico = new System.Windows.Forms.DataGridView();
            antibioticoBindingSource = new System.Windows.Forms.BindingSource(components);
            menuStripTelas.SuspendLayout();
            panelControles.SuspendLayout();
            panelControlesLabel.SuspendLayout();
            panelFiltrosPesquisar.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAntibiotico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)antibioticoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStripTelas
            // 
            menuStripTelas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tabelaDeAntibióticosToolStripMenuItem });
            menuStripTelas.Location = new System.Drawing.Point(0, 0);
            menuStripTelas.Name = "menuStripTelas";
            menuStripTelas.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripTelas.Size = new System.Drawing.Size(1010, 24);
            menuStripTelas.TabIndex = 0;
            menuStripTelas.Text = "menuStrip1";
            // 
            // tabelaDeAntibióticosToolStripMenuItem
            // 
            tabelaDeAntibióticosToolStripMenuItem.Name = "tabelaDeAntibióticosToolStripMenuItem";
            tabelaDeAntibióticosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            tabelaDeAntibióticosToolStripMenuItem.Text = "Tabela de Antibióticos";
            // 
            // panelControles
            // 
            panelControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelControles.Controls.Add(splitter1);
            panelControles.Controls.Add(panelControlesLabel);
            panelControles.Controls.Add(panelFiltrosPesquisar);
            panelControles.Dock = System.Windows.Forms.DockStyle.Top;
            panelControles.Location = new System.Drawing.Point(0, 24);
            panelControles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControles.Name = "panelControles";
            panelControles.Size = new System.Drawing.Size(1010, 258);
            panelControles.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            splitter1.Location = new System.Drawing.Point(0, 125);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1008, 3);
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
            panelControlesLabel.Size = new System.Drawing.Size(1008, 74);
            panelControlesLabel.TabIndex = 1;
            // 
            // labelTituloTab
            // 
            labelTituloTab.BackColor = System.Drawing.SystemColors.ScrollBar;
            labelTituloTab.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTituloTab.Location = new System.Drawing.Point(0, 0);
            labelTituloTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTituloTab.Name = "labelTituloTab";
            labelTituloTab.Size = new System.Drawing.Size(1008, 74);
            labelTituloTab.TabIndex = 0;
            labelTituloTab.Text = "Filtrar Antibioticos";
            labelTituloTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTituloTab.SizeChanged += labelTituloTab_SizeChanged;
            // 
            // panelFiltrosPesquisar
            // 
            panelFiltrosPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panelFiltrosPesquisar.Controls.Add(flowLayoutPanel3);
            panelFiltrosPesquisar.Controls.Add(flowLayoutPanel2);
            panelFiltrosPesquisar.Controls.Add(flowLayoutPanel1);
            panelFiltrosPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelFiltrosPesquisar.Location = new System.Drawing.Point(0, 128);
            panelFiltrosPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelFiltrosPesquisar.Name = "panelFiltrosPesquisar";
            panelFiltrosPesquisar.Size = new System.Drawing.Size(1008, 128);
            panelFiltrosPesquisar.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(buttonPesquisar);
            flowLayoutPanel3.Controls.Add(textBox1);
            flowLayoutPanel3.Controls.Add(labelPesquisarNome);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new System.Drawing.Point(0, 97);
            flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(1008, 31);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new System.Drawing.Point(916, 3);
            buttonPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new System.Drawing.Size(88, 27);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(685, 7);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 12, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(215, 23);
            textBox1.TabIndex = 1;
            // 
            // labelPesquisarNome
            // 
            labelPesquisarNome.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelPesquisarNome.Location = new System.Drawing.Point(621, 5);
            labelPesquisarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPesquisarNome.Name = "labelPesquisarNome";
            labelPesquisarNome.Size = new System.Drawing.Size(56, 28);
            labelPesquisarNome.TabIndex = 0;
            labelPesquisarNome.Text = "Nome";
            labelPesquisarNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelPesquisarNome.SizeChanged += label1Pesquisar_SizeChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(labelTipoAntibiotico);
            flowLayoutPanel2.Controls.Add(checkBoxMacrolideos);
            flowLayoutPanel2.Controls.Add(checkBoxPenicilinas);
            flowLayoutPanel2.Controls.Add(checkBoxCefalosporinas);
            flowLayoutPanel2.Controls.Add(checkBoxCarbapenêmicos);
            flowLayoutPanel2.Controls.Add(checkBoxAminoglicosídeos);
            flowLayoutPanel2.Controls.Add(checkBoxQuinolonas);
            flowLayoutPanel2.Controls.Add(checkBoxAnfenicóis);
            flowLayoutPanel2.Controls.Add(checkBoxSulfonamidas);
            flowLayoutPanel2.Controls.Add(checkBoxGlicopeptídeos);
            flowLayoutPanel2.Controls.Add(checkBoxNitroimidazólicos);
            flowLayoutPanel2.Controls.Add(checkBoxLicosamidas);
            flowLayoutPanel2.Controls.Add(checkBoxPolimixinas);
            flowLayoutPanel2.Controls.Add(checkBoxOxazolidinona);
            flowLayoutPanel2.Controls.Add(checkBoxGlicilciclina);
            flowLayoutPanel2.Controls.Add(checkBoxAntituberculosos);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(1008, 93);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // labelTipoAntibiotico
            // 
            labelTipoAntibiotico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            labelTipoAntibiotico.Location = new System.Drawing.Point(4, 0);
            labelTipoAntibiotico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTipoAntibiotico.Name = "labelTipoAntibiotico";
            labelTipoAntibiotico.Size = new System.Drawing.Size(117, 27);
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
            checkBoxMacrolideos.Location = new System.Drawing.Point(129, 4);
            checkBoxMacrolideos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxMacrolideos.Name = "checkBoxMacrolideos";
            checkBoxMacrolideos.Size = new System.Drawing.Size(91, 19);
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
            checkBoxPenicilinas.Location = new System.Drawing.Point(228, 4);
            checkBoxPenicilinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxPenicilinas.Name = "checkBoxPenicilinas";
            checkBoxPenicilinas.Size = new System.Drawing.Size(82, 19);
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
            checkBoxCefalosporinas.Location = new System.Drawing.Point(318, 4);
            checkBoxCefalosporinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxCefalosporinas.Name = "checkBoxCefalosporinas";
            checkBoxCefalosporinas.Size = new System.Drawing.Size(104, 19);
            checkBoxCefalosporinas.TabIndex = 8;
            checkBoxCefalosporinas.Text = "Cefalosporinas";
            checkBoxCefalosporinas.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarbapenêmicos
            // 
            checkBoxCarbapenêmicos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxCarbapenêmicos.AutoSize = true;
            checkBoxCarbapenêmicos.Checked = true;
            checkBoxCarbapenêmicos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCarbapenêmicos.Location = new System.Drawing.Point(430, 4);
            checkBoxCarbapenêmicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxCarbapenêmicos.Name = "checkBoxCarbapenêmicos";
            checkBoxCarbapenêmicos.Size = new System.Drawing.Size(115, 19);
            checkBoxCarbapenêmicos.TabIndex = 9;
            checkBoxCarbapenêmicos.Text = "Carbapenêmicos";
            checkBoxCarbapenêmicos.UseVisualStyleBackColor = true;
            // 
            // checkBoxAminoglicosídeos
            // 
            checkBoxAminoglicosídeos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxAminoglicosídeos.AutoSize = true;
            checkBoxAminoglicosídeos.Checked = true;
            checkBoxAminoglicosídeos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAminoglicosídeos.Location = new System.Drawing.Point(553, 4);
            checkBoxAminoglicosídeos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxAminoglicosídeos.Name = "checkBoxAminoglicosídeos";
            checkBoxAminoglicosídeos.Size = new System.Drawing.Size(121, 19);
            checkBoxAminoglicosídeos.TabIndex = 10;
            checkBoxAminoglicosídeos.Text = "Aminoglicosídeos";
            checkBoxAminoglicosídeos.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuinolonas
            // 
            checkBoxQuinolonas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxQuinolonas.AutoSize = true;
            checkBoxQuinolonas.Checked = true;
            checkBoxQuinolonas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxQuinolonas.Location = new System.Drawing.Point(682, 4);
            checkBoxQuinolonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxQuinolonas.Name = "checkBoxQuinolonas";
            checkBoxQuinolonas.Size = new System.Drawing.Size(87, 19);
            checkBoxQuinolonas.TabIndex = 11;
            checkBoxQuinolonas.Text = "Quinolonas";
            checkBoxQuinolonas.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnfenicóis
            // 
            checkBoxAnfenicóis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxAnfenicóis.AutoSize = true;
            checkBoxAnfenicóis.Checked = true;
            checkBoxAnfenicóis.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxAnfenicóis.Location = new System.Drawing.Point(777, 4);
            checkBoxAnfenicóis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxAnfenicóis.Name = "checkBoxAnfenicóis";
            checkBoxAnfenicóis.Size = new System.Drawing.Size(82, 19);
            checkBoxAnfenicóis.TabIndex = 12;
            checkBoxAnfenicóis.Text = "Anfenicóis";
            checkBoxAnfenicóis.UseVisualStyleBackColor = true;
            // 
            // checkBoxSulfonamidas
            // 
            checkBoxSulfonamidas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxSulfonamidas.AutoSize = true;
            checkBoxSulfonamidas.Checked = true;
            checkBoxSulfonamidas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxSulfonamidas.Location = new System.Drawing.Point(867, 4);
            checkBoxSulfonamidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxSulfonamidas.Name = "checkBoxSulfonamidas";
            checkBoxSulfonamidas.Size = new System.Drawing.Size(98, 19);
            checkBoxSulfonamidas.TabIndex = 20;
            checkBoxSulfonamidas.Text = "Sulfonamidas";
            checkBoxSulfonamidas.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlicopeptídeos
            // 
            checkBoxGlicopeptídeos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxGlicopeptídeos.AutoSize = true;
            checkBoxGlicopeptídeos.Checked = true;
            checkBoxGlicopeptídeos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGlicopeptídeos.Location = new System.Drawing.Point(4, 30);
            checkBoxGlicopeptídeos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGlicopeptídeos.Name = "checkBoxGlicopeptídeos";
            checkBoxGlicopeptídeos.Size = new System.Drawing.Size(105, 19);
            checkBoxGlicopeptídeos.TabIndex = 13;
            checkBoxGlicopeptídeos.Text = "Glicopeptídeos";
            checkBoxGlicopeptídeos.UseVisualStyleBackColor = true;
            // 
            // checkBoxNitroimidazólicos
            // 
            checkBoxNitroimidazólicos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxNitroimidazólicos.AutoSize = true;
            checkBoxNitroimidazólicos.Checked = true;
            checkBoxNitroimidazólicos.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxNitroimidazólicos.Location = new System.Drawing.Point(117, 30);
            checkBoxNitroimidazólicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxNitroimidazólicos.Name = "checkBoxNitroimidazólicos";
            checkBoxNitroimidazólicos.Size = new System.Drawing.Size(119, 19);
            checkBoxNitroimidazólicos.TabIndex = 14;
            checkBoxNitroimidazólicos.Text = "Nitroimidazólicos";
            checkBoxNitroimidazólicos.UseVisualStyleBackColor = true;
            // 
            // checkBoxLicosamidas
            // 
            checkBoxLicosamidas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            checkBoxLicosamidas.AutoSize = true;
            checkBoxLicosamidas.Checked = true;
            checkBoxLicosamidas.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxLicosamidas.Location = new System.Drawing.Point(244, 30);
            checkBoxLicosamidas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxLicosamidas.Name = "checkBoxLicosamidas";
            checkBoxLicosamidas.Size = new System.Drawing.Size(91, 19);
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
            checkBoxPolimixinas.Location = new System.Drawing.Point(343, 30);
            checkBoxPolimixinas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxPolimixinas.Name = "checkBoxPolimixinas";
            checkBoxPolimixinas.Size = new System.Drawing.Size(87, 19);
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
            checkBoxOxazolidinona.Location = new System.Drawing.Point(438, 30);
            checkBoxOxazolidinona.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxOxazolidinona.Name = "checkBoxOxazolidinona";
            checkBoxOxazolidinona.Size = new System.Drawing.Size(102, 19);
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
            checkBoxGlicilciclina.Location = new System.Drawing.Point(548, 30);
            checkBoxGlicilciclina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGlicilciclina.Name = "checkBoxGlicilciclina";
            checkBoxGlicilciclina.Size = new System.Drawing.Size(86, 19);
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
            checkBoxAntituberculosos.Location = new System.Drawing.Point(642, 30);
            checkBoxAntituberculosos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxAntituberculosos.Name = "checkBoxAntituberculosos";
            checkBoxAntituberculosos.Size = new System.Drawing.Size(116, 19);
            checkBoxAntituberculosos.TabIndex = 19;
            checkBoxAntituberculosos.Text = "Antituberculosos";
            checkBoxAntituberculosos.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelTipoBacteria);
            flowLayoutPanel1.Controls.Add(checkBoxGramPositiva);
            flowLayoutPanel1.Controls.Add(checkBoxGramNegativa);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1008, 35);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // labelTipoBacteria
            // 
            labelTipoBacteria.Location = new System.Drawing.Point(4, 0);
            labelTipoBacteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTipoBacteria.Name = "labelTipoBacteria";
            labelTipoBacteria.Size = new System.Drawing.Size(117, 27);
            labelTipoBacteria.TabIndex = 2;
            labelTipoBacteria.Text = "Tipo de Bactéria";
            labelTipoBacteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTipoBacteria.SizeChanged += labelTipoBacteria_SizeChanged;
            // 
            // checkBoxGramPositiva
            // 
            checkBoxGramPositiva.AutoSize = true;
            checkBoxGramPositiva.Checked = true;
            checkBoxGramPositiva.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGramPositiva.Location = new System.Drawing.Point(129, 3);
            checkBoxGramPositiva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGramPositiva.Name = "checkBoxGramPositiva";
            checkBoxGramPositiva.Size = new System.Drawing.Size(99, 19);
            checkBoxGramPositiva.TabIndex = 3;
            checkBoxGramPositiva.Text = "Gram Positiva";
            checkBoxGramPositiva.UseVisualStyleBackColor = true;
            // 
            // checkBoxGramNegativa
            // 
            checkBoxGramNegativa.AutoSize = true;
            checkBoxGramNegativa.Checked = true;
            checkBoxGramNegativa.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxGramNegativa.Location = new System.Drawing.Point(236, 3);
            checkBoxGramNegativa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxGramNegativa.Name = "checkBoxGramNegativa";
            checkBoxGramNegativa.Size = new System.Drawing.Size(105, 19);
            checkBoxGramNegativa.TabIndex = 4;
            checkBoxGramNegativa.Text = "Gram Negativa";
            checkBoxGramNegativa.UseVisualStyleBackColor = true;
            // 
            // splitterControlesGrid
            // 
            splitterControlesGrid.Dock = System.Windows.Forms.DockStyle.Top;
            splitterControlesGrid.Location = new System.Drawing.Point(0, 282);
            splitterControlesGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitterControlesGrid.Name = "splitterControlesGrid";
            splitterControlesGrid.Size = new System.Drawing.Size(1010, 3);
            splitterControlesGrid.TabIndex = 2;
            splitterControlesGrid.TabStop = false;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(gridAntibiotico);
            panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            panelGrid.Location = new System.Drawing.Point(0, 285);
            panelGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new System.Drawing.Size(1010, 335);
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
            gridAntibiotico.Size = new System.Drawing.Size(1010, 335);
            gridAntibiotico.TabIndex = 0;
            // 
            // antibioticoBindingSource
            // 
            antibioticoBindingSource.DataMember = "antibiotico";
            // 
            // FormTabela
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1010, 620);
            Controls.Add(panelGrid);
            Controls.Add(splitterControlesGrid);
            Controls.Add(panelControles);
            Controls.Add(menuStripTelas);
            MainMenuStrip = menuStripTelas;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormTabela";
            Text = "Pesquisador de Antibióticos";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormTabela_Load;
            menuStripTelas.ResumeLayout(false);
            menuStripTelas.PerformLayout();
            panelControles.ResumeLayout(false);
            panelControlesLabel.ResumeLayout(false);
            panelFiltrosPesquisar.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label labelPesquisarNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource antibioticoBindingSource;
        private System.Windows.Forms.CheckBox checkBoxGramPositiva;
        private System.Windows.Forms.Label labelTipoBacteria;
        private System.Windows.Forms.CheckBox checkBoxGramNegativa;
        private System.Windows.Forms.CheckBox checkBoxMacrolideos;
        private System.Windows.Forms.Label labelTipoAntibiotico;
        private System.Windows.Forms.CheckBox checkBoxCarbapenêmicos;
        private System.Windows.Forms.CheckBox checkBoxCefalosporinas;
        private System.Windows.Forms.CheckBox checkBoxPenicilinas;
        private System.Windows.Forms.CheckBox checkBoxAminoglicosídeos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxQuinolonas;
        private System.Windows.Forms.CheckBox checkBoxAnfenicóis;
        private System.Windows.Forms.CheckBox checkBoxSulfonamidas;
        private System.Windows.Forms.CheckBox checkBoxGlicopeptídeos;
        private System.Windows.Forms.CheckBox checkBoxNitroimidazólicos;
        private System.Windows.Forms.CheckBox checkBoxLicosamidas;
        private System.Windows.Forms.CheckBox checkBoxPolimixinas;
        private System.Windows.Forms.CheckBox checkBoxOxazolidinona;
        private System.Windows.Forms.CheckBox checkBoxGlicilciclina;
        private System.Windows.Forms.CheckBox checkBoxAntituberculosos;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoantibioticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grampositivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramnegativaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn morfologiaDataGridViewTextBoxColumn;
    }
}