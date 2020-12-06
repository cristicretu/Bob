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
using System.IO;

namespace C_SpeechRecognition
{
    public partial class Log_In : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\arthu\source\repos\cristicretu\Bob_SpeechRecognition\Resources\ii_bun.sqlite;Default Database Type=String");
        public Log_In()
        {
            InitializeComponent();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }


        public string get_username()
        {
            return usern.Text;
        }

        private void login_Click(object sender, EventArgs e)
        {    
            conn.Open();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select Count(*) From Useri where Id='" + usern.Text + "' and Password='" + passw.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "0")
            {
                MessageBox.Show("Te rog sa te inregistrezi");
            }
            else DialogResult = DialogResult.OK;
            conn.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static bool it_good(string a)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] == ' ' || (a[i] >= 'A' && a[i] <= 'C'))
                    return false;
            return true;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            bool ok = false;     
            conn.Open();
            do
            {
                ok = it_good(susern.Text) && it_good(spassw.Text); 
               
                if (ok == false)
                {
                    MessageBox.Show("Datele introduse nu sunt valide\nAveti spatii in username sau parola!");
                    susern.Text = "";
                    spassw.Text = "";
                }
            } while (ok == false);

            string comanda = "insert into Useri(Id, Password) values('" + susern.Text + "','" + spassw.Text + "')";
            SQLiteCommand comm = new SQLiteCommand(comanda, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            usern.Text = susern.Text;
            DialogResult = DialogResult.OK;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
 

        private void passw_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void passw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(sender, e);
            }
        }
    }
}
