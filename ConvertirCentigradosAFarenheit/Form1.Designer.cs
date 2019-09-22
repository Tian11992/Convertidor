namespace ConvertirCentigradosAFarenheit
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconvertir = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertidor";
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(299, 176);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(129, 33);
            this.btnconvertir.TabIndex = 1;
            this.btnconvertir.Text = "Convertir";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese los grados centigrados para convertirlos en fahrenheit";
            // 
            // txtconvertir
            // 
            this.txtconvertir.Location = new System.Drawing.Point(507, 121);
            this.txtconvertir.Name = "txtconvertir";
            this.txtconvertir.Size = new System.Drawing.Size(100, 20);
            this.txtconvertir.TabIndex = 3;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(141, 320);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(82, 20);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtconvertir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconvertir;
        private System.Windows.Forms.Label lblresultado;
    }
}

