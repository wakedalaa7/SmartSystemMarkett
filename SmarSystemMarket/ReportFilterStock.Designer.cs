namespace SmarSystemMarket
{
    partial class ReportFilterStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFilterStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbStocksOut = new System.Windows.Forms.RadioButton();
            this.rbStocksIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 87);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button4.Location = new System.Drawing.Point(217, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 63);
            this.button4.TabIndex = 16;
            this.button4.Text = "&Cancel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(136, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 63);
            this.button3.TabIndex = 15;
            this.button3.Text = "&Load Report";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.dateTimePicker2);
            this.GroupBox3.Controls.Add(this.DateTimePicker1);
            this.GroupBox3.Controls.Add(this.rbStocksOut);
            this.GroupBox3.Controls.Add(this.rbStocksIn);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(12, 87);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(311, 128);
            this.GroupBox3.TabIndex = 55;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Filter By";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(118, 27);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(138, 21);
            this.DateTimePicker1.TabIndex = 0;
            // 
            // rbStocksOut
            // 
            this.rbStocksOut.AutoSize = true;
            this.rbStocksOut.Location = new System.Drawing.Point(138, 92);
            this.rbStocksOut.Name = "rbStocksOut";
            this.rbStocksOut.Size = new System.Drawing.Size(87, 17);
            this.rbStocksOut.TabIndex = 4;
            this.rbStocksOut.TabStop = true;
            this.rbStocksOut.Text = "Stocks Out";
            this.rbStocksOut.UseVisualStyleBackColor = true;
            // 
            // rbStocksIn
            // 
            this.rbStocksIn.AutoSize = true;
            this.rbStocksIn.Location = new System.Drawing.Point(31, 92);
            this.rbStocksIn.Name = "rbStocksIn";
            this.rbStocksIn.Size = new System.Drawing.Size(79, 17);
            this.rbStocksIn.TabIndex = 3;
            this.rbStocksIn.TabStop = true;
            this.rbStocksIn.Text = "Stocks In";
            this.rbStocksIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "End Date :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(30, 35);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(75, 13);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "Start Date :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 57);
            this.panel1.TabIndex = 58;
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Maroon;
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Location = new System.Drawing.Point(839, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(25, 21);
            this.picClose.TabIndex = 3;
            this.picClose.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Report";
            // 
            // ReportFilterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 333);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportFilterStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFilterStock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReportFilterStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.DateTimePicker dateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.RadioButton rbStocksOut;
        internal System.Windows.Forms.RadioButton rbStocksIn;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label2;
    }
}