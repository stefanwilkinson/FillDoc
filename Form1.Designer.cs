namespace _6CAttendance
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
            this.components = new System.ComponentModel.Container();
            this.Back = new System.Windows.Forms.Panel();
            this.Front = new System.Windows.Forms.Panel();
            this.CMT = new System.Windows.Forms.RichTextBox();
            this.CommentsL = new System.Windows.Forms.Label();
            this.EMT = new System.Windows.Forms.TextBox();
            this.EmailL = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignOL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignIL = new System.Windows.Forms.Label();
            this.LNT = new System.Windows.Forms.TextBox();
            this.FNT = new System.Windows.Forms.TextBox();
            this.TimeL = new System.Windows.Forms.Label();
            this.LastNL = new System.Windows.Forms.Label();
            this.WelcomeL = new System.Windows.Forms.Label();
            this.FirstNL = new System.Windows.Forms.Label();
            this.GreetL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HeaderL = new System.Windows.Forms.Label();
            this.Back.SuspendLayout();
            this.Front.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Snow;
            this.Back.Controls.Add(this.Front);
            this.Back.Controls.Add(this.GreetL);
            this.Back.Location = new System.Drawing.Point(0, 139);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(884, 351);
            this.Back.TabIndex = 0;
            // 
            // Front
            // 
            this.Front.BackColor = System.Drawing.Color.Gold;
            this.Front.Controls.Add(this.CMT);
            this.Front.Controls.Add(this.CommentsL);
            this.Front.Controls.Add(this.EMT);
            this.Front.Controls.Add(this.EmailL);
            this.Front.Controls.Add(this.TT);
            this.Front.Controls.Add(this.panel2);
            this.Front.Controls.Add(this.panel1);
            this.Front.Controls.Add(this.LNT);
            this.Front.Controls.Add(this.FNT);
            this.Front.Controls.Add(this.TimeL);
            this.Front.Controls.Add(this.LastNL);
            this.Front.Controls.Add(this.WelcomeL);
            this.Front.Controls.Add(this.FirstNL);
            this.Front.Location = new System.Drawing.Point(0, 0);
            this.Front.Name = "Front";
            this.Front.Size = new System.Drawing.Size(344, 351);
            this.Front.TabIndex = 2;
            // 
            // CMT
            // 
            this.CMT.Location = new System.Drawing.Point(106, 195);
            this.CMT.Name = "CMT";
            this.CMT.Size = new System.Drawing.Size(159, 67);
            this.CMT.TabIndex = 13;
            this.CMT.Text = "";
            // 
            // CommentsL
            // 
            this.CommentsL.AutoSize = true;
            this.CommentsL.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsL.ForeColor = System.Drawing.Color.Black;
            this.CommentsL.Location = new System.Drawing.Point(3, 189);
            this.CommentsL.Name = "CommentsL";
            this.CommentsL.Size = new System.Drawing.Size(97, 27);
            this.CommentsL.TabIndex = 12;
            this.CommentsL.Text = "Comments";
            // 
            // EMT
            // 
            this.EMT.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMT.Location = new System.Drawing.Point(106, 158);
            this.EMT.Name = "EMT";
            this.EMT.Size = new System.Drawing.Size(159, 21);
            this.EMT.TabIndex = 11;
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailL.ForeColor = System.Drawing.Color.Black;
            this.EmailL.Location = new System.Drawing.Point(47, 158);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(53, 27);
            this.EmailL.TabIndex = 10;
            this.EmailL.Text = "Email";
            // 
            // TT
            // 
            this.TT.AutoSize = true;
            this.TT.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TT.ForeColor = System.Drawing.Color.Black;
            this.TT.Location = new System.Drawing.Point(101, 273);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(0, 27);
            this.TT.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.SignOL);
            this.panel2.Location = new System.Drawing.Point(185, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 25);
            this.panel2.TabIndex = 8;
            // 
            // SignOL
            // 
            this.SignOL.AutoSize = true;
            this.SignOL.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignOL.Location = new System.Drawing.Point(9, 3);
            this.SignOL.Name = "SignOL";
            this.SignOL.Size = new System.Drawing.Size(65, 18);
            this.SignOL.TabIndex = 1;
            this.SignOL.Text = "Sign Out";
            this.SignOL.Click += new System.EventHandler(this.SignOL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.SignIL);
            this.panel1.Location = new System.Drawing.Point(77, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 25);
            this.panel1.TabIndex = 7;
            // 
            // SignIL
            // 
            this.SignIL.AutoSize = true;
            this.SignIL.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignIL.Location = new System.Drawing.Point(11, 3);
            this.SignIL.Name = "SignIL";
            this.SignIL.Size = new System.Drawing.Size(58, 18);
            this.SignIL.TabIndex = 0;
            this.SignIL.Text = "Sign In";
            this.SignIL.Click += new System.EventHandler(this.SignIL_Click);
            // 
            // LNT
            // 
            this.LNT.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNT.Location = new System.Drawing.Point(106, 119);
            this.LNT.Name = "LNT";
            this.LNT.Size = new System.Drawing.Size(159, 21);
            this.LNT.TabIndex = 5;
            // 
            // FNT
            // 
            this.FNT.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNT.Location = new System.Drawing.Point(106, 81);
            this.FNT.Name = "FNT";
            this.FNT.Size = new System.Drawing.Size(159, 21);
            this.FNT.TabIndex = 4;
            // 
            // TimeL
            // 
            this.TimeL.AutoSize = true;
            this.TimeL.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeL.ForeColor = System.Drawing.Color.Black;
            this.TimeL.Location = new System.Drawing.Point(50, 273);
            this.TimeL.Name = "TimeL";
            this.TimeL.Size = new System.Drawing.Size(51, 27);
            this.TimeL.TabIndex = 3;
            this.TimeL.Text = "Time";
            // 
            // LastNL
            // 
            this.LastNL.AutoSize = true;
            this.LastNL.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNL.ForeColor = System.Drawing.Color.Black;
            this.LastNL.Location = new System.Drawing.Point(6, 119);
            this.LastNL.Name = "LastNL";
            this.LastNL.Size = new System.Drawing.Size(94, 27);
            this.LastNL.TabIndex = 2;
            this.LastNL.Text = "Last Name";
            // 
            // WelcomeL
            // 
            this.WelcomeL.AutoSize = true;
            this.WelcomeL.Font = new System.Drawing.Font("Elephant", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeL.ForeColor = System.Drawing.Color.Black;
            this.WelcomeL.Location = new System.Drawing.Point(84, 10);
            this.WelcomeL.Name = "WelcomeL";
            this.WelcomeL.Size = new System.Drawing.Size(195, 38);
            this.WelcomeL.TabIndex = 0;
            this.WelcomeL.Text = "Attendance";
            // 
            // FirstNL
            // 
            this.FirstNL.AutoSize = true;
            this.FirstNL.BackColor = System.Drawing.Color.Transparent;
            this.FirstNL.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNL.ForeColor = System.Drawing.Color.Black;
            this.FirstNL.Location = new System.Drawing.Point(3, 81);
            this.FirstNL.Name = "FirstNL";
            this.FirstNL.Size = new System.Drawing.Size(98, 27);
            this.FirstNL.TabIndex = 1;
            this.FirstNL.Text = "First Name";
            // 
            // GreetL
            // 
            this.GreetL.AutoSize = true;
            this.GreetL.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetL.Location = new System.Drawing.Point(375, 1);
            this.GreetL.Name = "GreetL";
            this.GreetL.Size = new System.Drawing.Size(0, 30);
            this.GreetL.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HeaderL
            // 
            this.HeaderL.AutoSize = true;
            this.HeaderL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.HeaderL.Font = new System.Drawing.Font("Elephant", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderL.ForeColor = System.Drawing.Color.Gold;
            this.HeaderL.Location = new System.Drawing.Point(271, 46);
            this.HeaderL.Name = "HeaderL";
            this.HeaderL.Size = new System.Drawing.Size(333, 38);
            this.HeaderL.TabIndex = 1;
            this.HeaderL.Text = "Welcome to the 6CA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(881, 633);
            this.Controls.Add(this.HeaderL);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "6CAttendance";
            this.Back.ResumeLayout(false);
            this.Back.PerformLayout();
            this.Front.ResumeLayout(false);
            this.Front.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Back;
        private System.Windows.Forms.Label WelcomeL;
        private System.Windows.Forms.Panel Front;
        private System.Windows.Forms.Label LastNL;
        private System.Windows.Forms.Label FirstNL;
        private System.Windows.Forms.Label TimeL;
        private System.Windows.Forms.TextBox LNT;
        private System.Windows.Forms.TextBox FNT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SignOL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SignIL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TT;
        private System.Windows.Forms.Label GreetL;
        private System.Windows.Forms.TextBox EMT;
        private System.Windows.Forms.Label EmailL;
        private System.Windows.Forms.Label HeaderL;
        private System.Windows.Forms.RichTextBox CMT;
        private System.Windows.Forms.Label CommentsL;
    }
}

