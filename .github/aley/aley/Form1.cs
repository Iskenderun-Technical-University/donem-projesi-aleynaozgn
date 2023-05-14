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

namespace aley
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("data source = ANYELA ; Initial Catalog = Eczane_DB;Integrated Security=true");

        private void verilerigörüntüle()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from ilaclar", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle =new ListViewItem();
                //ekle.SubItems.Add(oku["sırano"].ToString());
                ekle.SubItems.Add(oku["ilackodu"].ToString());
                ekle.SubItems.Add(oku["ilacadı"].ToString());
                ekle.SubItems.Add(oku["sonkullanmatarihi"].ToString());
                //ekle.SubItems.Add(oku["barkodno"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["adet"].ToString());
                ekle.SubItems.Add(oku["üretimfirması"].ToString());
                ekle.SubItems.Add(oku["kullanmatalimatı"].ToString());

            }
            baglan.Close();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button8_Click(object sender, EventArgs e)
        //{

        //}

        //private void label11_Click(object sender, EventArgs e)
        //{

        //}

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{

        //}

        //private void button6_Click(object sender, EventArgs e)
        //{

        //}

        //private void sıra_sys_Click(object sender, EventArgs e)
        //{

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
