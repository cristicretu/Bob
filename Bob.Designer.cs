
namespace C_SpeechRecognition
{
    partial class Bob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Bobita = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DisableMicrophone = new System.Windows.Forms.Button();
            this.EnableMicrophone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Bobita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 371);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Are you a real human? ",
            "Do you speak romanian?",
            "Good afternoon!",
            "Good evening!",
            "Good morning!",
            "Good night! ",
            "Goodbye!",
            "Hello, Bob! ",
            "How many hours did I use my PC?",
            "How old are you?",
            "I\'m exhausted.",
            "I tested positive for COVID 19. ",
            "I think I have COVID 19. ",
            "See you tomorrow! ",
            "Tell me a joke. ",
            "Thank you!",
            "What\'s the time? ",
            "What\'s your IQ? ",
            "What are the symptoms of COVID 19?",
            "What day is today?",
            "What do you do with my data?",
            "Where do you live?",
            "Who made you? ",
            "You\'re useless!",
            "You’re annoying!",
            "You’re boring!"});
            this.listBox1.Location = new System.Drawing.Point(0, -4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(411, 375);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Bobita
            // 
            this.Bobita.AutoSize = true;
            this.Bobita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(85)))));
            this.Bobita.Controls.Add(this.label2);
            this.Bobita.Controls.Add(this.pictureBox1);
            this.Bobita.Controls.Add(this.label1);
            this.Bobita.Controls.Add(this.richTextBox1);
            this.Bobita.Controls.Add(this.DisableMicrophone);
            this.Bobita.Controls.Add(this.EnableMicrophone);
            this.Bobita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bobita.Location = new System.Drawing.Point(234, 29);
            this.Bobita.Name = "Bobita";
            this.Bobita.Size = new System.Drawing.Size(391, 369);
            this.Bobita.TabIndex = 1;
            this.Bobita.Paint += new System.Windows.Forms.PaintEventHandler(this.Bobita_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Active Now";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_SpeechRecognition.Properties.Resources.aicon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bob";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(3, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(385, 278);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // DisableMicrophone
            // 
            this.DisableMicrophone.Enabled = false;
            this.DisableMicrophone.FlatAppearance.BorderSize = 0;
            this.DisableMicrophone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableMicrophone.Image = global::C_SpeechRecognition.Properties.Resources.round_mic_off_black_18dp;
            this.DisableMicrophone.Location = new System.Drawing.Point(346, 343);
            this.DisableMicrophone.Name = "DisableMicrophone";
            this.DisableMicrophone.Size = new System.Drawing.Size(32, 23);
            this.DisableMicrophone.TabIndex = 2;
            this.DisableMicrophone.UseVisualStyleBackColor = true;
            this.DisableMicrophone.Click += new System.EventHandler(this.DisableMicrophone_Click);
            // 
            // EnableMicrophone
            // 
            this.EnableMicrophone.FlatAppearance.BorderSize = 0;
            this.EnableMicrophone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableMicrophone.Image = global::C_SpeechRecognition.Properties.Resources.round_mic_black_18dp;
            this.EnableMicrophone.Location = new System.Drawing.Point(308, 343);
            this.EnableMicrophone.Name = "EnableMicrophone";
            this.EnableMicrophone.Size = new System.Drawing.Size(32, 23);
            this.EnableMicrophone.TabIndex = 1;
            this.EnableMicrophone.UseVisualStyleBackColor = true;
            this.EnableMicrophone.Click += new System.EventHandler(this.EnableMicrophone_Click);
            // 
            // Bob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.Bobita);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bob";
            this.Text = "Bob";
            this.Load += new System.EventHandler(this.Bob_Load);
            this.panel1.ResumeLayout(false);
            this.Bobita.ResumeLayout(false);
            this.Bobita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Bobita;
        private System.Windows.Forms.Button DisableMicrophone;
        private System.Windows.Forms.Button EnableMicrophone;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}