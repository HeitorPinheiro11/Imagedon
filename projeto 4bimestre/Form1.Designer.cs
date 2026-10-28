namespace projeto_4bimestre
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                LiberarImagens();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblColorida = new System.Windows.Forms.Label();
            this.picColorida = new System.Windows.Forms.PictureBox();
            this.lblBrilho = new System.Windows.Forms.Label();
            this.picBrilho = new System.Windows.Forms.PictureBox();
            this.lblCinza = new System.Windows.Forms.Label();
            this.picCinza = new System.Windows.Forms.PictureBox();
            this.lblBinaria = new System.Windows.Forms.Label();
            this.picBinaria = new System.Windows.Forms.PictureBox();
            this.lblRotacao = new System.Windows.Forms.Label();
            this.picRotacao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picColorida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrilho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRotacao)).BeginInit();
            this.SuspendLayout();
            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Processamento de imagens";
            // lblInstrucao
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Location = new System.Drawing.Point(20, 48);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Text = "Projeto do 4º bimestre • Introdução à Computação Gráfica";
            // btnProcessar
            this.btnProcessar.Location = new System.Drawing.Point(890, 16);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(210, 44);
            this.btnProcessar.TabIndex = 0;
            this.btnProcessar.Text = "Processar imagens";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = @"Clique em Processar imagens para gerar os resultados em C:\Imagens.";
            // lblColorida
            this.lblColorida.AutoSize = true;
            this.lblColorida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblColorida.Location = new System.Drawing.Point(20, 110);
            this.lblColorida.Name = "lblColorida";
            this.lblColorida.Text = "1. Composição colorida";
            // picColorida
            this.picColorida.BackColor = System.Drawing.Color.White;
            this.picColorida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picColorida.Location = new System.Drawing.Point(20, 134);
            this.picColorida.Name = "picColorida";
            this.picColorida.Size = new System.Drawing.Size(390, 235);
            this.picColorida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picColorida.TabIndex = 1;
            this.picColorida.TabStop = false;
            // lblBrilho
            this.lblBrilho.AutoSize = true;
            this.lblBrilho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBrilho.Location = new System.Drawing.Point(430, 110);
            this.lblBrilho.Name = "lblBrilho";
            this.lblBrilho.Text = "2. Brilho +85";
            // picBrilho
            this.picBrilho.BackColor = System.Drawing.Color.White;
            this.picBrilho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBrilho.Location = new System.Drawing.Point(430, 134);
            this.picBrilho.Name = "picBrilho";
            this.picBrilho.Size = new System.Drawing.Size(390, 235);
            this.picBrilho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBrilho.TabIndex = 2;
            this.picBrilho.TabStop = false;
            // lblCinza
            this.lblCinza.AutoSize = true;
            this.lblCinza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCinza.Location = new System.Drawing.Point(20, 380);
            this.lblCinza.Name = "lblCinza";
            this.lblCinza.Text = "3. Tons de cinza";
            // picCinza
            this.picCinza.BackColor = System.Drawing.Color.White;
            this.picCinza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCinza.Location = new System.Drawing.Point(20, 404);
            this.picCinza.Name = "picCinza";
            this.picCinza.Size = new System.Drawing.Size(390, 235);
            this.picCinza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCinza.TabIndex = 3;
            this.picCinza.TabStop = false;
            // lblBinaria
            this.lblBinaria.AutoSize = true;
            this.lblBinaria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBinaria.Location = new System.Drawing.Point(430, 380);
            this.lblBinaria.Name = "lblBinaria";
            this.lblBinaria.Text = "4. Binária | T = 126";
            // picBinaria
            this.picBinaria.BackColor = System.Drawing.Color.White;
            this.picBinaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBinaria.Location = new System.Drawing.Point(430, 404);
            this.picBinaria.Name = "picBinaria";
            this.picBinaria.Size = new System.Drawing.Size(390, 235);
            this.picBinaria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBinaria.TabIndex = 4;
            this.picBinaria.TabStop = false;
            // lblRotacao
            this.lblRotacao.AutoSize = true;
            this.lblRotacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRotacao.Location = new System.Drawing.Point(840, 110);
            this.lblRotacao.Name = "lblRotacao";
            this.lblRotacao.Text = "5. Cinza transposta";
            // picRotacao
            this.picRotacao.BackColor = System.Drawing.Color.White;
            this.picRotacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRotacao.Location = new System.Drawing.Point(840, 134);
            this.picRotacao.Name = "picRotacao";
            this.picRotacao.Size = new System.Drawing.Size(260, 505);
            this.picRotacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRotacao.TabIndex = 5;
            this.picRotacao.TabStop = false;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 656);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.picRotacao);
            this.Controls.Add(this.lblRotacao);
            this.Controls.Add(this.picBinaria);
            this.Controls.Add(this.lblBinaria);
            this.Controls.Add(this.picCinza);
            this.Controls.Add(this.lblCinza);
            this.Controls.Add(this.picBrilho);
            this.Controls.Add(this.lblBrilho);
            this.Controls.Add(this.picColorida);
            this.Controls.Add(this.lblColorida);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 4º bimestre - Processamento de imagens";
            ((System.ComponentModel.ISupportInitialize)(this.picColorida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBrilho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCinza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRotacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblColorida;
        private System.Windows.Forms.PictureBox picColorida;
        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.PictureBox picBrilho;
        private System.Windows.Forms.Label lblCinza;
        private System.Windows.Forms.PictureBox picCinza;
        private System.Windows.Forms.Label lblBinaria;
        private System.Windows.Forms.PictureBox picBinaria;
        private System.Windows.Forms.Label lblRotacao;
        private System.Windows.Forms.PictureBox picRotacao;
    }
}
