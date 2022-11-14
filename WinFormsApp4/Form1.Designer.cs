namespace WinFormsApp4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gejmer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.winner = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 89);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.mark);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 89);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.mark);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 89);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.mark);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 89);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.mark);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(75, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 89);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.mark);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 89);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.mark);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 67);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.mark);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(75, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 67);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.mark);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(155, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 67);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.mark);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.19101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.80899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.51485F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 275);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teraz Gra:";
            // 
            // gejmer
            // 
            this.gejmer.AutoSize = true;
            this.gejmer.Location = new System.Drawing.Point(78, 309);
            this.gejmer.Name = "gejmer";
            this.gejmer.Size = new System.Drawing.Size(27, 15);
            this.gejmer.TabIndex = 11;
            this.gejmer.Text = "null";
            this.gejmer.Click += new System.EventHandler(this.gejmer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wygrany: ";
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Location = new System.Drawing.Point(78, 357);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(24, 15);
            this.winner.TabIndex = 13;
            this.winner.Text = "tba";
            this.winner.Click += new System.EventHandler(this.winner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 481);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gejmer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label gejmer;
        private Label label2;
        private Label winner;
    }
}