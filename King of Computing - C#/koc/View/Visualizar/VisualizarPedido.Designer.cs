namespace koc.View.Visualizar
{
    partial class VisualizarPedido
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
            this.lvPedidos = new System.Windows.Forms.ListView();
            this.idPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.configPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataEnPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSaPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valorPed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCliFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblConfigPed = new System.Windows.Forms.Label();
            this.rtbConfigPed = new System.Windows.Forms.RichTextBox();
            this.btnBuscarPed = new System.Windows.Forms.Button();
            this.lblIdCliFK = new System.Windows.Forms.Label();
            this.tbxIdCliFK = new System.Windows.Forms.TextBox();
            this.lblStatusPed = new System.Windows.Forms.Label();
            this.lblDataSaPed = new System.Windows.Forms.Label();
            this.lblDataEnPed = new System.Windows.Forms.Label();
            this.lblIdPed = new System.Windows.Forms.Label();
            this.tbxDataSaPed = new System.Windows.Forms.TextBox();
            this.tbxDataEnPed = new System.Windows.Forms.TextBox();
            this.tbxIdPed = new System.Windows.Forms.TextBox();
            this.btnDeletarPed = new System.Windows.Forms.Button();
            this.btnAlterarPed = new System.Windows.Forms.Button();
            this.lblValorPed = new System.Windows.Forms.Label();
            this.tbxValorPed = new System.Windows.Forms.TextBox();
            this.cbxStatusPed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvPedidos
            // 
            this.lvPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lvPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPed,
            this.configPed,
            this.dataEnPed,
            this.dataSaPed,
            this.statusPed,
            this.valorPed,
            this.idCliFK});
            this.lvPedidos.ForeColor = System.Drawing.SystemColors.Control;
            this.lvPedidos.HideSelection = false;
            this.lvPedidos.Location = new System.Drawing.Point(12, 12);
            this.lvPedidos.Name = "lvPedidos";
            this.lvPedidos.Size = new System.Drawing.Size(1240, 281);
            this.lvPedidos.TabIndex = 19;
            this.lvPedidos.UseCompatibleStateImageBehavior = false;
            this.lvPedidos.View = System.Windows.Forms.View.Details;
            this.lvPedidos.SelectedIndexChanged += new System.EventHandler(this.lvPedidos_SelectedIndexChanged);
            // 
            // idPed
            // 
            this.idPed.Text = "ID";
            this.idPed.Width = 64;
            // 
            // configPed
            // 
            this.configPed.Text = "Configurações";
            this.configPed.Width = 256;
            // 
            // dataEnPed
            // 
            this.dataEnPed.Text = "Data (Entrada)";
            this.dataEnPed.Width = 192;
            // 
            // dataSaPed
            // 
            this.dataSaPed.Text = "Data (Saída)";
            this.dataSaPed.Width = 192;
            // 
            // statusPed
            // 
            this.statusPed.Text = "Status";
            this.statusPed.Width = 128;
            // 
            // valorPed
            // 
            this.valorPed.Text = "Valor";
            this.valorPed.Width = 192;
            // 
            // idCliFK
            // 
            this.idCliFK.Text = "ID (Cliente)";
            this.idCliFK.Width = 128;
            // 
            // lblConfigPed
            // 
            this.lblConfigPed.AutoSize = true;
            this.lblConfigPed.Location = new System.Drawing.Point(7, 393);
            this.lblConfigPed.Name = "lblConfigPed";
            this.lblConfigPed.Size = new System.Drawing.Size(157, 25);
            this.lblConfigPed.TabIndex = 51;
            this.lblConfigPed.Text = "Configurações:";
            // 
            // rtbConfigPed
            // 
            this.rtbConfigPed.Location = new System.Drawing.Point(12, 421);
            this.rtbConfigPed.Name = "rtbConfigPed";
            this.rtbConfigPed.Size = new System.Drawing.Size(490, 143);
            this.rtbConfigPed.TabIndex = 50;
            this.rtbConfigPed.Text = "";
            // 
            // btnBuscarPed
            // 
            this.btnBuscarPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(249)))), ((int)(((byte)(145)))));
            this.btnBuscarPed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarPed.Location = new System.Drawing.Point(543, 323);
            this.btnBuscarPed.Name = "btnBuscarPed";
            this.btnBuscarPed.Size = new System.Drawing.Size(200, 93);
            this.btnBuscarPed.TabIndex = 49;
            this.btnBuscarPed.Text = "Buscar";
            this.btnBuscarPed.UseVisualStyleBackColor = false;
            this.btnBuscarPed.Click += new System.EventHandler(this.btnBuscarPed_Click);
            // 
            // lblIdCliFK
            // 
            this.lblIdCliFK.AutoSize = true;
            this.lblIdCliFK.Location = new System.Drawing.Point(775, 575);
            this.lblIdCliFK.Name = "lblIdCliFK";
            this.lblIdCliFK.Size = new System.Drawing.Size(119, 25);
            this.lblIdCliFK.TabIndex = 48;
            this.lblIdCliFK.Text = "ID (Cliente)";
            // 
            // tbxIdCliFK
            // 
            this.tbxIdCliFK.Location = new System.Drawing.Point(780, 603);
            this.tbxIdCliFK.Name = "tbxIdCliFK";
            this.tbxIdCliFK.ReadOnly = true;
            this.tbxIdCliFK.Size = new System.Drawing.Size(472, 31);
            this.tbxIdCliFK.TabIndex = 47;
            // 
            // lblStatusPed
            // 
            this.lblStatusPed.AutoSize = true;
            this.lblStatusPed.Location = new System.Drawing.Point(775, 491);
            this.lblStatusPed.Name = "lblStatusPed";
            this.lblStatusPed.Size = new System.Drawing.Size(79, 25);
            this.lblStatusPed.TabIndex = 46;
            this.lblStatusPed.Text = "Status:";
            // 
            // lblDataSaPed
            // 
            this.lblDataSaPed.AutoSize = true;
            this.lblDataSaPed.Location = new System.Drawing.Point(775, 407);
            this.lblDataSaPed.Name = "lblDataSaPed";
            this.lblDataSaPed.Size = new System.Drawing.Size(154, 25);
            this.lblDataSaPed.TabIndex = 45;
            this.lblDataSaPed.Text = "Data de Saída:";
            // 
            // lblDataEnPed
            // 
            this.lblDataEnPed.AutoSize = true;
            this.lblDataEnPed.Location = new System.Drawing.Point(775, 323);
            this.lblDataEnPed.Name = "lblDataEnPed";
            this.lblDataEnPed.Size = new System.Drawing.Size(174, 25);
            this.lblDataEnPed.TabIndex = 44;
            this.lblDataEnPed.Text = "Data de Entrada:";
            // 
            // lblIdPed
            // 
            this.lblIdPed.AutoSize = true;
            this.lblIdPed.Location = new System.Drawing.Point(7, 323);
            this.lblIdPed.Name = "lblIdPed";
            this.lblIdPed.Size = new System.Drawing.Size(38, 25);
            this.lblIdPed.TabIndex = 42;
            this.lblIdPed.Text = "ID:";
            // 
            // tbxDataSaPed
            // 
            this.tbxDataSaPed.Location = new System.Drawing.Point(780, 435);
            this.tbxDataSaPed.Name = "tbxDataSaPed";
            this.tbxDataSaPed.Size = new System.Drawing.Size(472, 31);
            this.tbxDataSaPed.TabIndex = 40;
            // 
            // tbxDataEnPed
            // 
            this.tbxDataEnPed.Location = new System.Drawing.Point(780, 351);
            this.tbxDataEnPed.Name = "tbxDataEnPed";
            this.tbxDataEnPed.Size = new System.Drawing.Size(472, 31);
            this.tbxDataEnPed.TabIndex = 39;
            // 
            // tbxIdPed
            // 
            this.tbxIdPed.Location = new System.Drawing.Point(12, 351);
            this.tbxIdPed.Name = "tbxIdPed";
            this.tbxIdPed.ReadOnly = true;
            this.tbxIdPed.Size = new System.Drawing.Size(490, 31);
            this.tbxIdPed.TabIndex = 37;
            // 
            // btnDeletarPed
            // 
            this.btnDeletarPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(1)))));
            this.btnDeletarPed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletarPed.Location = new System.Drawing.Point(543, 541);
            this.btnDeletarPed.Name = "btnDeletarPed";
            this.btnDeletarPed.Size = new System.Drawing.Size(200, 93);
            this.btnDeletarPed.TabIndex = 36;
            this.btnDeletarPed.Text = "Deletar";
            this.btnDeletarPed.UseVisualStyleBackColor = false;
            this.btnDeletarPed.Click += new System.EventHandler(this.btnDeletarPed_Click);
            // 
            // btnAlterarPed
            // 
            this.btnAlterarPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.btnAlterarPed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterarPed.Location = new System.Drawing.Point(543, 432);
            this.btnAlterarPed.Name = "btnAlterarPed";
            this.btnAlterarPed.Size = new System.Drawing.Size(200, 93);
            this.btnAlterarPed.TabIndex = 35;
            this.btnAlterarPed.Text = "Alterar";
            this.btnAlterarPed.UseVisualStyleBackColor = false;
            this.btnAlterarPed.Click += new System.EventHandler(this.btnAlterarPed_Click);
            // 
            // lblValorPed
            // 
            this.lblValorPed.AutoSize = true;
            this.lblValorPed.Location = new System.Drawing.Point(7, 575);
            this.lblValorPed.Name = "lblValorPed";
            this.lblValorPed.Size = new System.Drawing.Size(68, 25);
            this.lblValorPed.TabIndex = 53;
            this.lblValorPed.Text = "Valor:";
            // 
            // tbxValorPed
            // 
            this.tbxValorPed.Location = new System.Drawing.Point(10, 602);
            this.tbxValorPed.Name = "tbxValorPed";
            this.tbxValorPed.Size = new System.Drawing.Size(492, 31);
            this.tbxValorPed.TabIndex = 52;
            // 
            // cbxStatusPed
            // 
            this.cbxStatusPed.FormattingEnabled = true;
            this.cbxStatusPed.Items.AddRange(new object[] {
            "Em análise",
            "Em manutenção",
            "Manutenção finalizada",
            "Manutenção entregue"});
            this.cbxStatusPed.Location = new System.Drawing.Point(780, 519);
            this.cbxStatusPed.Name = "cbxStatusPed";
            this.cbxStatusPed.Size = new System.Drawing.Size(472, 33);
            this.cbxStatusPed.TabIndex = 54;
            // 
            // VisualizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cbxStatusPed);
            this.Controls.Add(this.lblValorPed);
            this.Controls.Add(this.tbxValorPed);
            this.Controls.Add(this.lblConfigPed);
            this.Controls.Add(this.rtbConfigPed);
            this.Controls.Add(this.btnBuscarPed);
            this.Controls.Add(this.lblIdCliFK);
            this.Controls.Add(this.tbxIdCliFK);
            this.Controls.Add(this.lblStatusPed);
            this.Controls.Add(this.lblDataSaPed);
            this.Controls.Add(this.lblDataEnPed);
            this.Controls.Add(this.lblIdPed);
            this.Controls.Add(this.tbxDataSaPed);
            this.Controls.Add(this.tbxDataEnPed);
            this.Controls.Add(this.tbxIdPed);
            this.Controls.Add(this.btnDeletarPed);
            this.Controls.Add(this.btnAlterarPed);
            this.Controls.Add(this.lvPedidos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "VisualizarPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPedidos;
        private System.Windows.Forms.ColumnHeader idPed;
        private System.Windows.Forms.ColumnHeader configPed;
        private System.Windows.Forms.ColumnHeader dataEnPed;
        private System.Windows.Forms.ColumnHeader dataSaPed;
        private System.Windows.Forms.ColumnHeader statusPed;
        private System.Windows.Forms.ColumnHeader valorPed;
        private System.Windows.Forms.ColumnHeader idCliFK;
        private System.Windows.Forms.Label lblConfigPed;
        private System.Windows.Forms.RichTextBox rtbConfigPed;
        private System.Windows.Forms.Button btnBuscarPed;
        private System.Windows.Forms.Label lblIdCliFK;
        private System.Windows.Forms.TextBox tbxIdCliFK;
        private System.Windows.Forms.Label lblStatusPed;
        private System.Windows.Forms.Label lblDataSaPed;
        private System.Windows.Forms.Label lblDataEnPed;
        private System.Windows.Forms.Label lblIdPed;
        private System.Windows.Forms.TextBox tbxDataSaPed;
        private System.Windows.Forms.TextBox tbxDataEnPed;
        private System.Windows.Forms.TextBox tbxIdPed;
        private System.Windows.Forms.Button btnDeletarPed;
        private System.Windows.Forms.Button btnAlterarPed;
        private System.Windows.Forms.Label lblValorPed;
        private System.Windows.Forms.TextBox tbxValorPed;
        private System.Windows.Forms.ComboBox cbxStatusPed;
    }
}