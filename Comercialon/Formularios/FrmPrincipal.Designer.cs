namespace Comercialon.Formularios
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosProdutosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosProdutosLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastros,
            this.tsmOperacoes,
            this.tsmMovimento,
            this.tsmRelatorios,
            this.tsmConfiguracoes,
            this.tsmAjuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(498, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsmCadastros
            // 
            this.tsmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosCliente,
            this.tsmCadastrosProdutos,
            this.tsmCadastrosUsuarios});
            this.tsmCadastros.Name = "tsmCadastros";
            this.tsmCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmCadastros.Text = "&Cadastros";
            // 
            // tsmCadastrosCliente
            // 
            this.tsmCadastrosCliente.Name = "tsmCadastrosCliente";
            this.tsmCadastrosCliente.Size = new System.Drawing.Size(124, 22);
            this.tsmCadastrosCliente.Text = "&Clientes";
            this.tsmCadastrosCliente.Click += new System.EventHandler(this.tsmCadastrosCliente_Click);
            // 
            // tsmCadastrosProdutos
            // 
            this.tsmCadastrosProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrosProdutosNovo,
            this.tsmCadastrosProdutosLista});
            this.tsmCadastrosProdutos.Name = "tsmCadastrosProdutos";
            this.tsmCadastrosProdutos.Size = new System.Drawing.Size(124, 22);
            this.tsmCadastrosProdutos.Text = "&Produtos";
            // 
            // tsmCadastrosProdutosNovo
            // 
            this.tsmCadastrosProdutosNovo.Name = "tsmCadastrosProdutosNovo";
            this.tsmCadastrosProdutosNovo.Size = new System.Drawing.Size(103, 22);
            this.tsmCadastrosProdutosNovo.Text = "&Novo";
            this.tsmCadastrosProdutosNovo.Click += new System.EventHandler(this.tsmCadastrosProdutosNovo_Click);
            // 
            // tsmCadastrosProdutosLista
            // 
            this.tsmCadastrosProdutosLista.Name = "tsmCadastrosProdutosLista";
            this.tsmCadastrosProdutosLista.Size = new System.Drawing.Size(103, 22);
            this.tsmCadastrosProdutosLista.Text = "&Lista";
            // 
            // tsmCadastrosUsuarios
            // 
            this.tsmCadastrosUsuarios.Name = "tsmCadastrosUsuarios";
            this.tsmCadastrosUsuarios.Size = new System.Drawing.Size(124, 22);
            this.tsmCadastrosUsuarios.Text = "&Ususários";
            // 
            // tsmOperacoes
            // 
            this.tsmOperacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem});
            this.tsmOperacoes.Name = "tsmOperacoes";
            this.tsmOperacoes.Size = new System.Drawing.Size(75, 20);
            this.tsmOperacoes.Text = "&Operações";
            // 
            // tsmMovimento
            // 
            this.tsmMovimento.Name = "tsmMovimento";
            this.tsmMovimento.Size = new System.Drawing.Size(81, 20);
            this.tsmMovimento.Text = "&Movimento";
            // 
            // tsmRelatorios
            // 
            this.tsmRelatorios.Name = "tsmRelatorios";
            this.tsmRelatorios.Size = new System.Drawing.Size(71, 20);
            this.tsmRelatorios.Text = "&Relatórios";
            // 
            // tsmConfiguracoes
            // 
            this.tsmConfiguracoes.Name = "tsmConfiguracoes";
            this.tsmConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.tsmConfiguracoes.Text = "Con&figurações";
            // 
            // tsmAjuda
            // 
            this.tsmAjuda.Name = "tsmAjuda";
            this.tsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsmAjuda.Text = "&Ajuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(498, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pedidoToolStripMenuItem.Text = "&Pedido";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 260);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmOperacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmMovimento;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem tsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosProdutosNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosProdutosLista;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrosUsuarios;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    }
}