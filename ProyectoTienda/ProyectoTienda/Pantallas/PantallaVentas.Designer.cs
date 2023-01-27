
namespace ProyectoTienda.Pantallas
{
    partial class PantallaVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.VentasTitulo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VentasTabla = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalVentasTexto = new System.Windows.Forms.TextBox();
            this.PanelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.Controls.Add(this.VentasTitulo);
            this.PanelTitulo.Controls.Add(this.Titulo);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1399, 70);
            this.PanelTitulo.TabIndex = 3;
            // 
            // VentasTitulo
            // 
            this.VentasTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VentasTitulo.AutoSize = true;
            this.VentasTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.VentasTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.VentasTitulo.Location = new System.Drawing.Point(608, 28);
            this.VentasTitulo.Name = "VentasTitulo";
            this.VentasTitulo.Size = new System.Drawing.Size(96, 24);
            this.VentasTitulo.TabIndex = 1;
            this.VentasTitulo.Text = "VENTAS";
            this.VentasTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Titulo
            // 
            this.Titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 23);
            this.Titulo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.TotalVentasTexto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VentasTabla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 760);
            this.panel1.TabIndex = 4;
            // 
            // VentasTabla
            // 
            this.VentasTabla.AllowUserToAddRows = false;
            this.VentasTabla.AllowUserToDeleteRows = false;
            this.VentasTabla.AllowUserToResizeColumns = false;
            this.VentasTabla.AllowUserToResizeRows = false;
            this.VentasTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VentasTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.VentasTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VentasTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentasTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.VentasTabla.ColumnHeadersHeight = 50;
            this.VentasTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.VentasTabla.EnableHeadersVisualStyles = false;
            this.VentasTabla.GridColor = System.Drawing.Color.SteelBlue;
            this.VentasTabla.Location = new System.Drawing.Point(114, 82);
            this.VentasTabla.Name = "VentasTabla";
            this.VentasTabla.ReadOnly = true;
            this.VentasTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VentasTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.VentasTabla.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.VentasTabla.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.VentasTabla.RowTemplate.Height = 40;
            this.VentasTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.VentasTabla.Size = new System.Drawing.Size(1008, 631);
            this.VentasTabla.TabIndex = 3;
            this.VentasTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VentasTabla_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(453, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "REPORTE DE VENTAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1169, 236);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "TOTAL DE VENTAS";
            // 
            // TotalVentasTexto
            // 
            this.TotalVentasTexto.Enabled = false;
            this.TotalVentasTexto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.TotalVentasTexto.Location = new System.Drawing.Point(1146, 275);
            this.TotalVentasTexto.Name = "TotalVentasTexto";
            this.TotalVentasTexto.Size = new System.Drawing.Size(241, 25);
            this.TotalVentasTexto.TabIndex = 23;
            // 
            // PantallaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 830);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaVentas";
            this.Text = "PantallaVentas";
            this.Load += new System.EventHandler(this.PantallaVentas_Load);
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentasTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label VentasTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView VentasTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalVentasTexto;
    }
}