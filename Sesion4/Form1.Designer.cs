namespace Sesion4
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
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.Aumento = new System.Windows.Forms.Label();
            this.nudAumento = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTecho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(160, 56);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(142, 22);
            this.tbSalario.TabIndex = 1;
            // 
            // Aumento
            // 
            this.Aumento.AutoSize = true;
            this.Aumento.Location = new System.Drawing.Point(85, 111);
            this.Aumento.Name = "Aumento";
            this.Aumento.Size = new System.Drawing.Size(60, 16);
            this.Aumento.TabIndex = 2;
            this.Aumento.Text = "Aumento";
            // 
            // nudAumento
            // 
            this.nudAumento.Location = new System.Drawing.Point(160, 111);
            this.nudAumento.Name = "nudAumento";
            this.nudAumento.Size = new System.Drawing.Size(120, 22);
            this.nudAumento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Techo";
            // 
            // tbTecho
            // 
            this.tbTecho.Location = new System.Drawing.Point(160, 171);
            this.tbTecho.Name = "tbTecho";
            this.tbTecho.Size = new System.Drawing.Size(100, 22);
            this.tbTecho.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTecho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAumento);
            this.Controls.Add(this.Aumento);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label Aumento;
        private System.Windows.Forms.NumericUpDown nudAumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTecho;
    }
}

