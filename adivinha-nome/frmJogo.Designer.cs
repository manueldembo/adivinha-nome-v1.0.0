namespace adivinha_nome
{
    partial class frmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblRespostas = new System.Windows.Forms.Label();
            this.picResponder = new System.Windows.Forms.PictureBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.lblOportunidades = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picResponder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResposta
            // 
            this.txtResposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtResposta.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(172, 367);
            this.txtResposta.MaxLength = 30;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(250, 29);
            this.txtResposta.TabIndex = 1;
            // 
            // lblRespostas
            // 
            this.lblRespostas.AutoSize = true;
            this.lblRespostas.BackColor = System.Drawing.Color.Transparent;
            this.lblRespostas.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostas.ForeColor = System.Drawing.Color.White;
            this.lblRespostas.Location = new System.Drawing.Point(449, 23);
            this.lblRespostas.Name = "lblRespostas";
            this.lblRespostas.Size = new System.Drawing.Size(116, 24);
            this.lblRespostas.TabIndex = 3;
            this.lblRespostas.Text = "Respostas: 0";
            // 
            // picResponder
            // 
            this.picResponder.BackColor = System.Drawing.Color.Transparent;
            this.picResponder.Image = global::adivinha_nome.Properties.Resources.responder;
            this.picResponder.Location = new System.Drawing.Point(217, 399);
            this.picResponder.Name = "picResponder";
            this.picResponder.Size = new System.Drawing.Size(150, 50);
            this.picResponder.TabIndex = 2;
            this.picResponder.TabStop = false;
            this.picResponder.Click += new System.EventHandler(this.picResponder_Click);
            this.picResponder.MouseEnter += new System.EventHandler(this.picResponder_MouseEnter);
            this.picResponder.MouseLeave += new System.EventHandler(this.picResponder_MouseLeave);
            // 
            // picImagem
            // 
            this.picImagem.BackColor = System.Drawing.Color.Black;
            this.picImagem.Location = new System.Drawing.Point(87, 70);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(400, 250);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // lblOportunidades
            // 
            this.lblOportunidades.AutoSize = true;
            this.lblOportunidades.BackColor = System.Drawing.Color.Transparent;
            this.lblOportunidades.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOportunidades.ForeColor = System.Drawing.Color.White;
            this.lblOportunidades.Location = new System.Drawing.Point(422, 425);
            this.lblOportunidades.Name = "lblOportunidades";
            this.lblOportunidades.Size = new System.Drawing.Size(150, 24);
            this.lblOportunidades.TabIndex = 4;
            this.lblOportunidades.Text = "Opotunidades: 3";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(121)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblOportunidades);
            this.Controls.Add(this.lblRespostas);
            this.Controls.Add(this.picResponder);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.picImagem);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResponder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.PictureBox picResponder;
        private System.Windows.Forms.Label lblRespostas;
        private System.Windows.Forms.Label lblOportunidades;
    }
}