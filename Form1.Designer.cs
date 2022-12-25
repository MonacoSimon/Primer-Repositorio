
namespace ManejoExcepciones
{
    partial class FSuma
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
            this.lblSuma = new System.Windows.Forms.Label();
            this.txtboxPrimerNumero = new System.Windows.Forms.TextBox();
            this.txtBoxSegundoNumero = new System.Windows.Forms.TextBox();
            this.btResultado = new System.Windows.Forms.Button();
            this.lblPrimerNumero = new System.Windows.Forms.Label();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(26, 26);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(111, 13);
            this.lblSuma.TabIndex = 0;
            this.lblSuma.Text = "Ingrese dos numeros: ";
            // 
            // txtboxPrimerNumero
            // 
            this.txtboxPrimerNumero.Location = new System.Drawing.Point(183, 65);
            this.txtboxPrimerNumero.Name = "txtboxPrimerNumero";
            this.txtboxPrimerNumero.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrimerNumero.TabIndex = 1;
            // 
            // txtBoxSegundoNumero
            // 
            this.txtBoxSegundoNumero.Location = new System.Drawing.Point(183, 139);
            this.txtBoxSegundoNumero.Name = "txtBoxSegundoNumero";
            this.txtBoxSegundoNumero.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSegundoNumero.TabIndex = 2;
            // 
            // btResultado
            // 
            this.btResultado.Location = new System.Drawing.Point(32, 222);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(75, 23);
            this.btResultado.TabIndex = 3;
            this.btResultado.Text = "Resultado";
            this.btResultado.UseVisualStyleBackColor = true;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // lblPrimerNumero
            // 
            this.lblPrimerNumero.AutoSize = true;
            this.lblPrimerNumero.Location = new System.Drawing.Point(29, 71);
            this.lblPrimerNumero.Name = "lblPrimerNumero";
            this.lblPrimerNumero.Size = new System.Drawing.Size(82, 13);
            this.lblPrimerNumero.TabIndex = 4;
            this.lblPrimerNumero.Text = "Primer Numero: ";
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(32, 145);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(96, 13);
            this.lblSegundoNumero.TabIndex = 5;
            this.lblSegundoNumero.Text = "Segundo Numero: ";
            // 
            // FSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 341);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.lblPrimerNumero);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.txtBoxSegundoNumero);
            this.Controls.Add(this.txtboxPrimerNumero);
            this.Controls.Add(this.lblSuma);
            this.Name = "FSuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TextBox txtboxPrimerNumero;
        private System.Windows.Forms.TextBox txtBoxSegundoNumero;
        private System.Windows.Forms.Button btResultado;
        private System.Windows.Forms.Label lblPrimerNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
    }
}

