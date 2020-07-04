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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnFrase = new System.Windows.Forms.Button();
            this.BtnHtml = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatatio = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnTexto = new System.Windows.Forms.Button();
            this.lblEnviarMsgPronta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfiguracaoPessoal = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.txtEmailPessoal = new System.Windows.Forms.TextBox();
            this.lblConfEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFrase
            // 
            this.BtnFrase.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFrase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFrase.ForeColor = System.Drawing.Color.White;
            this.BtnFrase.Location = new System.Drawing.Point(29, 585);
            this.BtnFrase.Name = "BtnFrase";
            this.BtnFrase.Size = new System.Drawing.Size(109, 49);
            this.BtnFrase.TabIndex = 0;
            this.BtnFrase.Text = "Enviar frase pronta";
            this.BtnFrase.UseVisualStyleBackColor = false;
            this.BtnFrase.Click += new System.EventHandler(this.BtnFrase_Click);
            // 
            // BtnHtml
            // 
            this.BtnHtml.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnHtml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnHtml.ForeColor = System.Drawing.Color.White;
            this.BtnHtml.Location = new System.Drawing.Point(160, 585);
            this.BtnHtml.Name = "BtnHtml";
            this.BtnHtml.Size = new System.Drawing.Size(109, 49);
            this.BtnHtml.TabIndex = 1;
            this.BtnHtml.Text = "Enviar HTML";
            this.BtnHtml.UseVisualStyleBackColor = false;
            this.BtnHtml.Click += new System.EventHandler(this.BtnHtml_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(126, 10);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(66, 62);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloForm.Location = new System.Drawing.Point(36, 77);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(245, 22);
            this.lblTituloForm.TabIndex = 3;
            this.lblTituloForm.Text = "Enviar e-mail diretamente do C#";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblDestinatario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDestinatario.Location = new System.Drawing.Point(40, 264);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(78, 17);
            this.lblDestinatario.TabIndex = 4;
            this.lblDestinatario.Text = "Destinatário";
            this.lblDestinatario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDestinatatio
            // 
            this.txtDestinatatio.BackColor = System.Drawing.Color.White;
            this.txtDestinatatio.Location = new System.Drawing.Point(42, 283);
            this.txtDestinatatio.Name = "txtDestinatatio";
            this.txtDestinatatio.Size = new System.Drawing.Size(226, 20);
            this.txtDestinatatio.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(43, 334);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(226, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Location = new System.Drawing.Point(41, 315);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 17);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.White;
            this.txtMensagem.Location = new System.Drawing.Point(42, 386);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(226, 84);
            this.txtMensagem.TabIndex = 9;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblMensagem.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMensagem.Location = new System.Drawing.Point(40, 367);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(71, 17);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTexto
            // 
            this.btnTexto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTexto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTexto.ForeColor = System.Drawing.Color.White;
            this.btnTexto.Location = new System.Drawing.Point(105, 479);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(88, 31);
            this.btnTexto.TabIndex = 10;
            this.btnTexto.Text = "Enviar";
            this.btnTexto.UseVisualStyleBackColor = false;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // lblEnviarMsgPronta
            // 
            this.lblEnviarMsgPronta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEnviarMsgPronta.AutoSize = true;
            this.lblEnviarMsgPronta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblEnviarMsgPronta.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviarMsgPronta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEnviarMsgPronta.Location = new System.Drawing.Point(73, 542);
            this.lblEnviarMsgPronta.Name = "lblEnviarMsgPronta";
            this.lblEnviarMsgPronta.Size = new System.Drawing.Size(159, 13);
            this.lblEnviarMsgPronta.TabIndex = 11;
            this.lblEnviarMsgPronta.Text = "Ou envie mensagem uma pronta";
            this.lblEnviarMsgPronta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(2, 558);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 2);
            this.label6.TabIndex = 12;
            // 
            // lblCredito
            // 
            this.lblCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCredito.AutoSize = true;
            this.lblCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblCredito.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCredito.Location = new System.Drawing.Point(168, 665);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(129, 13);
            this.lblCredito.TabIndex = 13;
            this.lblCredito.Text = "Keven Baraúna - Nov 2019";
            this.lblCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(11, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 2);
            this.label1.TabIndex = 15;
            // 
            // lblConfiguracaoPessoal
            // 
            this.lblConfiguracaoPessoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblConfiguracaoPessoal.AutoSize = true;
            this.lblConfiguracaoPessoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblConfiguracaoPessoal.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracaoPessoal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConfiguracaoPessoal.Location = new System.Drawing.Point(110, 114);
            this.lblConfiguracaoPessoal.Name = "lblConfiguracaoPessoal";
            this.lblConfiguracaoPessoal.Size = new System.Drawing.Size(97, 13);
            this.lblConfiguracaoPessoal.TabIndex = 14;
            this.lblConfiguracaoPessoal.Text = "Suas configurações";
            this.lblConfiguracaoPessoal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.BackColor = System.Drawing.Color.White;
            this.txtConfSenha.Location = new System.Drawing.Point(43, 213);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(226, 20);
            this.txtConfSenha.TabIndex = 19;
            this.txtConfSenha.UseSystemPasswordChar = true;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblConfSenha.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConfSenha.Location = new System.Drawing.Point(41, 194);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(64, 17);
            this.lblConfSenha.TabIndex = 18;
            this.lblConfSenha.Text = "Sua senha";
            this.lblConfSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmailPessoal
            // 
            this.txtEmailPessoal.BackColor = System.Drawing.Color.White;
            this.txtEmailPessoal.Location = new System.Drawing.Point(42, 162);
            this.txtEmailPessoal.Name = "txtEmailPessoal";
            this.txtEmailPessoal.Size = new System.Drawing.Size(226, 20);
            this.txtEmailPessoal.TabIndex = 17;
            // 
            // lblConfEmail
            // 
            this.lblConfEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblConfEmail.AutoSize = true;
            this.lblConfEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lblConfEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConfEmail.Location = new System.Drawing.Point(40, 143);
            this.lblConfEmail.Name = "lblConfEmail";
            this.lblConfEmail.Size = new System.Drawing.Size(66, 17);
            this.lblConfEmail.TabIndex = 16;
            this.lblConfEmail.Text = "Seu E-mail";
            this.lblConfEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(9, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 2);
            this.label4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 687);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.txtEmailPessoal);
            this.Controls.Add(this.lblConfEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfiguracaoPessoal);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEnviarMsgPronta);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtDestinatatio);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.lblTituloForm);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.BtnHtml);
            this.Controls.Add(this.BtnFrase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-mail";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFrase;
        private System.Windows.Forms.Button BtnHtml;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtDestinatatio;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Label lblEnviarMsgPronta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfiguracaoPessoal;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.TextBox txtEmailPessoal;
        private System.Windows.Forms.Label lblConfEmail;
        private System.Windows.Forms.Label label4;
    }
}

