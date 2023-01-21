
namespace ProyectoTienda.Pantallas
{
    partial class PantallaLogin
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
            this.GerenteUsuarioLabel = new System.Windows.Forms.Label();
            this.GerenteContraseñaLabel = new System.Windows.Forms.Label();
            this.UsuarioInput = new System.Windows.Forms.TextBox();
            this.ContraseñaInput = new System.Windows.Forms.TextBox();
            this.BotonAcceso = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GerenteUsuarioLabel
            // 
            this.GerenteUsuarioLabel.AutoSize = true;
            this.GerenteUsuarioLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerenteUsuarioLabel.Location = new System.Drawing.Point(179, 170);
            this.GerenteUsuarioLabel.Name = "GerenteUsuarioLabel";
            this.GerenteUsuarioLabel.Size = new System.Drawing.Size(177, 24);
            this.GerenteUsuarioLabel.TabIndex = 0;
            this.GerenteUsuarioLabel.Text = "Gerente Usuario";
            // 
            // GerenteContraseñaLabel
            // 
            this.GerenteContraseñaLabel.AutoSize = true;
            this.GerenteContraseñaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GerenteContraseñaLabel.Location = new System.Drawing.Point(179, 221);
            this.GerenteContraseñaLabel.Name = "GerenteContraseñaLabel";
            this.GerenteContraseñaLabel.Size = new System.Drawing.Size(215, 24);
            this.GerenteContraseñaLabel.TabIndex = 1;
            this.GerenteContraseñaLabel.Text = "Gerente Contraseña";
            // 
            // UsuarioInput
            // 
            this.UsuarioInput.Location = new System.Drawing.Point(406, 170);
            this.UsuarioInput.Name = "UsuarioInput";
            this.UsuarioInput.Size = new System.Drawing.Size(213, 20);
            this.UsuarioInput.TabIndex = 2;
            this.UsuarioInput.TextChanged += new System.EventHandler(this.UsuarioInput_TextChanged);
            // 
            // ContraseñaInput
            // 
            this.ContraseñaInput.Location = new System.Drawing.Point(406, 221);
            this.ContraseñaInput.Name = "ContraseñaInput";
            this.ContraseñaInput.Size = new System.Drawing.Size(213, 20);
            this.ContraseñaInput.TabIndex = 3;
            this.ContraseñaInput.TextChanged += new System.EventHandler(this.ContraseñaInput_TextChanged);
            // 
            // BotonAcceso
            // 
            this.BotonAcceso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAcceso.Location = new System.Drawing.Point(355, 293);
            this.BotonAcceso.Name = "BotonAcceso";
            this.BotonAcceso.Size = new System.Drawing.Size(127, 40);
            this.BotonAcceso.TabIndex = 4;
            this.BotonAcceso.Text = "Entrar";
            this.BotonAcceso.UseVisualStyleBackColor = true;
            this.BotonAcceso.Click += new System.EventHandler(this.BotonAcceso_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalir.Location = new System.Drawing.Point(12, 398);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(127, 40);
            this.BotonSalir.TabIndex = 5;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonAcceso);
            this.Controls.Add(this.ContraseñaInput);
            this.Controls.Add(this.UsuarioInput);
            this.Controls.Add(this.GerenteContraseñaLabel);
            this.Controls.Add(this.GerenteUsuarioLabel);
            this.Name = "PantallaLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GerenteUsuarioLabel;
        private System.Windows.Forms.Label GerenteContraseñaLabel;
        private System.Windows.Forms.TextBox UsuarioInput;
        private System.Windows.Forms.TextBox ContraseñaInput;
        private System.Windows.Forms.Button BotonAcceso;
        private System.Windows.Forms.Button BotonSalir;
    }
}

