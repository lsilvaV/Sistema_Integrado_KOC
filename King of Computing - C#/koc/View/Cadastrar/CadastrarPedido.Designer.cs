namespace koc.View.Cadastrar
{
    partial class CadastrarPedido
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
            this.rtbConfigPed = new System.Windows.Forms.RichTextBox();
            this.lblConfigPed = new System.Windows.Forms.Label();
            this.lblValorPed = new System.Windows.Forms.Label();
            this.tbxValorPed = new System.Windows.Forms.TextBox();
            this.lblDataEnPed = new System.Windows.Forms.Label();
            this.lblDataSaPed = new System.Windows.Forms.Label();
            this.lblStatusPed = new System.Windows.Forms.Label();
            this.btnCadastrarPed = new System.Windows.Forms.Button();
            this.cbxStatusPed = new System.Windows.Forms.ComboBox();
            this.tbxIdCliFK = new System.Windows.Forms.TextBox();
            this.lblCodCliFK = new System.Windows.Forms.Label();
            this.tbxDataEnPed = new System.Windows.Forms.TextBox();
            this.tbxDataSaPed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbConfigPed
            // 
            this.rtbConfigPed.Location = new System.Drawing.Point(36, 181);
            this.rtbConfigPed.Margin = new System.Windows.Forms.Padding(4);
            this.rtbConfigPed.Name = "rtbConfigPed";
            this.rtbConfigPed.Size = new System.Drawing.Size(515, 425);
            this.rtbConfigPed.TabIndex = 0;
            this.rtbConfigPed.Text = "Placa-Mãe:\nProcessador:\nPlaca de Vídeo:\nFonte:\nMemória RAM:\nArmazenamentos:";
            // 
            // lblConfigPed
            // 
            this.lblConfigPed.AutoSize = true;
            this.lblConfigPed.Location = new System.Drawing.Point(31, 152);
            this.lblConfigPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigPed.Name = "lblConfigPed";
            this.lblConfigPed.Size = new System.Drawing.Size(310, 25);
            this.lblConfigPed.TabIndex = 2;
            this.lblConfigPed.Text = "Configurações do Computador:";
            // 
            // lblValorPed
            // 
            this.lblValorPed.AutoSize = true;
            this.lblValorPed.Location = new System.Drawing.Point(577, 449);
            this.lblValorPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPed.Name = "lblValorPed";
            this.lblValorPed.Size = new System.Drawing.Size(68, 25);
            this.lblValorPed.TabIndex = 7;
            this.lblValorPed.Text = "Valor:";
            // 
            // tbxValorPed
            // 
            this.tbxValorPed.Location = new System.Drawing.Point(582, 477);
            this.tbxValorPed.Margin = new System.Windows.Forms.Padding(4);
            this.tbxValorPed.Name = "tbxValorPed";
            this.tbxValorPed.Size = new System.Drawing.Size(633, 31);
            this.tbxValorPed.TabIndex = 8;
            // 
            // lblDataEnPed
            // 
            this.lblDataEnPed.AutoSize = true;
            this.lblDataEnPed.Location = new System.Drawing.Point(577, 152);
            this.lblDataEnPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEnPed.Name = "lblDataEnPed";
            this.lblDataEnPed.Size = new System.Drawing.Size(174, 25);
            this.lblDataEnPed.TabIndex = 10;
            this.lblDataEnPed.Text = "Data de Entrada:";
            // 
            // lblDataSaPed
            // 
            this.lblDataSaPed.AutoSize = true;
            this.lblDataSaPed.Location = new System.Drawing.Point(577, 251);
            this.lblDataSaPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSaPed.Name = "lblDataSaPed";
            this.lblDataSaPed.Size = new System.Drawing.Size(256, 25);
            this.lblDataSaPed.TabIndex = 12;
            this.lblDataSaPed.Text = "Data de Saída (previsão):";
            // 
            // lblStatusPed
            // 
            this.lblStatusPed.AutoSize = true;
            this.lblStatusPed.Location = new System.Drawing.Point(577, 350);
            this.lblStatusPed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusPed.Name = "lblStatusPed";
            this.lblStatusPed.Size = new System.Drawing.Size(79, 25);
            this.lblStatusPed.TabIndex = 13;
            this.lblStatusPed.Text = "Status:";
            // 
            // btnCadastrarPed
            // 
            this.btnCadastrarPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.btnCadastrarPed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarPed.Location = new System.Drawing.Point(1067, 622);
            this.btnCadastrarPed.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarPed.Name = "btnCadastrarPed";
            this.btnCadastrarPed.Size = new System.Drawing.Size(148, 46);
            this.btnCadastrarPed.TabIndex = 15;
            this.btnCadastrarPed.Text = "Cadastrar";
            this.btnCadastrarPed.UseVisualStyleBackColor = false;
            this.btnCadastrarPed.Click += new System.EventHandler(this.btnCadastrarPed_Click);
            // 
            // cbxStatusPed
            // 
            this.cbxStatusPed.FormattingEnabled = true;
            this.cbxStatusPed.Items.AddRange(new object[] {
            "Em análise",
            "Em manutenção",
            "Manutenção finalizada",
            "Manutenção entregue"});
            this.cbxStatusPed.Location = new System.Drawing.Point(582, 377);
            this.cbxStatusPed.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStatusPed.Name = "cbxStatusPed";
            this.cbxStatusPed.Size = new System.Drawing.Size(633, 33);
            this.cbxStatusPed.TabIndex = 16;
            // 
            // tbxIdCliFK
            // 
            this.tbxIdCliFK.Location = new System.Drawing.Point(582, 575);
            this.tbxIdCliFK.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIdCliFK.Name = "tbxIdCliFK";
            this.tbxIdCliFK.Size = new System.Drawing.Size(633, 31);
            this.tbxIdCliFK.TabIndex = 18;
            // 
            // lblCodCliFK
            // 
            this.lblCodCliFK.AutoSize = true;
            this.lblCodCliFK.Location = new System.Drawing.Point(577, 548);
            this.lblCodCliFK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodCliFK.Name = "lblCodCliFK";
            this.lblCodCliFK.Size = new System.Drawing.Size(189, 25);
            this.lblCodCliFK.TabIndex = 17;
            this.lblCodCliFK.Text = "Código do Cliente:";
            // 
            // tbxDataEnPed
            // 
            this.tbxDataEnPed.Location = new System.Drawing.Point(582, 181);
            this.tbxDataEnPed.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataEnPed.Name = "tbxDataEnPed";
            this.tbxDataEnPed.Size = new System.Drawing.Size(633, 31);
            this.tbxDataEnPed.TabIndex = 19;
            this.tbxDataEnPed.Text = "DD/MM/AAAA";
            // 
            // tbxDataSaPed
            // 
            this.tbxDataSaPed.Location = new System.Drawing.Point(582, 279);
            this.tbxDataSaPed.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDataSaPed.Name = "tbxDataSaPed";
            this.tbxDataSaPed.Size = new System.Drawing.Size(633, 31);
            this.tbxDataSaPed.TabIndex = 20;
            this.tbxDataSaPed.Text = "DD/MM/AAAA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 42);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cadastro de Manutenções";
            // 
            // lblImg
            // 
            this.lblImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblImg.Image = global::koc.Properties.Resources.mlogo;
            this.lblImg.Location = new System.Drawing.Point(1180, 9);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(72, 72);
            this.lblImg.TabIndex = 23;
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblBarra.Location = new System.Drawing.Point(0, -1);
            this.lblBarra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(1269, 88);
            this.lblBarra.TabIndex = 24;
            // 
            // CadastrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxDataSaPed);
            this.Controls.Add(this.tbxDataEnPed);
            this.Controls.Add(this.tbxIdCliFK);
            this.Controls.Add(this.lblCodCliFK);
            this.Controls.Add(this.cbxStatusPed);
            this.Controls.Add(this.btnCadastrarPed);
            this.Controls.Add(this.lblStatusPed);
            this.Controls.Add(this.lblDataSaPed);
            this.Controls.Add(this.lblDataEnPed);
            this.Controls.Add(this.tbxValorPed);
            this.Controls.Add(this.lblValorPed);
            this.Controls.Add(this.lblConfigPed);
            this.Controls.Add(this.rtbConfigPed);
            this.Controls.Add(this.lblBarra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "CadastrarPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConfigPed;
        private System.Windows.Forms.Label lblConfigPed;
        private System.Windows.Forms.Label lblValorPed;
        private System.Windows.Forms.TextBox tbxValorPed;
        private System.Windows.Forms.Label lblDataEnPed;
        private System.Windows.Forms.Label lblDataSaPed;
        private System.Windows.Forms.Label lblStatusPed;
        private System.Windows.Forms.Button btnCadastrarPed;
        private System.Windows.Forms.ComboBox cbxStatusPed;
        private System.Windows.Forms.TextBox tbxIdCliFK;
        private System.Windows.Forms.Label lblCodCliFK;
        private System.Windows.Forms.TextBox tbxDataEnPed;
        private System.Windows.Forms.TextBox tbxDataSaPed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblBarra;
    }
}