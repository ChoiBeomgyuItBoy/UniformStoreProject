
namespace ProyectoTienda.Pantallas
{
    partial class PantallaConsultaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.ConsultaClienteTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonEliminarCliente = new System.Windows.Forms.Button();
            this.BotonCambioCliente = new System.Windows.Forms.Button();
            this.ConsultaFechaTexto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConsultaDeudaTexto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConsultaHijosTabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonEditar = new System.Windows.Forms.Button();
            this.ConsultaTelefonoTexto = new System.Windows.Forms.TextBox();
            this.ConsultaEmailTexto = new System.Windows.Forms.TextBox();
            this.ConsultaNombreTexto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsultaUsuarioTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaHijosTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.BotonRegresar);
            this.BarraTitulo.Controls.Add(this.ConsultaClienteTitulo);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(967, 73);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.AutoSize = true;
            this.BotonRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.BotonRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonRegresar.ForeColor = System.Drawing.Color.White;
            this.BotonRegresar.Location = new System.Drawing.Point(12, 26);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotonRegresar.Size = new System.Drawing.Size(126, 34);
            this.BotonRegresar.TabIndex = 29;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // ConsultaClienteTitulo
            // 
            this.ConsultaClienteTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultaClienteTitulo.AutoSize = true;
            this.ConsultaClienteTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.ConsultaClienteTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConsultaClienteTitulo.Location = new System.Drawing.Point(333, 30);
            this.ConsultaClienteTitulo.Name = "ConsultaClienteTitulo";
            this.ConsultaClienteTitulo.Size = new System.Drawing.Size(263, 24);
            this.ConsultaClienteTitulo.TabIndex = 2;
            this.ConsultaClienteTitulo.Text = "CONSULTA DE CLIENTE";
            this.ConsultaClienteTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BotonEliminarCliente);
            this.panel2.Controls.Add(this.BotonCambioCliente);
            this.panel2.Controls.Add(this.ConsultaFechaTexto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ConsultaDeudaTexto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ConsultaHijosTabla);
            this.panel2.Controls.Add(this.BotonEditar);
            this.panel2.Controls.Add(this.ConsultaTelefonoTexto);
            this.panel2.Controls.Add(this.ConsultaEmailTexto);
            this.panel2.Controls.Add(this.ConsultaNombreTexto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ConsultaUsuarioTexto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 499);
            this.panel2.TabIndex = 1;
            // 
            // BotonEliminarCliente
            // 
            this.BotonEliminarCliente.AutoSize = true;
            this.BotonEliminarCliente.BackColor = System.Drawing.Color.Red;
            this.BotonEliminarCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonEliminarCliente.ForeColor = System.Drawing.Color.White;
            this.BotonEliminarCliente.Location = new System.Drawing.Point(768, 437);
            this.BotonEliminarCliente.Name = "BotonEliminarCliente";
            this.BotonEliminarCliente.Size = new System.Drawing.Size(185, 48);
            this.BotonEliminarCliente.TabIndex = 30;
            this.BotonEliminarCliente.Text = "Eliminar Cliente";
            this.BotonEliminarCliente.UseVisualStyleBackColor = false;
            this.BotonEliminarCliente.Click += new System.EventHandler(this.BotonEliminarCliente_Click);
            // 
            // BotonCambioCliente
            // 
            this.BotonCambioCliente.AutoSize = true;
            this.BotonCambioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.BotonCambioCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonCambioCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCambioCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonCambioCliente.ForeColor = System.Drawing.Color.White;
            this.BotonCambioCliente.Location = new System.Drawing.Point(62, 326);
            this.BotonCambioCliente.Name = "BotonCambioCliente";
            this.BotonCambioCliente.Size = new System.Drawing.Size(337, 48);
            this.BotonCambioCliente.TabIndex = 29;
            this.BotonCambioCliente.Text = "Actualizar Informacion";
            this.BotonCambioCliente.UseVisualStyleBackColor = false;
            this.BotonCambioCliente.Visible = false;
            this.BotonCambioCliente.Click += new System.EventHandler(this.BotonCambioCliente_Click);
            // 
            // ConsultaFechaTexto
            // 
            this.ConsultaFechaTexto.Enabled = false;
            this.ConsultaFechaTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaFechaTexto.Location = new System.Drawing.Point(179, 272);
            this.ConsultaFechaTexto.Name = "ConsultaFechaTexto";
            this.ConsultaFechaTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaFechaTexto.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha Creación";
            // 
            // ConsultaDeudaTexto
            // 
            this.ConsultaDeudaTexto.Enabled = false;
            this.ConsultaDeudaTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaDeudaTexto.Location = new System.Drawing.Point(179, 227);
            this.ConsultaDeudaTexto.Name = "ConsultaDeudaTexto";
            this.ConsultaDeudaTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaDeudaTexto.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(112, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Debe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(673, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hijos";
            // 
            // ConsultaHijosTabla
            // 
            this.ConsultaHijosTabla.AllowUserToAddRows = false;
            this.ConsultaHijosTabla.AllowUserToDeleteRows = false;
            this.ConsultaHijosTabla.AllowUserToResizeColumns = false;
            this.ConsultaHijosTabla.AllowUserToResizeRows = false;
            this.ConsultaHijosTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ConsultaHijosTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultaHijosTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultaHijosTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.ConsultaHijosTabla.ColumnHeadersHeight = 50;
            this.ConsultaHijosTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ConsultaHijosTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Departamento});
            this.ConsultaHijosTabla.EnableHeadersVisualStyles = false;
            this.ConsultaHijosTabla.GridColor = System.Drawing.Color.SteelBlue;
            this.ConsultaHijosTabla.Location = new System.Drawing.Point(507, 86);
            this.ConsultaHijosTabla.Name = "ConsultaHijosTabla";
            this.ConsultaHijosTabla.ReadOnly = true;
            this.ConsultaHijosTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ConsultaHijosTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.ConsultaHijosTabla.RowHeadersVisible = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultaHijosTabla.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.ConsultaHijosTabla.RowTemplate.Height = 40;
            this.ConsultaHijosTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ConsultaHijosTabla.Size = new System.Drawing.Size(401, 243);
            this.ConsultaHijosTabla.TabIndex = 23;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 200;
            // 
            // BotonEditar
            // 
            this.BotonEditar.AutoSize = true;
            this.BotonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.BotonEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonEditar.ForeColor = System.Drawing.Color.White;
            this.BotonEditar.Location = new System.Drawing.Point(62, 326);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(337, 48);
            this.BotonEditar.TabIndex = 22;
            this.BotonEditar.Text = "Editar";
            this.BotonEditar.UseVisualStyleBackColor = false;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // ConsultaTelefonoTexto
            // 
            this.ConsultaTelefonoTexto.Enabled = false;
            this.ConsultaTelefonoTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaTelefonoTexto.Location = new System.Drawing.Point(179, 183);
            this.ConsultaTelefonoTexto.Name = "ConsultaTelefonoTexto";
            this.ConsultaTelefonoTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaTelefonoTexto.TabIndex = 21;
            // 
            // ConsultaEmailTexto
            // 
            this.ConsultaEmailTexto.Enabled = false;
            this.ConsultaEmailTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaEmailTexto.Location = new System.Drawing.Point(179, 142);
            this.ConsultaEmailTexto.Name = "ConsultaEmailTexto";
            this.ConsultaEmailTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaEmailTexto.TabIndex = 20;
            // 
            // ConsultaNombreTexto
            // 
            this.ConsultaNombreTexto.Enabled = false;
            this.ConsultaNombreTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaNombreTexto.Location = new System.Drawing.Point(179, 102);
            this.ConsultaNombreTexto.Name = "ConsultaNombreTexto";
            this.ConsultaNombreTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaNombreTexto.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // ConsultaUsuarioTexto
            // 
            this.ConsultaUsuarioTexto.Enabled = false;
            this.ConsultaUsuarioTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.ConsultaUsuarioTexto.Location = new System.Drawing.Point(179, 56);
            this.ConsultaUsuarioTexto.Name = "ConsultaUsuarioTexto";
            this.ConsultaUsuarioTexto.Size = new System.Drawing.Size(241, 25);
            this.ConsultaUsuarioTexto.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario";
            // 
            // PantallaConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaConsultaCliente";
            this.Text = "PantallaConsultaCliente";
            this.Deactivate += new System.EventHandler(this.ClickFueraDeArea);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaHijosTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ConsultaClienteTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ConsultaUsuarioTexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConsultaTelefonoTexto;
        private System.Windows.Forms.TextBox ConsultaEmailTexto;
        private System.Windows.Forms.TextBox ConsultaNombreTexto;
        private System.Windows.Forms.Button BotonEditar;
        private System.Windows.Forms.DataGridView ConsultaHijosTabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.TextBox ConsultaFechaTexto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConsultaDeudaTexto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Button BotonCambioCliente;
        private System.Windows.Forms.Button BotonEliminarCliente;
    }
}