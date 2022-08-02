namespace koc.View.Visualizar
{
    partial class VisualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarCliente));
            this.btnAlterarCli = new System.Windows.Forms.Button();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.idCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpfCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.foneCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senhaCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxIdCli = new System.Windows.Forms.TextBox();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.tbxCpfCli = new System.Windows.Forms.TextBox();
            this.tbxFoneCli = new System.Windows.Forms.TextBox();
            this.tbxEmailCli = new System.Windows.Forms.TextBox();
            this.lblIdCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.lblFoneCli = new System.Windows.Forms.Label();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblSenhaCli = new System.Windows.Forms.Label();
            this.tbxSenhaCli = new System.Windows.Forms.TextBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarCli
            // 
            this.btnAlterarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.btnAlterarCli.Location = new System.Drawing.Point(240, 541);
            this.btnAlterarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterarCli.Name = "btnAlterarCli";
            this.btnAlterarCli.Size = new System.Drawing.Size(119, 38);
            this.btnAlterarCli.TabIndex = 1;
            this.btnAlterarCli.Text = "Alterar";
            this.btnAlterarCli.UseVisualStyleBackColor = false;
            this.btnAlterarCli.Click += new System.EventHandler(this.btnAlterarCli_Click);
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(1)))));
            this.btnDeletarCli.Location = new System.Drawing.Point(384, 541);
            this.btnDeletarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(119, 38);
            this.btnDeletarCli.TabIndex = 2;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = false;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCli,
            this.nomeCli,
            this.cpfCli,
            this.foneCli,
            this.emailCli,
            this.senhaCli});
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(543, 116);
            this.lvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(708, 463);
            this.lvClientes.TabIndex = 3;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            this.lvClientes.SelectedIndexChanged += new System.EventHandler(this.lvClientes_SelectedIndexChanged);
            // 
            // idCli
            // 
            this.idCli.Text = "ID";
            this.idCli.Width = 64;
            // 
            // nomeCli
            // 
            this.nomeCli.Text = "Nome";
            this.nomeCli.Width = 128;
            // 
            // cpfCli
            // 
            this.cpfCli.Text = "CPF";
            this.cpfCli.Width = 128;
            // 
            // foneCli
            // 
            this.foneCli.Text = "Telefone";
            this.foneCli.Width = 128;
            // 
            // emailCli
            // 
            this.emailCli.Text = "E-mail";
            this.emailCli.Width = 128;
            // 
            // senhaCli
            // 
            this.senhaCli.Text = "Senha";
            this.senhaCli.Width = 128;
            // 
            // tbxIdCli
            // 
            this.tbxIdCli.Location = new System.Drawing.Point(128, 140);
            this.tbxIdCli.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIdCli.Name = "tbxIdCli";
            this.tbxIdCli.ReadOnly = true;
            this.tbxIdCli.Size = new System.Drawing.Size(375, 31);
            this.tbxIdCli.TabIndex = 4;
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(128, 206);
            this.tbxNomeCli.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(375, 31);
            this.tbxNomeCli.TabIndex = 5;
            // 
            // tbxCpfCli
            // 
            this.tbxCpfCli.Location = new System.Drawing.Point(128, 272);
            this.tbxCpfCli.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCpfCli.Name = "tbxCpfCli";
            this.tbxCpfCli.Size = new System.Drawing.Size(375, 31);
            this.tbxCpfCli.TabIndex = 6;
            // 
            // tbxFoneCli
            // 
            this.tbxFoneCli.Location = new System.Drawing.Point(128, 338);
            this.tbxFoneCli.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFoneCli.Name = "tbxFoneCli";
            this.tbxFoneCli.Size = new System.Drawing.Size(375, 31);
            this.tbxFoneCli.TabIndex = 7;
            // 
            // tbxEmailCli
            // 
            this.tbxEmailCli.Location = new System.Drawing.Point(128, 404);
            this.tbxEmailCli.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmailCli.Name = "tbxEmailCli";
            this.tbxEmailCli.Size = new System.Drawing.Size(375, 31);
            this.tbxEmailCli.TabIndex = 8;
            // 
            // lblIdCli
            // 
            this.lblIdCli.AutoSize = true;
            this.lblIdCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblIdCli.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdCli.Location = new System.Drawing.Point(18, 143);
            this.lblIdCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCli.Name = "lblIdCli";
            this.lblIdCli.Size = new System.Drawing.Size(38, 25);
            this.lblIdCli.TabIndex = 9;
            this.lblIdCli.Text = "ID:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblNomeCli.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeCli.Location = new System.Drawing.Point(18, 209);
            this.lblNomeCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(74, 25);
            this.lblNomeCli.TabIndex = 10;
            this.lblNomeCli.Text = "Nome:";
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblCpfCli.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCpfCli.Location = new System.Drawing.Point(18, 275);
            this.lblCpfCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(60, 25);
            this.lblCpfCli.TabIndex = 11;
            this.lblCpfCli.Text = "CPF:";
            // 
            // lblFoneCli
            // 
            this.lblFoneCli.AutoSize = true;
            this.lblFoneCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblFoneCli.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFoneCli.Location = new System.Drawing.Point(18, 341);
            this.lblFoneCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoneCli.Name = "lblFoneCli";
            this.lblFoneCli.Size = new System.Drawing.Size(102, 25);
            this.lblFoneCli.TabIndex = 12;
            this.lblFoneCli.Text = "Telefone:";
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblEmailCli.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailCli.Location = new System.Drawing.Point(18, 407);
            this.lblEmailCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(78, 25);
            this.lblEmailCli.TabIndex = 13;
            this.lblEmailCli.Text = "E-mail:";
            // 
            // lblSenhaCli
            // 
            this.lblSenhaCli.AutoSize = true;
            this.lblSenhaCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblSenhaCli.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenhaCli.Location = new System.Drawing.Point(18, 473);
            this.lblSenhaCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaCli.Name = "lblSenhaCli";
            this.lblSenhaCli.Size = new System.Drawing.Size(80, 25);
            this.lblSenhaCli.TabIndex = 15;
            this.lblSenhaCli.Text = "Senha:";
            // 
            // tbxSenhaCli
            // 
            this.tbxSenhaCli.Location = new System.Drawing.Point(128, 470);
            this.tbxSenhaCli.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSenhaCli.Name = "tbxSenhaCli";
            this.tbxSenhaCli.Size = new System.Drawing.Size(375, 31);
            this.tbxSenhaCli.TabIndex = 14;
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(145)))));
            this.btnBuscarCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarCli.Location = new System.Drawing.Point(1132, 70);
            this.btnBuscarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(119, 38);
            this.btnBuscarCli.TabIndex = 16;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = false;
            this.btnBuscarCli.Click += new System.EventHandler(this.btnBuscarCli_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblBarra.Location = new System.Drawing.Point(-2, -1);
            this.lblBarra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(537, 683);
            this.lblBarra.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(621, 47);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(344, 42);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Visualizar Clientes";
            // 
            // lblImg
            // 
            this.lblImg.Image = ((System.Drawing.Image)(resources.GetObject("lblImg.Image")));
            this.lblImg.Location = new System.Drawing.Point(542, 30);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(72, 78);
            this.lblImg.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.label1.Image = global::koc.Properties.Resources.mlogo;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 72);
            this.label1.TabIndex = 24;
            // 
            // VisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.lblSenhaCli);
            this.Controls.Add(this.tbxSenhaCli);
            this.Controls.Add(this.lblEmailCli);
            this.Controls.Add(this.lblFoneCli);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblIdCli);
            this.Controls.Add(this.tbxEmailCli);
            this.Controls.Add(this.tbxFoneCli);
            this.Controls.Add(this.tbxCpfCli);
            this.Controls.Add(this.tbxNomeCli);
            this.Controls.Add(this.tbxIdCli);
            this.Controls.Add(this.lvClientes);
            this.Controls.Add(this.btnDeletarCli);
            this.Controls.Add(this.btnAlterarCli);
            this.Controls.Add(this.lblBarra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "VisualizarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlterarCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader idCli;
        private System.Windows.Forms.ColumnHeader nomeCli;
        private System.Windows.Forms.ColumnHeader cpfCli;
        private System.Windows.Forms.ColumnHeader foneCli;
        private System.Windows.Forms.ColumnHeader emailCli;
        private System.Windows.Forms.ColumnHeader senhaCli;
        private System.Windows.Forms.TextBox tbxIdCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.TextBox tbxCpfCli;
        private System.Windows.Forms.TextBox tbxFoneCli;
        private System.Windows.Forms.TextBox tbxEmailCli;
        private System.Windows.Forms.Label lblIdCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCpfCli;
        private System.Windows.Forms.Label lblFoneCli;
        private System.Windows.Forms.Label lblEmailCli;
        private System.Windows.Forms.Label lblSenhaCli;
        private System.Windows.Forms.TextBox tbxSenhaCli;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label label1;
    }
}