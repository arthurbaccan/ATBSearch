namespace PesqAntibiDesktop
{
    partial class FormNomeTabela
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
            textBoxNomeTabela = new System.Windows.Forms.TextBox();
            labelNomeTabela = new System.Windows.Forms.Label();
            buttonConfirmar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxNomeTabela
            // 
            textBoxNomeTabela.Location = new System.Drawing.Point(139, 12);
            textBoxNomeTabela.Name = "textBoxNomeTabela";
            textBoxNomeTabela.Size = new System.Drawing.Size(363, 23);
            textBoxNomeTabela.TabIndex = 0;
            // 
            // labelNomeTabela
            // 
            labelNomeTabela.AutoSize = true;
            labelNomeTabela.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelNomeTabela.Location = new System.Drawing.Point(12, 15);
            labelNomeTabela.Name = "labelNomeTabela";
            labelNomeTabela.Size = new System.Drawing.Size(121, 20);
            labelNomeTabela.TabIndex = 1;
            labelNomeTabela.Text = "Nome da Tabela:";
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonConfirmar.Location = new System.Drawing.Point(524, 12);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new System.Drawing.Size(103, 26);
            buttonConfirmar.TabIndex = 2;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // FormNomeTabela
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(642, 46);
            Controls.Add(buttonConfirmar);
            Controls.Add(labelNomeTabela);
            Controls.Add(textBoxNomeTabela);
            Name = "FormNomeTabela";
            Text = "Criar Tabela";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeTabela;
        private System.Windows.Forms.Label labelNomeTabela;
        private System.Windows.Forms.Button buttonConfirmar;
    }
}