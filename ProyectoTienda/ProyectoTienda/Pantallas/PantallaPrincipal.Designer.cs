
namespace ProyectoTienda.Pantallas
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.BotonRestaurar = new System.Windows.Forms.PictureBox();
            this.BotonMaximizar = new System.Windows.Forms.PictureBox();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BotonInventario = new System.Windows.Forms.Button();
            this.BotonColorPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonClientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonCompra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonVentas = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.PanelTitulo.Controls.Add(this.BotonRestaurar);
            this.PanelTitulo.Controls.Add(this.BotonMaximizar);
            this.PanelTitulo.Controls.Add(this.BotonMinimizar);
            this.PanelTitulo.Controls.Add(this.BotonCerrar);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1269, 45);
            this.PanelTitulo.TabIndex = 0;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // BotonRestaurar
            // 
            this.BotonRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRestaurar.Image")));
            this.BotonRestaurar.Location = new System.Drawing.Point(1178, 12);
            this.BotonRestaurar.Name = "BotonRestaurar";
            this.BotonRestaurar.Size = new System.Drawing.Size(20, 20);
            this.BotonRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonRestaurar.TabIndex = 3;
            this.BotonRestaurar.TabStop = false;
            this.BotonRestaurar.Visible = false;
            this.BotonRestaurar.Click += new System.EventHandler(this.BotonRestaurar_Click);
            // 
            // BotonMaximizar
            // 
            this.BotonMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMaximizar.Image")));
            this.BotonMaximizar.Location = new System.Drawing.Point(1178, 12);
            this.BotonMaximizar.Name = "BotonMaximizar";
            this.BotonMaximizar.Size = new System.Drawing.Size(20, 20);
            this.BotonMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMaximizar.TabIndex = 2;
            this.BotonMaximizar.TabStop = false;
            this.BotonMaximizar.Click += new System.EventHandler(this.BotonMaximizar_Click);
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BotonMinimizar.Image")));
            this.BotonMinimizar.Location = new System.Drawing.Point(1134, 12);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BotonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMinimizar.TabIndex = 1;
            this.BotonMinimizar.TabStop = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.BotonMinimizar_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonCerrar.Image")));
            this.BotonCerrar.Location = new System.Drawing.Point(1225, 12);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(20, 20);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.BotonVentas);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.BotonCompra);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.BotonClientes);
            this.PanelMenu.Controls.Add(this.BotonColorPanel);
            this.PanelMenu.Controls.Add(this.BotonInventario);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 45);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(228, 699);
            this.PanelMenu.TabIndex = 1;
            // 
            // BotonInventario
            // 
            this.BotonInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BotonInventario.FlatAppearance.BorderSize = 0;
            this.BotonInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BotonInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInventario.ForeColor = System.Drawing.Color.White;
            this.BotonInventario.Image = ((System.Drawing.Image)(resources.GetObject("BotonInventario.Image")));
            this.BotonInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonInventario.Location = new System.Drawing.Point(9, 282);
            this.BotonInventario.Name = "BotonInventario";
            this.BotonInventario.Size = new System.Drawing.Size(219, 31);
            this.BotonInventario.TabIndex = 0;
            this.BotonInventario.Text = "Inventario";
            this.BotonInventario.UseVisualStyleBackColor = false;
            this.BotonInventario.Click += new System.EventHandler(this.BotonInventario_Click);
            // 
            // BotonColorPanel
            // 
            this.BotonColorPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.BotonColorPanel.Location = new System.Drawing.Point(0, 282);
            this.BotonColorPanel.Name = "BotonColorPanel";
            this.BotonColorPanel.Size = new System.Drawing.Size(11, 31);
            this.BotonColorPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 31);
            this.panel1.TabIndex = 4;
            // 
            // BotonClientes
            // 
            this.BotonClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BotonClientes.FlatAppearance.BorderSize = 0;
            this.BotonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonClientes.ForeColor = System.Drawing.Color.White;
            this.BotonClientes.Image = ((System.Drawing.Image)(resources.GetObject("BotonClientes.Image")));
            this.BotonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonClientes.Location = new System.Drawing.Point(9, 338);
            this.BotonClientes.Name = "BotonClientes";
            this.BotonClientes.Size = new System.Drawing.Size(216, 31);
            this.BotonClientes.TabIndex = 3;
            this.BotonClientes.Text = "Clientes";
            this.BotonClientes.UseVisualStyleBackColor = false;
            this.BotonClientes.Click += new System.EventHandler(this.BotonClientes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 31);
            this.panel2.TabIndex = 6;
            // 
            // BotonCompra
            // 
            this.BotonCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BotonCompra.FlatAppearance.BorderSize = 0;
            this.BotonCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BotonCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCompra.ForeColor = System.Drawing.Color.White;
            this.BotonCompra.Image = ((System.Drawing.Image)(resources.GetObject("BotonCompra.Image")));
            this.BotonCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonCompra.Location = new System.Drawing.Point(9, 402);
            this.BotonCompra.Name = "BotonCompra";
            this.BotonCompra.Size = new System.Drawing.Size(216, 31);
            this.BotonCompra.TabIndex = 5;
            this.BotonCompra.Text = "Compra";
            this.BotonCompra.UseVisualStyleBackColor = false;
            this.BotonCompra.Click += new System.EventHandler(this.BotonCompra_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(0, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 31);
            this.panel3.TabIndex = 8;
            // 
            // BotonVentas
            // 
            this.BotonVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BotonVentas.FlatAppearance.BorderSize = 0;
            this.BotonVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BotonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonVentas.ForeColor = System.Drawing.Color.White;
            this.BotonVentas.Image = ((System.Drawing.Image)(resources.GetObject("BotonVentas.Image")));
            this.BotonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonVentas.Location = new System.Drawing.Point(9, 465);
            this.BotonVentas.Name = "BotonVentas";
            this.BotonVentas.Size = new System.Drawing.Size(216, 31);
            this.BotonVentas.TabIndex = 7;
            this.BotonVentas.Text = "Ventas";
            this.BotonVentas.UseVisualStyleBackColor = false;
            this.BotonVentas.Click += new System.EventHandler(this.BotonVentas_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(228, 45);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1041, 699);
            this.PanelContenedor.TabIndex = 2;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 744);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaPrincipal";
            this.Text = "Principal";
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox BotonMinimizar;
        private System.Windows.Forms.PictureBox BotonMaximizar;
        private System.Windows.Forms.PictureBox BotonRestaurar;
        private System.Windows.Forms.Button BotonInventario;
        private System.Windows.Forms.Panel BotonColorPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotonCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BotonVentas;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}