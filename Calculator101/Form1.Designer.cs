namespace Calculator101
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.Result_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.Thistle;
            this.Seven.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(13, 62);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(45, 47);
            this.Seven.TabIndex = 0;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Num_click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.Thistle;
            this.Eight.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(64, 62);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(45, 47);
            this.Eight.TabIndex = 1;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Num_click);
            // 
            // DEL
            // 
            this.DEL.BackColor = System.Drawing.Color.PaleVioletRed;
            this.DEL.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEL.Location = new System.Drawing.Point(166, 62);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(45, 47);
            this.DEL.TabIndex = 3;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = false;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.Plum;
            this.Divide.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(217, 115);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(45, 47);
            this.Divide.TabIndex = 4;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Operation_click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.Plum;
            this.Minus.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(166, 168);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(45, 47);
            this.Minus.TabIndex = 9;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Operation_click);
            // 
            // Times
            // 
            this.Times.BackColor = System.Drawing.Color.Plum;
            this.Times.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Times.Location = new System.Drawing.Point(166, 115);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(45, 47);
            this.Times.TabIndex = 8;
            this.Times.Text = "x";
            this.Times.UseVisualStyleBackColor = false;
            this.Times.Click += new System.EventHandler(this.Operation_click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.Thistle;
            this.Six.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(115, 115);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(45, 47);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Num_click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.Thistle;
            this.Five.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(64, 115);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(45, 47);
            this.Five.TabIndex = 6;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Num_click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.Thistle;
            this.Four.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(13, 115);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(45, 47);
            this.Four.TabIndex = 5;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Num_click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Plum;
            this.Plus.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(217, 168);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(45, 100);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Operation_click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.Thistle;
            this.Three.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(115, 168);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(45, 47);
            this.Three.TabIndex = 12;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Num_click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.Thistle;
            this.Two.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.Location = new System.Drawing.Point(64, 168);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(45, 47);
            this.Two.TabIndex = 11;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Num_click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.Thistle;
            this.One.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.Location = new System.Drawing.Point(13, 168);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(45, 47);
            this.One.TabIndex = 10;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.Num_click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.Plum;
            this.Equal.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equal.Location = new System.Drawing.Point(115, 221);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(96, 47);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            // 
            // Period
            // 
            this.Period.BackColor = System.Drawing.Color.Thistle;
            this.Period.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period.Location = new System.Drawing.Point(64, 221);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(45, 47);
            this.Period.TabIndex = 16;
            this.Period.Text = ".";
            this.Period.UseVisualStyleBackColor = false;
            this.Period.Click += new System.EventHandler(this.Num_click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.Thistle;
            this.Zero.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(13, 221);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(45, 47);
            this.Zero.TabIndex = 15;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Num_click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.Thistle;
            this.Nine.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(115, 62);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(45, 47);
            this.Nine.TabIndex = 20;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Num_click);
            // 
            // AC
            // 
            this.AC.BackColor = System.Drawing.Color.PaleVioletRed;
            this.AC.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AC.Location = new System.Drawing.Point(217, 62);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(45, 47);
            this.AC.TabIndex = 21;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = false;
            this.AC.Click += new System.EventHandler(this.AC_Click);
            // 
            // Result_box
            // 
            this.Result_box.BackColor = System.Drawing.Color.LavenderBlush;
            this.Result_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_box.Font = new System.Drawing.Font("SimSun", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_box.Location = new System.Drawing.Point(13, 11);
            this.Result_box.Name = "Result_box";
            this.Result_box.Size = new System.Drawing.Size(249, 45);
            this.Result_box.TabIndex = 22;
            this.Result_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculator101.Properties.Resources.sml;
            this.ClientSize = new System.Drawing.Size(276, 283);
            this.Controls.Add(this.Result_box);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.DEL);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "BASIC CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Period;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.TextBox Result_box;
    }
}

