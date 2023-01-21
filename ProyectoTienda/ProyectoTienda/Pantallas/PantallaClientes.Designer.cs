
namespace ProyectoTienda.Pantallas
{
    partial class PantallaClientes
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
            this.components = new System.ComponentModel.Container();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.BotonNuevoCliente = new System.Windows.Forms.Button();
            this.ClienteTabla = new System.Windows.Forms.DataGridView();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.UsuarioTexto = new System.Windows.Forms.TextBox();
            this.NombreTexto = new System.Windows.Forms.TextBox();
            this.EmailTexto = new System.Windows.Forms.TextBox();
            this.TelefonoTexto = new System.Windows.Forms.TextBox();
            this.gerenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.label1);
            this.PanelTitulo.Controls.Add(this.Titulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1053, 70);
            this.PanelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label1.Location = new System.Drawing.Point(435, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 23);
            this.Titulo.TabIndex = 0;
            // 
            // BotonNuevoCliente
            // 
            this.BotonNuevoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonNuevoCliente.Location = new System.Drawing.Point(850, 381);
            this.BotonNuevoCliente.Name = "BotonNuevoCliente";
            this.BotonNuevoCliente.Size = new System.Drawing.Size(118, 48);
            this.BotonNuevoCliente.TabIndex = 1;
            this.BotonNuevoCliente.Text = "Crear";
            this.BotonNuevoCliente.UseVisualStyleBackColor = true;
            this.BotonNuevoCliente.Click += new System.EventHandler(this.BotonNuevoCliente_Click);
            // 
            // ClienteTabla
            // 
            this.ClienteTabla.AllowUserToAddRows = false;
            this.ClienteTabla.AllowUserToDeleteRows = false;
            this.ClienteTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClienteTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Usuario,
            this.Email,
            this.Telefono});
            this.ClienteTabla.Location = new System.Drawing.Point(24, 114);
            this.ClienteTabla.Name = "ClienteTabla";
            this.ClienteTabla.Size = new System.Drawing.Size(640, 454);
            this.ClienteTabla.TabIndex = 2;
            this.ClienteTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteTabla_CellContentClick);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(700, 201);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(80, 22);
            this.UsuarioLabel.TabIndex = 3;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(700, 247);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(83, 22);
            this.NombreLabel.TabIndex = 4;
            this.NombreLabel.Text = "Nombre";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(719, 290);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(61, 22);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.UseWaitCursor = true;
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(695, 330);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(88, 22);
            this.TelefonoLabel.TabIndex = 6;
            this.TelefonoLabel.Text = "Telefono";
            this.TelefonoLabel.UseWaitCursor = true;
            // 
            // UsuarioTexto
            // 
            this.UsuarioTexto.Location = new System.Drawing.Point(800, 201);
            this.UsuarioTexto.Name = "UsuarioTexto";
            this.UsuarioTexto.Size = new System.Drawing.Size(241, 20);
            this.UsuarioTexto.TabIndex = 7;
            // 
            // NombreTexto
            // 
            this.NombreTexto.Location = new System.Drawing.Point(800, 251);
            this.NombreTexto.Name = "NombreTexto";
            this.NombreTexto.Size = new System.Drawing.Size(241, 20);
            this.NombreTexto.TabIndex = 8;
            // 
            // EmailTexto
            // 
            this.EmailTexto.Location = new System.Drawing.Point(800, 294);
            this.EmailTexto.Name = "EmailTexto";
            this.EmailTexto.Size = new System.Drawing.Size(241, 20);
            this.EmailTexto.TabIndex = 9;
            // 
            // TelefonoTexto
            // 
            this.TelefonoTexto.Location = new System.Drawing.Point(800, 334);
            this.TelefonoTexto.Name = "TelefonoTexto";
            this.TelefonoTexto.Size = new System.Drawing.Size(241, 20);
            this.TelefonoTexto.TabIndex = 10;
            // 
            // gerenteBindingSource
            // 
            this.gerenteBindingSource.DataSource = typeof(ProyectoTienda.Gerentes.Gerente);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 150;
            // 
            // PantallaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 625);
            this.Controls.Add(this.TelefonoTexto);
            this.Controls.Add(this.EmailTexto);
            this.Controls.Add(this.NombreTexto);
            this.Controls.Add(this.UsuarioTexto);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.ClienteTabla);
            this.Controls.Add(this.BotonNuevoCliente);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaClientes";
            this.Text = "PantallaClientes";
            this.Load += new System.EventHandler(this.PantallaClientes_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonNuevoCliente;
        private System.Windows.Forms.BindingSource gerenteBindingSource;
        private System.Windows.Forms.DataGridView ClienteTabla;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.TextBox UsuarioTexto;
        private System.Windows.Forms.TextBox NombreTexto;
        private System.Windows.Forms.TextBox EmailTexto;
        private System.Windows.Forms.TextBox TelefonoTexto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}