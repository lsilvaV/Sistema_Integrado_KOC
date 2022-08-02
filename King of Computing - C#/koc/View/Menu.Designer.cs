namespace koc.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogo = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.menuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCliente,
            this.btnManutencao,
            this.btnSobre,
            this.btnSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1264, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // btnCliente
            // 
            this.btnCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarCliente,
            this.btnVisualizarCliente});
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(78, 24);
            this.btnCliente.Text = "Clientes";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(148, 24);
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnVisualizarCliente
            // 
            this.btnVisualizarCliente.Name = "btnVisualizarCliente";
            this.btnVisualizarCliente.Size = new System.Drawing.Size(148, 24);
            this.btnVisualizarCliente.Text = "Visualizar";
            this.btnVisualizarCliente.Click += new System.EventHandler(this.btnVisualizarCliente_Click);
            // 
            // btnManutencao
            // 
            this.btnManutencao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarManutencao,
            this.btnVisualizarManutencao});
            this.btnManutencao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManutencao.Name = "btnManutencao";
            this.btnManutencao.Size = new System.Drawing.Size(118, 24);
            this.btnManutencao.Text = "Manutenções";
            // 
            // btnCadastrarManutencao
            // 
            this.btnCadastrarManutencao.Name = "btnCadastrarManutencao";
            this.btnCadastrarManutencao.Size = new System.Drawing.Size(148, 24);
            this.btnCadastrarManutencao.Text = "Cadastrar";
            this.btnCadastrarManutencao.Click += new System.EventHandler(this.btnCadastrarManutencao_Click);
            // 
            // btnVisualizarManutencao
            // 
            this.btnVisualizarManutencao.Name = "btnVisualizarManutencao";
            this.btnVisualizarManutencao.Size = new System.Drawing.Size(148, 24);
            this.btnVisualizarManutencao.Text = "Visualizar";
            this.btnVisualizarManutencao.Click += new System.EventHandler(this.btnVisualizarManutencao_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(64, 24);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 24);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.lblLogo.Image = global::koc.Properties.Resources.logo;
            this.lblLogo.Location = new System.Drawing.Point(0, 28);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(1264, 653);
            this.lblLogo.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(1)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento - King of Computing";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnCliente;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarCliente;
        private System.Windows.Forms.ToolStripMenuItem btnVisualizarCliente;
        private System.Windows.Forms.ToolStripMenuItem btnManutencao;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarManutencao;
        private System.Windows.Forms.ToolStripMenuItem btnVisualizarManutencao;
        private System.Windows.Forms.ToolStripMenuItem btnSobre;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.Label lblLogo;
    }
}