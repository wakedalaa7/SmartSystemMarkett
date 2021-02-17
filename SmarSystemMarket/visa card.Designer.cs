namespace SmarSystemMarket
{
    partial class visa_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visa_card));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_f_name = new JTextBox.JTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jTextBox1 = new JTextBox.JTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.BackgroundImage = global::SmarSystemMarket.Properties.Resources.הורדה;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox1.Location = new System.Drawing.Point(370, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 39);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackgroundImage = global::SmarSystemMarket.Properties.Resources._1280px_Old_Visa_Logo_svg;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox2.Location = new System.Drawing.Point(461, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 39);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // loginlabel
            // 
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginlabel.Location = new System.Drawing.Point(92, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(499, 50);
            this.loginlabel.TabIndex = 6;
            this.loginlabel.Text = "Insert your card information";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card Holder Name :  ";
            // 
            // txt_f_name
            // 
            this.txt_f_name.AutoSize = true;
            this.txt_f_name.BorderColor = System.Drawing.Color.Red;
            this.txt_f_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_f_name.Hint = "";
            this.txt_f_name.IsPassword = false;
            this.txt_f_name.Length = 0;
            this.txt_f_name.Location = new System.Drawing.Point(237, 65);
            this.txt_f_name.Name = "txt_f_name";
            this.txt_f_name.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_f_name.OnlyChar = false;
            this.txt_f_name.OnlyNumber = false;
            this.txt_f_name.Size = new System.Drawing.Size(313, 39);
            this.txt_f_name.TabIndex = 8;
            this.txt_f_name.TextValue = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card security code : ";
            // 
            // jTextBox1
            // 
            this.jTextBox1.AutoSize = true;
            this.jTextBox1.BorderColor = System.Drawing.Color.Red;
            this.jTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.jTextBox1.Hint = "";
            this.jTextBox1.IsPassword = false;
            this.jTextBox1.Length = 0;
            this.jTextBox1.Location = new System.Drawing.Point(237, 115);
            this.jTextBox1.Name = "jTextBox1";
            this.jTextBox1.OnFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.jTextBox1.OnlyChar = false;
            this.jTextBox1.OnlyNumber = false;
            this.jTextBox1.Size = new System.Drawing.Size(110, 39);
            this.jTextBox1.TabIndex = 10;
            this.jTextBox1.TextValue = "";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(1, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 54);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SmarSystemMarket.Properties.Resources.starpics;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(487, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 54);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // visa_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 215);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_f_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "visa_card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "visa_card";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.visa_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label label1;
        private JTextBox.JTextBox txt_f_name;
        private System.Windows.Forms.Label label2;
        private JTextBox.JTextBox jTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}