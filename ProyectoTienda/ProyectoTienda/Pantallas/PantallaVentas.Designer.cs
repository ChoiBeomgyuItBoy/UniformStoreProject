
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
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.VentasTitulo = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelTitulo.SuspendLayout();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 760);
            this.panel1.TabIndex = 4;
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
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Label VentasTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
    }
}