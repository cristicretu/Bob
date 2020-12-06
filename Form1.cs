using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace C_SpeechRecognition
{
    public partial class statistics : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\arthu\source\repos\cristicretu\Bob_SpeechRecognition\Resources\ii_bun.sqlite;Default Database Type=String");
        public statistics()
        {
            InitializeComponent();
            richTextBox2.Text = "Here is a chart, my dear friend, " + PoliHack_App_Esentza.Meniu.get_user() + ", that shows you how much time you spent with Bob.";
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.BringToFront();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            

            this.useriTableAdapter.Fill(this.doamne_ajutaDataSet.Useri);
            conn.Open();
            
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Azi,Yesterday,twodaysago,threedaysago,fourdaysago,fivedaysago,sixdaysago From Useri where Id='" + PoliHack_App_Esentza.Meniu.get_user() +  "'", conn);
            DataSet ds = new System.Data.DataSet();
            
            sda.Fill(ds,"info");
            
            conn.Close();

            

            dataGridView1.DataSource = ds.Tables[0];

            Statistica.BackColor = Color.FromArgb(31, 61, 75);

            Statistica.Series["Time"].Points.AddXY("Yesterday", dataGridView1.Rows[0].Cells[0].Value);



            for (int i = 1; i < 7; ++i)
                Statistica.Series["Time"].Points.AddXY((i + 1).ToString() + " Days Ago", dataGridView1.Rows[0].Cells[i].Value);
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Statistica_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlPCh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
