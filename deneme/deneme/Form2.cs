using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form2 : Form
    {

        MySqlDataReader d;

        MySqlConnection con = new MySqlConnection("server = localhost; database = insan_kaynakları; Uid=root; pwd =''; ");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            con.Open();
            MySqlCommand c = new MySqlCommand("select * from personel_isci_bilgi where personel_id='"+textBox1.Text+"'");
            c.Connection = con;
            d = c.ExecuteReader();
            while (d.Read())
            {
                frm.textBox1.Text = d["personel_ad"].ToString();
                frm.textBox2.Text = d["personel_soyad"].ToString();
                frm.textBox3.Text = d["personel_tel"].ToString();
                frm.Show();
                this.Hide();
            }
          
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
