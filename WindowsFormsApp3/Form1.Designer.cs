namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.TextBox();
            this.lblKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(225, 166);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "btnConverter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(88, 166);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 22);
            this.txtCelsius.TabIndex = 1;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.Location = new System.Drawing.Point(88, 218);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(362, 22);
            this.lblFahrenheit.TabIndex = 2;
            // 
            // lblKelvin
            // 
            this.lblKelvin.Location = new System.Drawing.Point(88, 264);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(362, 22);
            this.lblKelvin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox lblFahrenheit;
        private System.Windows.Forms.TextBox lblKelvin;
    }
}

