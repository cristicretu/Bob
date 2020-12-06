
namespace C_SpeechRecognition
{
    partial class statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.f = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Statistica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlPCh = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.doamne_ajutaDataSet = new C_SpeechRecognition.Doamne_ajutaDataSet();
            this.useriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.useriTableAdapter = new C_SpeechRecognition.Doamne_ajutaDataSetTableAdapters.UseriTableAdapter();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.f.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statistica)).BeginInit();
            this.pnlPCh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doamne_ajutaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.f.Controls.Add(this.dataGridView1);
            this.f.Controls.Add(this.Statistica);
            this.f.Location = new System.Drawing.Point(31, 28);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(399, 345);
            this.f.TabIndex = 0;
            this.f.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, -16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(274, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Statistica
            // 
            this.Statistica.BackColor = System.Drawing.Color.Transparent;
            this.Statistica.BorderlineColor = System.Drawing.Color.Transparent;
            this.Statistica.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.Silver;
            chartArea2.Name = "Time";
            this.Statistica.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.Statistica.Legends.Add(legend2);
            this.Statistica.Location = new System.Drawing.Point(0, 0);
            this.Statistica.Name = "Statistica";
            this.Statistica.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "Time";
            series2.Legend = "Legend1";
            series2.Name = "Time";
            this.Statistica.Series.Add(series2);
            this.Statistica.Size = new System.Drawing.Size(399, 345);
            this.Statistica.TabIndex = 0;
            this.Statistica.Text = "chart1";
            this.Statistica.Click += new System.EventHandler(this.Statistica_Click);
            // 
            // pnlPCh
            // 
            this.pnlPCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.pnlPCh.Controls.Add(this.richTextBox2);
            this.pnlPCh.Controls.Add(this.richTextBox1);
            this.pnlPCh.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPCh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPCh.Location = new System.Drawing.Point(461, 28);
            this.pnlPCh.Name = "pnlPCh";
            this.pnlPCh.Size = new System.Drawing.Size(149, 161);
            this.pnlPCh.TabIndex = 3;
            this.pnlPCh.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPCh_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(-436, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(149, 158);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // doamne_ajutaDataSet
            // 
            this.doamne_ajutaDataSet.DataSetName = "Doamne_ajutaDataSet";
            this.doamne_ajutaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // useriBindingSource
            // 
            this.useriBindingSource.DataMember = "Useri";
            this.useriBindingSource.DataSource = this.doamne_ajutaDataSet;
            // 
            // useriTableAdapter
            // 
            this.useriTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(61)))), ((int)(((byte)(75)))));
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(149, 161);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(622, 402);
            this.Controls.Add(this.pnlPCh);
            this.Controls.Add(this.f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statistics";
            this.Text = "statistics";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.statistics_Load);
            this.f.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Statistica)).EndInit();
            this.pnlPCh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doamne_ajutaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel f;
        private System.Windows.Forms.Panel pnlPCh;
        private System.Windows.Forms.DataVisualization.Charting.Chart Statistica;
        private Doamne_ajutaDataSet doamne_ajutaDataSet;
        private System.Windows.Forms.BindingSource useriBindingSource;
        private Doamne_ajutaDataSetTableAdapters.UseriTableAdapter useriTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}