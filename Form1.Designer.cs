namespace PruebasGiT
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.TextBox();
            this.ClaveComprobación = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(12, 26);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(100, 20);
            this.Cedula.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(12, 52);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 2;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(12, 78);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 3;
            // 
            // Clave
            // 
            this.Clave.Location = new System.Drawing.Point(12, 104);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(100, 20);
            this.Clave.TabIndex = 4;
            // 
            // ClaveComprobación
            // 
            this.ClaveComprobación.Location = new System.Drawing.Point(12, 130);
            this.ClaveComprobación.Name = "ClaveComprobación";
            this.ClaveComprobación.Size = new System.Drawing.Size(100, 20);
            this.ClaveComprobación.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClaveComprobación);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.TextBox ClaveComprobación;
    }
}

