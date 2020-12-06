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
    public partial class Settings : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source=C:\Users\arthu\source\repos\cristicretu\Bob_SpeechRecognition\Resources\ii_bun.sqlite;Default Database Type=String");
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();
            string comanda = "delete from Useri where Id ='" + PoliHack_App_Esentza.Meniu.get_user() + "'";
            SQLiteCommand comm = new SQLiteCommand(comanda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("The account has been deleted");
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            bool ok = false;
            do
            {
                ok = C_SpeechRecognition.Log_In.it_good(richTextBox5.Text);
                if (ok == false)
                {
                    MessageBox.Show("This password is invalid");
                    richTextBox5.Text = "";
                }
            }
            while (ok == false);
            conn.Open();
            string comanda = "UPDATE Useri set Password = '" +richTextBox5.Text + "' where Id = '"+PoliHack_App_Esentza.Meniu.get_user()+"'";
            SQLiteCommand comm = new SQLiteCommand(comanda, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("The password was changed successfully");
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out. Bob will miss you!");
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Name = '" + richTextBox1.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();
              
            }
            if (!richTextBox2.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Last_Name = '" + richTextBox2.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();
               
            }
            if (!richTextBox4.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Birthday = '" + richTextBox4.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();
               
            }
            if (!richTextBox10.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Height = '" + richTextBox10.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();
               
            }
            if (!richTextBox9.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Weight = '" + richTextBox9.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                
            }
            if (!richTextBox8.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Blood_Type = '" + richTextBox8.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();
               
            }
            if (!richTextBox7.Equals(""))
            {
                conn.Open();
                string comanda = "UPDATE Useri set Medical_Condition = '" + richTextBox7.Text + "' where Id = '" + PoliHack_App_Esentza.Meniu.get_user() + "'";
                SQLiteCommand comm = new SQLiteCommand(comanda, conn);
                comm.ExecuteNonQuery();
                conn.Close();

            }

            MessageBox.Show("Your info was updated");

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
