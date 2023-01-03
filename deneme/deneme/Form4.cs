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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace deneme
{
    public partial class Form4 : Form
    {
        MySqlDataReader d;

        MySqlConnection con = new MySqlConnection("server = localhost; database = insan_kaynakları; Uid=root; pwd =''; ");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaiyapanisciler frm = new mesaiyapanisciler();
            con.Open();
            MySqlCommand c = new MySqlCommand("select * from personel_isci_bilgi where personel_id='" + textBox1.Text + "'");
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
    }
}
