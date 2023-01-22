
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.PanelAtencionClientes = new System.Windows.Forms.Panel();
            this.ConsultaTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelConsultaCliente = new System.Windows.Forms.Label();
            this.LabelNuevoCliente = new System.Windows.Forms.Label();
            this.ClienteTabla = new System.Windows.Forms.DataGridView();
            this.BotonNuevoCliente = new System.Windows.Forms.Button();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.TelefonoTexto = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.UsuarioTexto = new System.Windows.Forms.TextBox();
            this.EmailTexto = new System.Windows.Forms.TextBox();
            this.NombreTexto = new System.Windows.Forms.TextBox();
            this.PanelClientes = new System.Windows.Forms.Panel();
            this.BotonConsulta = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelTitulo.SuspendLayout();
            this.PanelAtencionClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTabla)).BeginInit();
            this.PanelClientes.SuspendLayout();
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
            this.PanelTitulo.Size = new System.Drawing.Size(1426, 71);
            this.PanelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label1.Location = new System.Drawing.Point(622, 28);
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
            // PanelAtencionClientes
            // 
            this.PanelAtencionClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.PanelAtencionClientes.Controls.Add(this.BotonConsulta);
            this.PanelAtencionClientes.Controls.Add(this.ConsultaTexto);
            this.PanelAtencionClientes.Controls.Add(this.label2);
            this.PanelAtencionClientes.Controls.Add(this.LabelConsultaCliente);
            this.PanelAtencionClientes.Controls.Add(this.LabelNuevoCliente);
            this.PanelAtencionClientes.Controls.Add(this.ClienteTabla);
            this.PanelAtencionClientes.Controls.Add(this.BotonNuevoCliente);
            this.PanelAtencionClientes.Controls.Add(this.TelefonoLabel);
            this.PanelAtencionClientes.Controls.Add(this.TelefonoTexto);
            this.PanelAtencionClientes.Controls.Add(this.EmailLabel);
            this.PanelAtencionClientes.Controls.Add(this.UsuarioLabel);
            this.PanelAtencionClientes.Controls.Add(this.NombreLabel);
            this.PanelAtencionClientes.Controls.Add(this.UsuarioTexto);
            this.PanelAtencionClientes.Controls.Add(this.EmailTexto);
            this.PanelAtencionClientes.Controls.Add(this.NombreTexto);
            this.PanelAtencionClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAtencionClientes.Location = new System.Drawing.Point(0, 0);
            this.PanelAtencionClientes.Name = "PanelAtencionClientes";
            this.PanelAtencionClientes.Size = new System.Drawing.Size(1426, 833);
            this.PanelAtencionClientes.TabIndex = 11;
            // 
            // ConsultaTexto
            // 
            this.ConsultaTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaTexto.Location = new System.Drawing.Point(1169, 234);
            this.ConsultaTexto.Name = "ConsultaTexto";
            this.ConsultaTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaTexto.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1062, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuario";
            // 
            // LabelConsultaCliente
            // 
            this.LabelConsultaCliente.AutoSize = true;
            this.LabelConsultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.LabelConsultaCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConsultaCliente.ForeColor = System.Drawing.Color.White;
            this.LabelConsultaCliente.Location = new System.Drawing.Point(1158, 189);
            this.LabelConsultaCliente.Name = "LabelConsultaCliente";
            this.LabelConsultaCliente.Size = new System.Drawing.Size(130, 22);
            this.LabelConsultaCliente.TabIndex = 12;
            this.LabelConsultaCliente.Text = "CONSULTAS";
            // 
            // LabelNuevoCliente
            // 
            this.LabelNuevoCliente.AutoSize = true;
            this.LabelNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.LabelNuevoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.LabelNuevoCliente.Location = new System.Drawing.Point(1145, 383);
            this.LabelNuevoCliente.Name = "LabelNuevoCliente";
            this.LabelNuevoCliente.Size = new System.Drawing.Size(167, 22);
            this.LabelNuevoCliente.TabIndex = 11;
            this.LabelNuevoCliente.Text = "NUEVO CLIENTE";
            // 
            // ClienteTabla
            // 
            this.ClienteTabla.AllowUserToAddRows = false;
            this.ClienteTabla.AllowUserToDeleteRows = false;
            this.ClienteTabla.AllowUserToResizeColumns = false;
            this.ClienteTabla.AllowUserToResizeRows = false;
            this.ClienteTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClienteTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClienteTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClienteTabla.ColumnHeadersHeight = 50;
            this.ClienteTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClienteTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Usuario,
            this.Email,
            this.Telefono});
            this.ClienteTabla.EnableHeadersVisualStyles = false;
            this.ClienteTabla.GridColor = System.Drawing.Color.SteelBlue;
            this.ClienteTabla.Location = new System.Drawing.Point(29, 123);
            this.ClienteTabla.Name = "ClienteTabla";
            this.ClienteTabla.ReadOnly = true;
            this.ClienteTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClienteTabla.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ClienteTabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ClienteTabla.RowTemplate.Height = 40;
            this.ClienteTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ClienteTabla.Size = new System.Drawing.Size(801, 662);
            this.ClienteTabla.TabIndex = 2;
            this.ClienteTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClienteTabla_CellClick);
            // 
            // BotonNuevoCliente
            // 
            this.BotonNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.BotonNuevoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonNuevoCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.BotonNuevoCliente.Location = new System.Drawing.Point(1066, 612);
            this.BotonNuevoCliente.Name = "BotonNuevoCliente";
            this.BotonNuevoCliente.Size = new System.Drawing.Size(337, 48);
            this.BotonNuevoCliente.TabIndex = 1;
            this.BotonNuevoCliente.Text = "Crear";
            this.BotonNuevoCliente.UseVisualStyleBackColor = false;
            this.BotonNuevoCliente.Click += new System.EventHandler(this.BotonNuevoCliente_Click);
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.TelefonoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.ForeColor = System.Drawing.Color.White;
            this.TelefonoLabel.Location = new System.Drawing.Point(1047, 562);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(88, 22);
            this.TelefonoLabel.TabIndex = 6;
            this.TelefonoLabel.Text = "Telefono";
            this.TelefonoLabel.UseWaitCursor = true;
            // 
            // TelefonoTexto
            // 
            this.TelefonoTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.TelefonoTexto.Location = new System.Drawing.Point(1169, 562);
            this.TelefonoTexto.Name = "TelefonoTexto";
            this.TelefonoTexto.Size = new System.Drawing.Size(241, 25);
            this.TelefonoTexto.TabIndex = 10;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.EmailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.White;
            this.EmailLabel.Location = new System.Drawing.Point(1074, 522);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(61, 22);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.UseWaitCursor = true;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.UsuarioLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.White;
            this.UsuarioLabel.Location = new System.Drawing.Point(1065, 429);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(80, 22);
            this.UsuarioLabel.TabIndex = 3;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.NombreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(1062, 475);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(83, 22);
            this.NombreLabel.TabIndex = 4;
            this.NombreLabel.Text = "Nombre";
            // 
            // UsuarioTexto
            // 
            this.UsuarioTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.UsuarioTexto.Location = new System.Drawing.Point(1169, 429);
            this.UsuarioTexto.Name = "UsuarioTexto";
            this.UsuarioTexto.Size = new System.Drawing.Size(241, 25);
            this.UsuarioTexto.TabIndex = 7;
            // 
            // EmailTexto
            // 
            this.EmailTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.EmailTexto.Location = new System.Drawing.Point(1169, 519);
            this.EmailTexto.Name = "EmailTexto";
            this.EmailTexto.Size = new System.Drawing.Size(241, 25);
            this.EmailTexto.TabIndex = 9;
            // 
            // NombreTexto
            // 
            this.NombreTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.NombreTexto.Location = new System.Drawing.Point(1169, 475);
            this.NombreTexto.Name = "NombreTexto";
            this.NombreTexto.Size = new System.Drawing.Size(241, 25);
            this.NombreTexto.TabIndex = 8;
            // 
            // PanelClientes
            // 
            this.PanelClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.PanelClientes.Controls.Add(this.PanelAtencionClientes);
            this.PanelClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelClientes.Location = new System.Drawing.Point(0, 0);
            this.PanelClientes.Name = "PanelClientes";
            this.PanelClientes.Size = new System.Drawing.Size(1426, 833);
            this.PanelClientes.TabIndex = 11;
            // 
            // BotonConsulta
            // 
            this.BotonConsulta.AutoSize = true;
            this.BotonConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.BotonConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonConsulta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonConsulta.ForeColor = System.Drawing.Color.White;
            this.BotonConsulta.Location = new System.Drawing.Point(1066, 274);
            this.BotonConsulta.Name = "BotonConsulta";
            this.BotonConsulta.Size = new System.Drawing.Size(337, 48);
            this.BotonConsulta.TabIndex = 15;
            this.BotonConsulta.Text = "Consultar";
            this.BotonConsulta.UseVisualStyleBackColor = false;
            this.BotonConsulta.Click += new System.EventHandler(this.BotonConsulta_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 200;
            // 
            // gerenteBindingSource
            // 
            this.gerenteBindingSource.DataSource = typeof(ProyectoTienda.Gerentes.Gerente);
            // 
            // PantallaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 833);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.PanelClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaClientes";
            this.Text = "PantallaClientes";
            this.Load += new System.EventHandler(this.PantallaClientes_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.PanelAtencionClientes.ResumeLayout(false);
            this.PanelAtencionClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTabla)).EndInit();
            this.PanelClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gerenteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gerenteBindingSource;
        private System.Windows.Forms.Panel PanelAtencionClientes;
        private System.Windows.Forms.DataGridView ClienteTabla;
        private System.Windows.Forms.Button BotonNuevoCliente;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.TextBox TelefonoTexto;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox UsuarioTexto;
        private System.Windows.Forms.TextBox EmailTexto;
        private System.Windows.Forms.TextBox NombreTexto;
        private System.Windows.Forms.Panel PanelClientes;
        private System.Windows.Forms.TextBox ConsultaTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelConsultaCliente;
        private System.Windows.Forms.Label LabelNuevoCliente;
        private System.Windows.Forms.Button BotonConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
    }
}