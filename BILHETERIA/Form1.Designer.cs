
namespace BILHETERIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCartaz = new System.Windows.Forms.ListBox();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.numericUpDownMeia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInteira = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.listBoxSessoes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteira)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCartaz
            // 
            this.listBoxCartaz.FormattingEnabled = true;
            this.listBoxCartaz.ItemHeight = 15;
            this.listBoxCartaz.Location = new System.Drawing.Point(12, 12);
            this.listBoxCartaz.Name = "listBoxCartaz";
            this.listBoxCartaz.Size = new System.Drawing.Size(369, 274);
            this.listBoxCartaz.TabIndex = 0;
            this.listBoxCartaz.SelectedIndexChanged += new System.EventHandler(this.listBoxCartaz_SelectedIndexChanged);
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(285, 329);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 1;
            this.buttonComprar.Text = "COMPRAR";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // numericUpDownMeia
            // 
            this.numericUpDownMeia.Location = new System.Drawing.Point(72, 314);
            this.numericUpDownMeia.Name = "numericUpDownMeia";
            this.numericUpDownMeia.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownMeia.TabIndex = 2;
            this.numericUpDownMeia.ValueChanged += new System.EventHandler(this.numericUpDownMeia_ValueChanged);
            // 
            // numericUpDownInteira
            // 
            this.numericUpDownInteira.Location = new System.Drawing.Point(72, 343);
            this.numericUpDownInteira.Name = "numericUpDownInteira";
            this.numericUpDownInteira.Size = new System.Drawing.Size(68, 23);
            this.numericUpDownInteira.TabIndex = 3;
            this.numericUpDownInteira.ValueChanged += new System.EventHandler(this.numericUpDownInteira_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESSOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "MEIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "INTEIRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "R$ 16,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "R$ 32,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(212, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "SUBTOTAL";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotal.Location = new System.Drawing.Point(212, 341);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(63, 20);
            this.labelSubtotal.TabIndex = 10;
            this.labelSubtotal.Text = "R$ 0,00";
            // 
            // listBoxSessoes
            // 
            this.listBoxSessoes.FormattingEnabled = true;
            this.listBoxSessoes.ItemHeight = 15;
            this.listBoxSessoes.Location = new System.Drawing.Point(387, 12);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(143, 274);
            this.listBoxSessoes.TabIndex = 11;
            this.listBoxSessoes.SelectedIndexChanged += new System.EventHandler(this.listBoxSessoes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 382);
            this.Controls.Add(this.listBoxSessoes);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownInteira);
            this.Controls.Add(this.numericUpDownMeia);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.listBoxCartaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCartaz;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.NumericUpDown numericUpDownMeia;
        private System.Windows.Forms.NumericUpDown numericUpDownInteira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.ListBox listBoxSessoes;
    }
}

