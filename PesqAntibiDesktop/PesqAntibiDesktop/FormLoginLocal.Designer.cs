namespace PesqAntibiDesktop
{
    partial class FormLoginLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginLocal));
            panelLogin = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            buttonEntrar = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxSenha = new System.Windows.Forms.TextBox();
            textBoxUsuario = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            labelTituloTab = new System.Windows.Forms.Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            panelLogin.BackColor = System.Drawing.SystemColors.Control;
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(buttonEntrar);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(textBoxSenha);
            panelLogin.Controls.Add(textBoxUsuario);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new System.Drawing.Point(420, 164);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new System.Drawing.Size(260, 342);
            panelLogin.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Location = new System.Drawing.Point(83, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(90, 72);
            panel1.TabIndex = 6;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonEntrar.Location = new System.Drawing.Point(74, 307);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new System.Drawing.Size(99, 32);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(3, 219);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(3, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 21);
            label2.TabIndex = 3;
            label2.Text = "Usuário";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxSenha.Location = new System.Drawing.Point(5, 244);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new System.Drawing.Size(252, 27);
            textBoxSenha.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBoxUsuario.Location = new System.Drawing.Point(5, 175);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new System.Drawing.Size(252, 27);
            textBoxUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(89, 89);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // labelTituloTab
            // 
            labelTituloTab.BackColor = System.Drawing.SystemColors.Control;
            labelTituloTab.Dock = System.Windows.Forms.DockStyle.Top;
            labelTituloTab.Location = new System.Drawing.Point(0, 0);
            labelTituloTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTituloTab.Name = "labelTituloTab";
            labelTituloTab.Size = new System.Drawing.Size(1070, 79);
            labelTituloTab.TabIndex = 1;
            labelTituloTab.Text = "Pesquisador de Antibióticos";
            labelTituloTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTituloTab.SizeChanged += labelTituloTab_SizeChanged;
            // 
            // FormLoginLocal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 612);
            Controls.Add(labelTituloTab);
            Controls.Add(panelLogin);
            Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Name = "FormLoginLocal";
            Text = "Login";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FormLogin_Load;
            SizeChanged += FormLogin_SizeChanged;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTituloTab;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Panel panel1;
    }
}