
namespace C_SpeechRecognition
{
    partial class Log_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            this.login = new System.Windows.Forms.Button();
            this.usern = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.susern = new System.Windows.Forms.TextBox();
            this.spassw = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(169, 220);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(137, 19);
            this.login.TabIndex = 0;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // usern
            // 
            this.usern.Location = new System.Drawing.Point(169, 126);
            this.usern.Margin = new System.Windows.Forms.Padding(2);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(137, 20);
            this.usern.TabIndex = 1;
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(169, 183);
            this.passw.Margin = new System.Windows.Forms.Padding(2);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(137, 20);
            this.passw.TabIndex = 3;
            this.passw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.passw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passw_KeyDown);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(398, 220);
            this.signup.Margin = new System.Windows.Forms.Padding(2);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(137, 19);
            this.signup.TabIndex = 4;
            this.signup.Text = "Create Account";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // susern
            // 
            this.susern.Location = new System.Drawing.Point(398, 126);
            this.susern.Margin = new System.Windows.Forms.Padding(2);
            this.susern.Name = "susern";
            this.susern.Size = new System.Drawing.Size(137, 20);
            this.susern.TabIndex = 5;
            this.susern.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // spassw
            // 
            this.spassw.Location = new System.Drawing.Point(398, 183);
            this.spassw.Margin = new System.Windows.Forms.Padding(2);
            this.spassw.Name = "spassw";
            this.spassw.PasswordChar = '*';
            this.spassw.Size = new System.Drawing.Size(137, 20);
            this.spassw.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(41, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(41, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Password";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(197, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Sign In";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(422, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(155, 26);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Sign Up";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Leelawadee UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(291, 22);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(366, 43);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "B   O   B";
            // 
            // Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.spassw);
            this.Controls.Add(this.susern);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.usern);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Log_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox usern;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox susern;
        private System.Windows.Forms.TextBox spassw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}