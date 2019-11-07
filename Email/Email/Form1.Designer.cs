namespace Email
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
            this.BtnFrase = new System.Windows.Forms.Button();
            this.BtnHtml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFrase
            // 
            this.BtnFrase.Location = new System.Drawing.Point(39, 53);
            this.BtnFrase.Name = "BtnFrase";
            this.BtnFrase.Size = new System.Drawing.Size(109, 49);
            this.BtnFrase.TabIndex = 0;
            this.BtnFrase.Text = "Enviar Frase";
            this.BtnFrase.UseVisualStyleBackColor = true;
            this.BtnFrase.Click += new System.EventHandler(this.BtnFrase_Click);
            // 
            // BtnHtml
            // 
            this.BtnHtml.Location = new System.Drawing.Point(39, 121);
            this.BtnHtml.Name = "BtnHtml";
            this.BtnHtml.Size = new System.Drawing.Size(109, 49);
            this.BtnHtml.TabIndex = 1;
            this.BtnHtml.Text = "Enviar HTML";
            this.BtnHtml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 237);
            this.Controls.Add(this.BtnHtml);
            this.Controls.Add(this.BtnFrase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-mail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFrase;
        private System.Windows.Forms.Button BtnHtml;
    }
}

