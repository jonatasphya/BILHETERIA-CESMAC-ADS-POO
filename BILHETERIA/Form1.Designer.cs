
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageComprar = new System.Windows.Forms.TabPage();
            this.tabPage_recibo = new System.Windows.Forms.TabPage();
            this.textBoxRecibo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteira)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageComprar.SuspendLayout();
            this.tabPage_recibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCartaz
            // 
            this.listBoxCartaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listBoxCartaz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCartaz.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxCartaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBoxCartaz.FormattingEnabled = true;
            this.listBoxCartaz.ItemHeight = 17;
            this.listBoxCartaz.Location = new System.Drawing.Point(6, 6);
            this.listBoxCartaz.Name = "listBoxCartaz";
            this.listBoxCartaz.Size = new System.Drawing.Size(421, 272);
            this.listBoxCartaz.TabIndex = 0;
            this.listBoxCartaz.SelectedIndexChanged += new System.EventHandler(this.listBoxCartaz_SelectedIndexChanged);
            // 
            // buttonComprar
            // 
            this.buttonComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComprar.Location = new System.Drawing.Point(387, 355);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(86, 24);
            this.buttonComprar.TabIndex = 1;
            this.buttonComprar.Text = "COMPRAR";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // numericUpDownMeia
            // 
            this.numericUpDownMeia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numericUpDownMeia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownMeia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numericUpDownMeia.Location = new System.Drawing.Point(74, 328);
            this.numericUpDownMeia.Name = "numericUpDownMeia";
            this.numericUpDownMeia.Size = new System.Drawing.Size(78, 18);
            this.numericUpDownMeia.TabIndex = 2;
            this.numericUpDownMeia.ValueChanged += new System.EventHandler(this.numericUpDownMeia_ValueChanged);
            // 
            // numericUpDownInteira
            // 
            this.numericUpDownInteira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numericUpDownInteira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownInteira.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numericUpDownInteira.Location = new System.Drawing.Point(74, 359);
            this.numericUpDownInteira.Name = "numericUpDownInteira";
            this.numericUpDownInteira.Size = new System.Drawing.Size(78, 18);
            this.numericUpDownInteira.TabIndex = 3;
            this.numericUpDownInteira.ValueChanged += new System.EventHandler(this.numericUpDownInteira_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "INGRESSOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(11, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "MEIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(11, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "INTEIRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(159, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "R$ 16,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(159, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "R$ 32,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(395, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "SUBTOTAL";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotal.ForeColor = System.Drawing.Color.Lime;
            this.labelSubtotal.Location = new System.Drawing.Point(391, 327);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(78, 18);
            this.labelSubtotal.TabIndex = 10;
            this.labelSubtotal.Text = "R$ 0,00";
            // 
            // listBoxSessoes
            // 
            this.listBoxSessoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listBoxSessoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSessoes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSessoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listBoxSessoes.FormattingEnabled = true;
            this.listBoxSessoes.ItemHeight = 17;
            this.listBoxSessoes.Location = new System.Drawing.Point(433, 6);
            this.listBoxSessoes.Name = "listBoxSessoes";
            this.listBoxSessoes.Size = new System.Drawing.Size(163, 272);
            this.listBoxSessoes.TabIndex = 11;
            this.listBoxSessoes.SelectedIndexChanged += new System.EventHandler(this.listBoxSessoes_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageComprar);
            this.tabControl1.Controls.Add(this.tabPage_recibo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 435);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageComprar
            // 
            this.tabPageComprar.BackColor = System.Drawing.Color.Black;
            this.tabPageComprar.Controls.Add(this.listBoxCartaz);
            this.tabPageComprar.Controls.Add(this.listBoxSessoes);
            this.tabPageComprar.Controls.Add(this.buttonComprar);
            this.tabPageComprar.Controls.Add(this.labelSubtotal);
            this.tabPageComprar.Controls.Add(this.numericUpDownMeia);
            this.tabPageComprar.Controls.Add(this.label6);
            this.tabPageComprar.Controls.Add(this.numericUpDownInteira);
            this.tabPageComprar.Controls.Add(this.label5);
            this.tabPageComprar.Controls.Add(this.label1);
            this.tabPageComprar.Controls.Add(this.label4);
            this.tabPageComprar.Controls.Add(this.label2);
            this.tabPageComprar.Controls.Add(this.label3);
            this.tabPageComprar.Location = new System.Drawing.Point(4, 28);
            this.tabPageComprar.Name = "tabPageComprar";
            this.tabPageComprar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComprar.Size = new System.Drawing.Size(603, 403);
            this.tabPageComprar.TabIndex = 0;
            this.tabPageComprar.Text = "COMPRAR";
            // 
            // tabPage_recibo
            // 
            this.tabPage_recibo.BackColor = System.Drawing.Color.Black;
            this.tabPage_recibo.Controls.Add(this.textBoxRecibo);
            this.tabPage_recibo.Location = new System.Drawing.Point(4, 28);
            this.tabPage_recibo.Name = "tabPage_recibo";
            this.tabPage_recibo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_recibo.Size = new System.Drawing.Size(603, 403);
            this.tabPage_recibo.TabIndex = 1;
            this.tabPage_recibo.Text = "RECIBO";
            // 
            // textBoxRecibo
            // 
            this.textBoxRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRecibo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRecibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxRecibo.Location = new System.Drawing.Point(92, 15);
            this.textBoxRecibo.Multiline = true;
            this.textBoxRecibo.Name = "textBoxRecibo";
            this.textBoxRecibo.Size = new System.Drawing.Size(434, 369);
            this.textBoxRecibo.TabIndex = 0;
            this.textBoxRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(635, 459);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CINE 99";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMeia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInteira)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageComprar.ResumeLayout(false);
            this.tabPageComprar.PerformLayout();
            this.tabPage_recibo.ResumeLayout(false);
            this.tabPage_recibo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageComprar;
        private System.Windows.Forms.TabPage tabPage_recibo;
        private System.Windows.Forms.TextBox textBoxRecibo;
    }
}

