using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_First
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.WHITE);

            trackBar1.Value = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PublishingHouseEntities db = new PublishingHouseEntities())
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = db.Books.Select(b => new { b.ID_Book, b.NameBook, b.Authors.FirstName, b.Authors.LastName, b.Price }).ToList();
                dataGridView1.DataSource = bs;
            }
        }



        private void filter_tb_TextChanged(object sender, EventArgs e)
        {
            using (PublishingHouseEntities db = new PublishingHouseEntities())
            {
                if (fn_radio.Checked)
                {
                    var filtered = db.Books.Where(b => b.Authors.FirstName.Contains(filter_tb.Text)).ToList();    
                    BindingSource bs = new BindingSource();
                    bs.DataSource = filtered.Select(b => new { b.ID_Book, b.NameBook, b.Authors.FirstName, b.Authors.LastName, b.Price }).ToList();
                    dataGridView1.DataSource = bs;
                }
                else if (ln_radio.Checked)
                {
                    var filtered = db.Books.Where(b => b.Authors.LastName.Contains(filter_tb.Text)).ToList();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = filtered.Select(b => new { b.ID_Book, b.NameBook, b.Authors.FirstName, b.Authors.LastName, b.Price }).ToList();
                    dataGridView1.DataSource = bs;
                }
                else if (nb_radio.Checked)
                {
                    var filtered = db.Books.Where(b => b.NameBook.Contains(filter_tb.Text)).ToList();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = filtered.Select(b => new { b.ID_Book, b.NameBook, b.Authors.FirstName, b.Authors.LastName, b.Price }).ToList();
                    dataGridView1.DataSource = bs;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            using (PublishingHouseEntities db = new PublishingHouseEntities())
            {
                var filtered = db.Books.Where(b => b.Price < trackBar1.Value).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = filtered.Select(b => new { b.ID_Book, b.NameBook, b.Authors.FirstName, b.Authors.LastName, b.Price }).ToList();
                dataGridView1.DataSource = bs;


            }
        }
    }
}
