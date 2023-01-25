
namespace ProyectoTienda.Pantallas
{
    partial class PantallaInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.ClientesTitulo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonFiltrarCategoria = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoriaFiltroDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BotonCrear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioTexto = new System.Windows.Forms.TextBox();
            this.StockTexto = new System.Windows.Forms.TextBox();
            this.CategoriaDropDown = new System.Windows.Forms.ComboBox();
            this.NombreTexto = new System.Windows.Forms.TextBox();
            this.InventarioTabla = new System.Windows.Forms.DataGridView();
            this.PanelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.ClientesTitulo);
            this.PanelTitulo.Controls.Add(this.Titulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1353, 70);
            this.PanelTitulo.TabIndex = 1;
            // 
            // ClientesTitulo
            // 
            this.ClientesTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClientesTitulo.AutoSize = true;
            this.ClientesTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.ClientesTitulo.Location = new System.Drawing.Point(585, 28);
            this.ClientesTitulo.Name = "ClientesTitulo";
            this.ClientesTitulo.Size = new System.Drawing.Size(144, 24);
            this.ClientesTitulo.TabIndex = 1;
            this.ClientesTitulo.Text = "INVENTARIO";
            this.ClientesTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 23);
            this.Titulo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.BotonFiltrarCategoria);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CategoriaFiltroDropDown);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BotonCrear);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrecioTexto);
            this.panel1.Controls.Add(this.StockTexto);
            this.panel1.Controls.Add(this.CategoriaDropDown);
            this.panel1.Controls.Add(this.NombreTexto);
            this.panel1.Controls.Add(this.InventarioTabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 749);
            this.panel1.TabIndex = 2;
            // 
            // BotonFiltrarCategoria
            // 
            this.BotonFiltrarCategoria.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BotonFiltrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonFiltrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonFiltrarCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonFiltrarCategoria.ForeColor = System.Drawing.Color.White;
            this.BotonFiltrarCategoria.Location = new System.Drawing.Point(905, 195);
            this.BotonFiltrarCategoria.Name = "BotonFiltrarCategoria";
            this.BotonFiltrarCategoria.Size = new System.Drawing.Size(337, 48);
            this.BotonFiltrarCategoria.TabIndex = 29;
            this.BotonFiltrarCategoria.Text = "Filtrar";
            this.BotonFiltrarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonFiltrarCategoria.UseVisualStyleBackColor = false;
            this.BotonFiltrarCategoria.Click += new System.EventHandler(this.BotonFiltrarCategoria_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(878, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Categoria ";
            // 
            // CategoriaFiltroDropDown
            // 
            this.CategoriaFiltroDropDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.CategoriaFiltroDropDown.FormattingEnabled = true;
            this.CategoriaFiltroDropDown.Location = new System.Drawing.Point(994, 150);
            this.CategoriaFiltroDropDown.Name = "CategoriaFiltroDropDown";
            this.CategoriaFiltroDropDown.Size = new System.Drawing.Size(244, 25);
            this.CategoriaFiltroDropDown.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(940, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "FILTRAR POR CATEGORIA";
            // 
            // BotonCrear
            // 
            this.BotonCrear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BotonCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BotonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCrear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.BotonCrear.ForeColor = System.Drawing.Color.White;
            this.BotonCrear.Location = new System.Drawing.Point(904, 574);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(337, 48);
            this.BotonCrear.TabIndex = 20;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = false;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(901, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(907, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Stock *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(870, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Categoria *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(887, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(973, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "NUEVO PRODUCTO";
            // 
            // PrecioTexto
            // 
            this.PrecioTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.PrecioTexto.Location = new System.Drawing.Point(997, 521);
            this.PrecioTexto.Name = "PrecioTexto";
            this.PrecioTexto.Size = new System.Drawing.Size(241, 25);
            this.PrecioTexto.TabIndex = 22;
            // 
            // StockTexto
            // 
            this.StockTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.StockTexto.Location = new System.Drawing.Point(997, 475);
            this.StockTexto.Name = "StockTexto";
            this.StockTexto.Size = new System.Drawing.Size(241, 25);
            this.StockTexto.TabIndex = 21;
            // 
            // CategoriaDropDown
            // 
            this.CategoriaDropDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.CategoriaDropDown.FormattingEnabled = true;
            this.CategoriaDropDown.Location = new System.Drawing.Point(997, 424);
            this.CategoriaDropDown.Name = "CategoriaDropDown";
            this.CategoriaDropDown.Size = new System.Drawing.Size(244, 25);
            this.CategoriaDropDown.TabIndex = 20;
            // 
            // NombreTexto
            // 
            this.NombreTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.NombreTexto.Location = new System.Drawing.Point(997, 376);
            this.NombreTexto.Name = "NombreTexto";
            this.NombreTexto.Size = new System.Drawing.Size(241, 25);
            this.NombreTexto.TabIndex = 20;
            // 
            // InventarioTabla
            // 
            this.InventarioTabla.AllowUserToAddRows = false;
            this.InventarioTabla.AllowUserToDeleteRows = false;
            this.InventarioTabla.AllowUserToResizeColumns = false;
            this.InventarioTabla.AllowUserToResizeRows = false;
            this.InventarioTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventarioTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.InventarioTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InventarioTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventarioTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.InventarioTabla.ColumnHeadersHeight = 50;
            this.InventarioTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InventarioTabla.EnableHeadersVisualStyles = false;
            this.InventarioTabla.GridColor = System.Drawing.Color.SteelBlue;
            this.InventarioTabla.Location = new System.Drawing.Point(113, 150);
            this.InventarioTabla.Name = "InventarioTabla";
            this.InventarioTabla.ReadOnly = true;
            this.InventarioTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventarioTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InventarioTabla.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.InventarioTabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InventarioTabla.RowTemplate.Height = 40;
            this.InventarioTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.InventarioTabla.Size = new System.Drawing.Size(629, 472);
            this.InventarioTabla.TabIndex = 3;
            this.InventarioTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventarioTabla_CellContentClick);
            // 
            // PantallaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 819);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaInventario";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaInventario_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioTabla)).EndInit();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.PantallaInventario_Load);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label ClientesTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InventarioTabla;
        private System.Windows.Forms.TextBox NombreTexto;
        private System.Windows.Forms.TextBox StockTexto;
        private System.Windows.Forms.ComboBox CategoriaDropDown;
        private System.Windows.Forms.TextBox PrecioTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonCrear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CategoriaFiltroDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BotonFiltrarCategoria;
    }
}