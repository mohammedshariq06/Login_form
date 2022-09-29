namespace login_registration
{
    partial class regt2
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnfemale = new System.Windows.Forms.RadioButton();
            this.rbtnmale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdropquali = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(73, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 35);
            this.button2.TabIndex = 29;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(73, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(67, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "Get Started";
            // 
            // rbtnfemale
            // 
            this.rbtnfemale.AutoSize = true;
            this.rbtnfemale.Location = new System.Drawing.Point(170, 262);
            this.rbtnfemale.Name = "rbtnfemale";
            this.rbtnfemale.Size = new System.Drawing.Size(88, 27);
            this.rbtnfemale.TabIndex = 36;
            this.rbtnfemale.TabStop = true;
            this.rbtnfemale.Text = "Female";
            this.rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // rbtnmale
            // 
            this.rbtnmale.AutoSize = true;
            this.rbtnmale.Location = new System.Drawing.Point(73, 262);
            this.rbtnmale.Name = "rbtnmale";
            this.rbtnmale.Size = new System.Drawing.Size(70, 27);
            this.rbtnmale.TabIndex = 35;
            this.rbtnmale.TabStop = true;
            this.rbtnmale.Text = "Male";
            this.rbtnmale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "Gender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(143, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = "*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtdropquali
            // 
            this.txtdropquali.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtdropquali.FormattingEnabled = true;
            this.txtdropquali.Items.AddRange(new object[] {
            "B.Tech(CSE)",
            "B.Tech(CIV)",
            "B.Tech(ECE)",
            "B.Tech(ME)"});
            this.txtdropquali.Location = new System.Drawing.Point(73, 173);
            this.txtdropquali.Name = "txtdropquali";
            this.txtdropquali.Size = new System.Drawing.Size(216, 31);
            this.txtdropquali.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 23);
            this.label10.TabIndex = 38;
            this.label10.Text = "Qualification";
            // 
            // regt2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 563);
            this.Controls.Add(this.txtdropquali);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rbtnfemale);
            this.Controls.Add(this.rbtnmale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "regt2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "regt2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnfemale;
        private System.Windows.Forms.RadioButton rbtnmale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtdropquali;
        private System.Windows.Forms.Label label10;
    }
}