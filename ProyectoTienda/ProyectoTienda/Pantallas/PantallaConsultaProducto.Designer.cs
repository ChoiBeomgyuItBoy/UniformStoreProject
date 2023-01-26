
namespace ProyectoTienda.Pantallas
{
    partial class PantallaConsultaProducto
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonCompra = new System.Windows.Forms.Button();
            this.BotonEliminarProducto = new System.Windows.Forms.Button();
            this.BotonEditar = new System.Windows.Forms.Button();
            this.BotonActualizar = new System.Windows.Forms.Button();
            this.CategoriaDropDown = new System.Windows.Forms.ComboBox();
            this.CreacionTexto = new System.Windows.Forms.TextBox();
            this.PrecioTexto = new System.Windows.Forms.TextBox();
            this.StockTexto = new System.Windows.Forms.TextBox();
            this.NombreTexto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.BotonRegresar);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1048, 84);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.AutoSize = true;
            this.BotonRegresar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BotonRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonRegresar.ForeColor = System.Drawing.Color.White;
            this.BotonRegresar.Location = new System.Drawing.Point(25, 29);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BotonRegresar.Size = new System.Drawing.Size(126, 34);
            this.BotonRegresar.TabIndex = 30;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(368, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "CONSULTA DE PRODUCTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BotonCompra);
            this.panel2.Controls.Add(this.BotonEliminarProducto);
            this.panel2.Controls.Add(this.BotonEditar);
            this.panel2.Controls.Add(this.BotonActualizar);
            this.panel2.Controls.Add(this.CategoriaDropDown);
            this.panel2.Controls.Add(this.CreacionTexto);
            this.panel2.Controls.Add(this.PrecioTexto);
            this.panel2.Controls.Add(this.StockTexto);
            this.panel2.Controls.Add(this.NombreTexto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 512);
            this.panel2.TabIndex = 1;
            // 
            // BotonCompra
            // 
            this.BotonCompra.AutoSize = true;
            this.BotonCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotonCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonCompra.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.BotonCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonCompra.ForeColor = System.Drawing.Color.Black;
            this.BotonCompra.Location = new System.Drawing.Point(23, 381);
            this.BotonCompra.Name = "BotonCompra";
            this.BotonCompra.Size = new System.Drawing.Size(256, 117);
            this.BotonCompra.TabIndex = 32;
            this.BotonCompra.Text = "Agregar a Compra Actual";
            this.BotonCompra.UseVisualStyleBackColor = false;
            this.BotonCompra.Click += new System.EventHandler(this.BotonCompra_Click);
            // 
            // BotonEliminarProducto
            // 
            this.BotonEliminarProducto.AutoSize = true;
            this.BotonEliminarProducto.BackColor = System.Drawing.Color.Red;
            this.BotonEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEliminarProducto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.BotonEliminarProducto.Location = new System.Drawing.Point(851, 452);
            this.BotonEliminarProducto.Name = "BotonEliminarProducto";
            this.BotonEliminarProducto.Size = new System.Drawing.Size(186, 48);
            this.BotonEliminarProducto.TabIndex = 31;
            this.BotonEliminarProducto.Text = "Eliminar Producto";
            this.BotonEliminarProducto.UseVisualStyleBackColor = false;
            this.BotonEliminarProducto.Click += new System.EventHandler(this.BotonEliminarProducto_Click);
            // 
            // BotonEditar
            // 
            this.BotonEditar.AutoSize = true;
            this.BotonEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BotonEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonEditar.ForeColor = System.Drawing.Color.White;
            this.BotonEditar.Location = new System.Drawing.Point(302, 244);
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(337, 48);
            this.BotonEditar.TabIndex = 31;
            this.BotonEditar.Text = "Editar";
            this.BotonEditar.UseVisualStyleBackColor = false;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.AutoSize = true;
            this.BotonActualizar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BotonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonActualizar.ForeColor = System.Drawing.Color.White;
            this.BotonActualizar.Location = new System.Drawing.Point(302, 244);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(337, 48);
            this.BotonActualizar.TabIndex = 31;
            this.BotonActualizar.Text = "Actualizar Informacion";
            this.BotonActualizar.UseVisualStyleBackColor = false;
            this.BotonActualizar.Visible = false;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // CategoriaDropDown
            // 
            this.CategoriaDropDown.Enabled = false;
            this.CategoriaDropDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.CategoriaDropDown.FormattingEnabled = true;
            this.CategoriaDropDown.Location = new System.Drawing.Point(395, 66);
            this.CategoriaDropDown.Name = "CategoriaDropDown";
            this.CategoriaDropDown.Size = new System.Drawing.Size(244, 25);
            this.CategoriaDropDown.TabIndex = 41;
            // 
            // CreacionTexto
            // 
            this.CreacionTexto.Enabled = false;
            this.CreacionTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.CreacionTexto.Location = new System.Drawing.Point(398, 190);
            this.CreacionTexto.Name = "CreacionTexto";
            this.CreacionTexto.Size = new System.Drawing.Size(241, 25);
            this.CreacionTexto.TabIndex = 40;
            // 
            // PrecioTexto
            // 
            this.PrecioTexto.Enabled = false;
            this.PrecioTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.PrecioTexto.Location = new System.Drawing.Point(398, 148);
            this.PrecioTexto.Name = "PrecioTexto";
            this.PrecioTexto.Size = new System.Drawing.Size(241, 25);
            this.PrecioTexto.TabIndex = 39;
            // 
            // StockTexto
            // 
            this.StockTexto.Enabled = false;
            this.StockTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.StockTexto.Location = new System.Drawing.Point(398, 107);
            this.StockTexto.Name = "StockTexto";
            this.StockTexto.Size = new System.Drawing.Size(241, 25);
            this.StockTexto.TabIndex = 38;
            // 
            // NombreTexto
            // 
            this.NombreTexto.Enabled = false;
            this.NombreTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.NombreTexto.Location = new System.Drawing.Point(398, 28);
            this.NombreTexto.Name = "NombreTexto";
            this.NombreTexto.Size = new System.Drawing.Size(241, 25);
            this.NombreTexto.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(286, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Creacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(309, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(315, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // PantallaConsultaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaConsultaProducto";
            this.Text = "PantallaConsultaProducto";
            this.Deactivate += new System.EventHandler(this.ClickFueraDeArea);
            this.Load += new System.EventHandler(this.PantallaConsultaProducto_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreacionTexto;
        private System.Windows.Forms.TextBox PrecioTexto;
        private System.Windows.Forms.TextBox StockTexto;
        private System.Windows.Forms.TextBox NombreTexto;
        private System.Windows.Forms.ComboBox CategoriaDropDown;
        private System.Windows.Forms.Button BotonActualizar;
        private System.Windows.Forms.Button BotonEditar;
        private System.Windows.Forms.Button BotonEliminarProducto;
        private System.Windows.Forms.Button BotonCompra;
    }
}