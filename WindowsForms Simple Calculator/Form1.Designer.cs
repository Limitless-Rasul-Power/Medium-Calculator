
namespace WindowsForms_Simple_Calculator
{
    partial class Form1
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
            this.OneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CEBtn = new System.Windows.Forms.Button();
            this.EqualslBtn = new System.Windows.Forms.Button();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OneBtn
            // 
            this.OneBtn.BackColor = System.Drawing.Color.White;
            this.OneBtn.Location = new System.Drawing.Point(56, 210);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(35, 32);
            this.OneBtn.TabIndex = 1;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = false;
            this.OneBtn.Click += new System.EventHandler(this.OneBtn_Click);
            // 
            // TwoBtn
            // 
            this.TwoBtn.BackColor = System.Drawing.Color.White;
            this.TwoBtn.Location = new System.Drawing.Point(97, 210);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(35, 32);
            this.TwoBtn.TabIndex = 1;
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = false;
            this.TwoBtn.Click += new System.EventHandler(this.TwoBtn_Click);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.BackColor = System.Drawing.Color.White;
            this.ThreeBtn.Location = new System.Drawing.Point(138, 210);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(35, 32);
            this.ThreeBtn.TabIndex = 2;
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = false;
            this.ThreeBtn.Click += new System.EventHandler(this.ThreeBtn_Click);
            // 
            // FourBtn
            // 
            this.FourBtn.BackColor = System.Drawing.Color.White;
            this.FourBtn.Location = new System.Drawing.Point(56, 172);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(35, 32);
            this.FourBtn.TabIndex = 3;
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = false;
            this.FourBtn.Click += new System.EventHandler(this.FourBtn_Click);
            // 
            // FiveBtn
            // 
            this.FiveBtn.BackColor = System.Drawing.Color.White;
            this.FiveBtn.Location = new System.Drawing.Point(97, 172);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(35, 32);
            this.FiveBtn.TabIndex = 4;
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = false;
            this.FiveBtn.Click += new System.EventHandler(this.FiveBtn_Click);
            // 
            // SixBtn
            // 
            this.SixBtn.BackColor = System.Drawing.Color.White;
            this.SixBtn.Location = new System.Drawing.Point(138, 172);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(35, 32);
            this.SixBtn.TabIndex = 5;
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = false;
            this.SixBtn.Click += new System.EventHandler(this.SixBtn_Click);
            // 
            // SevenBtn
            // 
            this.SevenBtn.BackColor = System.Drawing.Color.White;
            this.SevenBtn.Location = new System.Drawing.Point(56, 134);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(35, 32);
            this.SevenBtn.TabIndex = 6;
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = false;
            this.SevenBtn.Click += new System.EventHandler(this.SevenBtn_Click);
            // 
            // EightBtn
            // 
            this.EightBtn.BackColor = System.Drawing.Color.White;
            this.EightBtn.Location = new System.Drawing.Point(97, 134);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(35, 32);
            this.EightBtn.TabIndex = 7;
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = false;
            this.EightBtn.Click += new System.EventHandler(this.EightBtn_Click);
            // 
            // NineBtn
            // 
            this.NineBtn.BackColor = System.Drawing.Color.White;
            this.NineBtn.Location = new System.Drawing.Point(138, 134);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(35, 32);
            this.NineBtn.TabIndex = 8;
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = false;
            this.NineBtn.Click += new System.EventHandler(this.NineBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.BackColor = System.Drawing.Color.White;
            this.ZeroBtn.Enabled = false;
            this.ZeroBtn.Location = new System.Drawing.Point(97, 244);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(35, 32);
            this.ZeroBtn.TabIndex = 9;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Controls.Add(this.CEBtn);
            this.groupBox1.Controls.Add(this.EqualslBtn);
            this.groupBox1.Controls.Add(this.ResultLbl);
            this.groupBox1.Controls.Add(this.MinusBtn);
            this.groupBox1.Controls.Add(this.OneBtn);
            this.groupBox1.Controls.Add(this.MultiplyBtn);
            this.groupBox1.Controls.Add(this.ZeroBtn);
            this.groupBox1.Controls.Add(this.DivideBtn);
            this.groupBox1.Controls.Add(this.TwoBtn);
            this.groupBox1.Controls.Add(this.PlusBtn);
            this.groupBox1.Controls.Add(this.NineBtn);
            this.groupBox1.Controls.Add(this.ThreeBtn);
            this.groupBox1.Controls.Add(this.EightBtn);
            this.groupBox1.Controls.Add(this.FourBtn);
            this.groupBox1.Controls.Add(this.SevenBtn);
            this.groupBox1.Controls.Add(this.FiveBtn);
            this.groupBox1.Controls.Add(this.SixBtn);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 294);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aftandil\'s Fantastic Idea";
            // 
            // CEBtn
            // 
            this.CEBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEBtn.Location = new System.Drawing.Point(56, 244);
            this.CEBtn.Name = "CEBtn";
            this.CEBtn.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.CEBtn.Size = new System.Drawing.Size(35, 32);
            this.CEBtn.TabIndex = 0;
            this.CEBtn.Text = "CE";
            this.CEBtn.UseVisualStyleBackColor = true;
            this.CEBtn.Click += new System.EventHandler(this.CEBtn_Click);
            // 
            // EqualslBtn
            // 
            this.EqualslBtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.EqualslBtn.Enabled = false;
            this.EqualslBtn.Location = new System.Drawing.Point(179, 244);
            this.EqualslBtn.Name = "EqualslBtn";
            this.EqualslBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.EqualslBtn.Size = new System.Drawing.Size(35, 32);
            this.EqualslBtn.TabIndex = 15;
            this.EqualslBtn.Text = "=";
            this.EqualslBtn.UseVisualStyleBackColor = false;
            this.EqualslBtn.Click += new System.EventHandler(this.EqualslBtn_Click);
            // 
            // ResultLbl
            // 
            this.ResultLbl.BackColor = System.Drawing.SystemColors.Window;
            this.ResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLbl.Location = new System.Drawing.Point(41, 24);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Padding = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.ResultLbl.Size = new System.Drawing.Size(132, 104);
            this.ResultLbl.TabIndex = 11;
            this.ResultLbl.Text = "0";
            // 
            // MinusBtn
            // 
            this.MinusBtn.Enabled = false;
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusBtn.Location = new System.Drawing.Point(179, 210);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MinusBtn.Size = new System.Drawing.Size(35, 32);
            this.MinusBtn.TabIndex = 14;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Enabled = false;
            this.MultiplyBtn.Location = new System.Drawing.Point(179, 134);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.MultiplyBtn.Size = new System.Drawing.Size(35, 32);
            this.MultiplyBtn.TabIndex = 13;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.MultiplyBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.Enabled = false;
            this.DivideBtn.Location = new System.Drawing.Point(179, 96);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(35, 32);
            this.DivideBtn.TabIndex = 12;
            this.DivideBtn.Text = "/";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Enabled = false;
            this.PlusBtn.Location = new System.Drawing.Point(179, 172);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.PlusBtn.Size = new System.Drawing.Size(35, 32);
            this.PlusBtn.TabIndex = 11;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::WindowsForms_Simple_Calculator.Properties.Resources.back;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(138, 244);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Padding = new System.Windows.Forms.Padding(2, 3, 0, 0);
            this.BackBtn.Size = new System.Drawing.Size(35, 32);
            this.BackBtn.TabIndex = 17;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 311);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(274, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(274, 350);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button EqualslBtn;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button CEBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}

