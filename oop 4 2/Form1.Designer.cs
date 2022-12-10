namespace oop_4_2
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
            this.components = new System.ComponentModel.Container();
            this.textBoxLetter_C = new System.Windows.Forms.TextBox();
            this.textLetter_B = new System.Windows.Forms.TextBox();
            this.textLetter_A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackLetter_B = new System.Windows.Forms.TrackBar();
            this.trackLetter_A = new System.Windows.Forms.TrackBar();
            this.trackBarLetter_C = new System.Windows.Forms.TrackBar();
            this.numericUpLetter_C = new System.Windows.Forms.NumericUpDown();
            this.numericUpLetter_A = new System.Windows.Forms.NumericUpDown();
            this.numericUpLetter_B = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackLetter_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLetter_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLetter_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLetter_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLetter_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLetter_B)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLetter_C
            // 
            this.textBoxLetter_C.Location = new System.Drawing.Point(1085, 297);
            this.textBoxLetter_C.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLetter_C.Name = "textBoxLetter_C";
            this.textBoxLetter_C.Size = new System.Drawing.Size(219, 39);
            this.textBoxLetter_C.TabIndex = 0;
            this.textBoxLetter_C.Leave += new System.EventHandler(this.textBoxLetter_C_Leave);
            // 
            // textLetter_B
            // 
            this.textLetter_B.Location = new System.Drawing.Point(624, 297);
            this.textLetter_B.Margin = new System.Windows.Forms.Padding(6);
            this.textLetter_B.Name = "textLetter_B";
            this.textLetter_B.Size = new System.Drawing.Size(219, 39);
            this.textLetter_B.TabIndex = 1;
            this.textLetter_B.Leave += new System.EventHandler(this.textLetter_B_Leave);
            // 
            // textLetter_A
            // 
            this.textLetter_A.Location = new System.Drawing.Point(180, 297);
            this.textLetter_A.Margin = new System.Windows.Forms.Padding(6);
            this.textLetter_A.Name = "textLetter_A";
            this.textLetter_A.Size = new System.Drawing.Size(219, 39);
            this.textLetter_A.TabIndex = 2;
            this.textLetter_A.Leave += new System.EventHandler(this.textLetter_A_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1150, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "C";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(691, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(280, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "A";
            // 
            // trackLetter_B
            // 
            this.trackLetter_B.Location = new System.Drawing.Point(624, 439);
            this.trackLetter_B.Margin = new System.Windows.Forms.Padding(6);
            this.trackLetter_B.Maximum = 100;
            this.trackLetter_B.Name = "trackLetter_B";
            this.trackLetter_B.Size = new System.Drawing.Size(223, 90);
            this.trackLetter_B.TabIndex = 6;
            this.trackLetter_B.ValueChanged += new System.EventHandler(this.trackLetter_B_ValueChanged);
            // 
            // trackLetter_A
            // 
            this.trackLetter_A.Location = new System.Drawing.Point(180, 433);
            this.trackLetter_A.Margin = new System.Windows.Forms.Padding(6);
            this.trackLetter_A.Maximum = 100;
            this.trackLetter_A.Name = "trackLetter_A";
            this.trackLetter_A.Size = new System.Drawing.Size(223, 90);
            this.trackLetter_A.TabIndex = 7;
            this.trackLetter_A.ValueChanged += new System.EventHandler(this.trackLetter_A_ValueChanged);
            // 
            // trackBarLetter_C
            // 
            this.trackBarLetter_C.Location = new System.Drawing.Point(1085, 433);
            this.trackBarLetter_C.Margin = new System.Windows.Forms.Padding(6);
            this.trackBarLetter_C.Maximum = 100;
            this.trackBarLetter_C.Name = "trackBarLetter_C";
            this.trackBarLetter_C.Size = new System.Drawing.Size(223, 90);
            this.trackBarLetter_C.TabIndex = 8;
            this.trackBarLetter_C.ValueChanged += new System.EventHandler(this.trackBarLetter_C_ValueChanged);
            // 
            // numericUpLetter_C
            // 
            this.numericUpLetter_C.Location = new System.Drawing.Point(1085, 358);
            this.numericUpLetter_C.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpLetter_C.Name = "numericUpLetter_C";
            this.numericUpLetter_C.Size = new System.Drawing.Size(223, 39);
            this.numericUpLetter_C.TabIndex = 9;
            this.numericUpLetter_C.ValueChanged += new System.EventHandler(this.numericUpLetter_C_ValueChanged_1);
            // 
            // numericUpLetter_A
            // 
            this.numericUpLetter_A.Location = new System.Drawing.Point(180, 358);
            this.numericUpLetter_A.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpLetter_A.Name = "numericUpLetter_A";
            this.numericUpLetter_A.Size = new System.Drawing.Size(223, 39);
            this.numericUpLetter_A.TabIndex = 10;
            this.numericUpLetter_A.ValueChanged += new System.EventHandler(this.numericUpLetter_A_ValueChanged);
            // 
            // numericUpLetter_B
            // 
            this.numericUpLetter_B.Location = new System.Drawing.Point(624, 358);
            this.numericUpLetter_B.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpLetter_B.Name = "numericUpLetter_B";
            this.numericUpLetter_B.Size = new System.Drawing.Size(223, 39);
            this.numericUpLetter_B.TabIndex = 11;
            this.numericUpLetter_B.ValueChanged += new System.EventHandler(this.numericUpLetter_B_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(912, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 54);
            this.label4.TabIndex = 12;
            this.label4.Text = "<=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(466, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 54);
            this.label5.TabIndex = 13;
            this.label5.Text = "<=";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 841);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpLetter_B);
            this.Controls.Add(this.numericUpLetter_A);
            this.Controls.Add(this.numericUpLetter_C);
            this.Controls.Add(this.trackBarLetter_C);
            this.Controls.Add(this.trackLetter_A);
            this.Controls.Add(this.trackLetter_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLetter_A);
            this.Controls.Add(this.textLetter_B);
            this.Controls.Add(this.textBoxLetter_C);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackLetter_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackLetter_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLetter_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLetter_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLetter_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpLetter_B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLetter_C;
        private TextBox textLetter_B;
        private TextBox textLetter_A;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar trackLetter_B;
        private TrackBar trackLetter_A;
        private TrackBar trackBarLetter_C;
        private NumericUpDown numericUpLetter_C;
        private NumericUpDown numericUpLetter_A;
        private NumericUpDown numericUpLetter_B;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}