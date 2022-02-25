
namespace Semafaro
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
            this.pictureBoxPedestre = new System.Windows.Forms.PictureBox();
            this.pictureBoxVerdeAcesso = new System.Windows.Forms.PictureBox();
            this.pictureBoxAmarelo = new System.Windows.Forms.PictureBox();
            this.pictureBoxVermelhoA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPedestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdeAcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVermelhoA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPedestre
            // 
            this.pictureBoxPedestre.Image = global::Semafaro.Properties.Resources.ped_vermelho;
            this.pictureBoxPedestre.Location = new System.Drawing.Point(349, 13);
            this.pictureBoxPedestre.Name = "pictureBoxPedestre";
            this.pictureBoxPedestre.Size = new System.Drawing.Size(262, 434);
            this.pictureBoxPedestre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPedestre.TabIndex = 3;
            this.pictureBoxPedestre.TabStop = false;
            // 
            // pictureBoxVerdeAcesso
            // 
            this.pictureBoxVerdeAcesso.Image = global::Semafaro.Properties.Resources.verde_aceso;
            this.pictureBoxVerdeAcesso.Location = new System.Drawing.Point(63, 306);
            this.pictureBoxVerdeAcesso.Name = "pictureBoxVerdeAcesso";
            this.pictureBoxVerdeAcesso.Size = new System.Drawing.Size(154, 141);
            this.pictureBoxVerdeAcesso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVerdeAcesso.TabIndex = 2;
            this.pictureBoxVerdeAcesso.TabStop = false;
            // 
            // pictureBoxAmarelo
            // 
            this.pictureBoxAmarelo.Image = global::Semafaro.Properties.Resources.amarelo;
            this.pictureBoxAmarelo.Location = new System.Drawing.Point(63, 159);
            this.pictureBoxAmarelo.Name = "pictureBoxAmarelo";
            this.pictureBoxAmarelo.Size = new System.Drawing.Size(154, 141);
            this.pictureBoxAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAmarelo.TabIndex = 1;
            this.pictureBoxAmarelo.TabStop = false;
            // 
            // pictureBoxVermelhoA
            // 
            this.pictureBoxVermelhoA.Image = global::Semafaro.Properties.Resources.vermelho;
            this.pictureBoxVermelhoA.Location = new System.Drawing.Point(63, 12);
            this.pictureBoxVermelhoA.Name = "pictureBoxVermelhoA";
            this.pictureBoxVermelhoA.Size = new System.Drawing.Size(154, 141);
            this.pictureBoxVermelhoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVermelhoA.TabIndex = 0;
            this.pictureBoxVermelhoA.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 470);
            this.Controls.Add(this.pictureBoxPedestre);
            this.Controls.Add(this.pictureBoxVerdeAcesso);
            this.Controls.Add(this.pictureBoxAmarelo);
            this.Controls.Add(this.pictureBoxVermelhoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPedestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdeAcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVermelhoA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVermelhoA;
        private System.Windows.Forms.PictureBox pictureBoxAmarelo;
        private System.Windows.Forms.PictureBox pictureBoxVerdeAcesso;
        private System.Windows.Forms.PictureBox pictureBoxPedestre;
    }
}

