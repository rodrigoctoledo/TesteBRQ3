namespace WindowsFormsApp1
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
            this.textBoxVar = new System.Windows.Forms.TextBox();
            this.buttonVeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxVar
            // 
            this.textBoxVar.Location = new System.Drawing.Point(128, 26);
            this.textBoxVar.Name = "textBoxVar";
            this.textBoxVar.Size = new System.Drawing.Size(100, 22);
            this.textBoxVar.TabIndex = 0;
            this.textBoxVar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonVeri
            // 
            this.buttonVeri.Location = new System.Drawing.Point(261, 25);
            this.buttonVeri.Name = "buttonVeri";
            this.buttonVeri.Size = new System.Drawing.Size(75, 23);
            this.buttonVeri.TabIndex = 1;
            this.buttonVeri.Text = "Calc";
            this.buttonVeri.UseVisualStyleBackColor = true;
            this.buttonVeri.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira um valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVeri);
            this.Controls.Add(this.textBoxVar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVar;
        private System.Windows.Forms.Button buttonVeri;
        private System.Windows.Forms.Label label1;
    }
}

