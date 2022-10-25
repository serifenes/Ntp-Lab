using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Db;

namespace SifremiUnuttumProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            DbConnection dbConnection = new DbConnection();
            SqlConnection con = dbConnection.Connect();
            SqlCommand command = new SqlCommand("Select * from kullanicilar where kullaniciadi='" + kullaniciadi + "' AND sifre='"+sifre+"'", con);

            SqlDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Giriş işlemi başarılı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı", "Hata");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreHatirlat sifreHatirlat = new SifreHatirlat();
            sifreHatirlat.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
