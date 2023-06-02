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
        SqlConnection baglan = new SqlConnection("data source = ANYELA ; Initial Catalog = aleyna12;Integrated Security=true");

        private void verilerigörüntüle()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from aleyna12", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle =new ListViewItem(oku["sırano"].ToString());
                // ekle.SubItems.Add(oku["sırano"].ToString());
                ekle.SubItems.Add(oku["ilackodu"].ToString());
                ekle.SubItems.Add(oku["ilacadı"].ToString());
                ekle.SubItems.Add(oku["sonkullanmatarihi"].ToString());
                ekle.SubItems.Add(oku["barkodno"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["adet"].ToString());
                ekle.SubItems.Add(oku["üretimfirması"].ToString());
                ekle.SubItems.Add(oku["kullanmatalimatı"].ToString());
                listView1.Items.Add(ekle);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          baglan.Open();
            SqlCommand komut = new SqlCommand("insert into aleyna12(sırano,ilackodu,ilacadı,sonkullanmatarihi,barkodno,fiyat,adet,üretimfirması,kullanmatalimatı)values('"+textBox1.Text+ "','"+textBox2.Text+ "','"+textBox3.Text+ "','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"','"+textBox8.Text+ "','"+textBox9.Text+"'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int  id = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from aleyna12 where id=("+id+")",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;    
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;    
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;    
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;    
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;    
            textBox6.Text = listView1.SelectedItems[0].SubItems[5].Text;    
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;    
            textBox8.Text = listView1.SelectedItems[0].SubItems[7].Text;    
            textBox9.Text = listView1.SelectedItems[0].SubItems[8].Text;    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update aleyna12 set sırano='" + textBox1.Text.ToString() + "',ilackodu'" + textBox2.Text.ToString() + "',ilacadı='" + textBox3.Text.ToString() + "',sonkullanmatarihi='" + textBox4.Text.ToString() + "'barkodno='" + textBox5.Text.ToString() + "',fiyat='" + textBox6.Text.ToString() + "',adet='" + textBox7.Text.ToString() + "',üretimfirması='" + textBox8.Text.ToString() + "',kullanmatalimatı='" + textBox9.Text.ToString() + "'where id=" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigörüntüle();

        }
    }
}
