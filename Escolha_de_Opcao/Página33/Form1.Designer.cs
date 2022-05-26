namespace Página33
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
            this.lblEscreverONumero = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.optionA = new System.Windows.Forms.RadioButton();
            this.optionB = new System.Windows.Forms.RadioButton();
            this.optionC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblEscreverONumero
            // 
            this.lblEscreverONumero.AutoSize = true;
            this.lblEscreverONumero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscreverONumero.Location = new System.Drawing.Point(53, 308);
            this.lblEscreverONumero.Name = "lblEscreverONumero";
            this.lblEscreverONumero.Size = new System.Drawing.Size(173, 24);
            this.lblEscreverONumero.TabIndex = 7;
            this.lblEscreverONumero.Text = "Escolha a opção.";
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.LightCoral;
            this.btnExibir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.Location = new System.Drawing.Point(47, 236);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(191, 34);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha 1 opção:";
            // 
            // optionA
            // 
            this.optionA.AutoSize = true;
            this.optionA.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionA.Location = new System.Drawing.Point(31, 120);
            this.optionA.Name = "optionA";
            this.optionA.Size = new System.Drawing.Size(83, 21);
            this.optionA.TabIndex = 8;
            this.optionA.TabStop = true;
            this.optionA.Text = "Opção A";
            this.optionA.UseVisualStyleBackColor = true;
            this.optionA.CheckedChanged += new System.EventHandler(this.optionA_CheckedChanged);
            // 
            // optionB
            // 
            this.optionB.AutoSize = true;
            this.optionB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionB.Location = new System.Drawing.Point(31, 154);
            this.optionB.Name = "optionB";
            this.optionB.Size = new System.Drawing.Size(84, 21);
            this.optionB.TabIndex = 9;
            this.optionB.TabStop = true;
            this.optionB.Text = "Opção B";
            this.optionB.UseVisualStyleBackColor = true;
            // 
            // optionC
            // 
            this.optionC.AutoSize = true;
            this.optionC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionC.Location = new System.Drawing.Point(31, 188);
            this.optionC.Name = "optionC";
            this.optionC.Size = new System.Drawing.Size(85, 21);
            this.optionC.TabIndex = 10;
            this.optionC.TabStop = true;
            this.optionC.Text = "Opção C";
            this.optionC.UseVisualStyleBackColor = true;
            this.optionC.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(304, 450);
            this.Controls.Add(this.optionC);
            this.Controls.Add(this.optionB);
            this.Controls.Add(this.optionA);
            this.Controls.Add(this.lblEscreverONumero);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscreverONumero;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optionA;
        private System.Windows.Forms.RadioButton optionB;
        private System.Windows.Forms.RadioButton optionC;
    }
}

