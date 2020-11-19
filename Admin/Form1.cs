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

namespace Admin
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataReader reader;
        SqlCommand cmd;
        public int tagihan = 0;
        public string linkfoto;
        public Form1()
        {
            InitializeComponent();

            conn = new SqlConnection("server = localhost; data source = localhost\\SQLEXPRESS; database = DB_DATA; integrated security = SSPI");
            conn.Open();

            TombolCetak.Enabled = false;
            HargaMenu.Minimum = 5000;
            HargaMenu.Maximum = 100000;
            HargaMenu.Increment = 250;
            TotalPenjualan.Text = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Meja1.BackColor = Color.Green;
            Meja2.BackColor = Color.Green;
            Meja3.BackColor = Color.Green;
            Meja4.BackColor = Color.Green;
            Meja5.BackColor = Color.Green;
            Meja6.BackColor = Color.Green;
            Meja7.BackColor = Color.Green;
            Meja8.BackColor = Color.Green;
            Meja9.BackColor = Color.Green;
            Meja10.BackColor = Color.Green;
            cmd = new SqlCommand("select TableNum from Meja where flag = 1 group by TableNum", conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    string temp = reader[0].ToString();
                    if (temp == "1")
                        Meja1.BackColor = Color.Yellow;
                    else if (temp == "2")
                        Meja2.BackColor = Color.Yellow;
                    else if (temp == "3")
                        Meja3.BackColor = Color.Yellow;
                    else if (temp == "4")
                        Meja4.BackColor = Color.Yellow;
                    else if (temp == "5")
                        Meja5.BackColor = Color.Yellow;
                    else if (temp == "6")
                        Meja6.BackColor = Color.Yellow;
                    else if (temp == "7")
                        Meja7.BackColor = Color.Yellow;
                    else if (temp == "8")
                        Meja8.BackColor = Color.Yellow;
                }
            reader.Close();
        }

        private void Meja1_Click(object sender, EventArgs e)
        {
            PrintBill("1", Meja1.BackColor);
        }

        private void Meja2_Click(object sender, EventArgs e)
        {
            PrintBill("2", Meja2.BackColor);
        }

        private void Meja3_Click(object sender, EventArgs e)
        {
            PrintBill("3", Meja3.BackColor);
        }

        private void Meja4_Click(object sender, EventArgs e)
        {
            PrintBill("4", Meja4.BackColor);
        }
        private void Meja5_Click(object sender, EventArgs e)
        {
            PrintBill("5", Meja5.BackColor);
        }
        private void Meja6_Click(object sender, EventArgs e)
        {
            PrintBill("6", Meja6.BackColor);
        }
        private void Meja7_Click(object sender, EventArgs e)
        {
            PrintBill("7", Meja7.BackColor);
        }
        private void Meja8_Click(object sender, EventArgs e)
        {
            PrintBill("8", Meja8.BackColor);
        }
        private void Meja9_Click(object sender, EventArgs e)
        {
            PrintBill("9", Meja9.BackColor);
        }
        private void Meja10_Click(object sender, EventArgs e)
        {
            PrintBill("10", Meja10.BackColor);
        }

        private void TombolCetak_Click(object sender, EventArgs e)
        {
            if (BillMeja.Rows.Count > 1)
            {
                tagihan = 0;

                for (int i = 0; i < BillMeja.Rows.Count; i++)
                    tagihan += Convert.ToInt32(BillMeja.Rows[i].Cells[3].Value);

                string sql = String.Format("insert into Admin values('{0}',convert(varchar,cast({1} as money)),'{2}')", lblNoMeja.Text, tagihan, DateTimeOffset.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                PrintPreviewDialog ppd1 = new PrintPreviewDialog();
                ppd1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("tes", 285, 600);
                ppd1.ShowDialog();

                sql = String.Format("Update Meja set flag = 0 where TableNum = '{0}'", lblNoMeja.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = String.Format("Delete from Meja where TableNum = '{0}'", lblNoMeja.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                BillMeja.DataSource = null;

                Form1_Load(null, null);
            }
        }

        private void Tanggal_ValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select * from Admin where Tanggal = '{Tanggal.Value.ToString("yyyy/MM/dd")}'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Rekap");
            RincianPenjualan.DataSource = ds.Tables["Rekap"];
            int sum = 0;
            for (int i = 0; i < RincianPenjualan.Rows.Count; i++)
                sum += Convert.ToInt32(RincianPenjualan.Rows[i].Cells[1].Value);
            TotalPenjualan.Text = $"Rp.{sum:N}";
            if (RincianPenjualan.Rows.Count < 1)
                RincianPenjualan.DataSource = null;
        }

        private void NamaMenu_Leave(object sender, EventArgs e)
        {
            TombolSimpan.Enabled = true;
            string sql = String.Format("select NamaMenu, GambarMenu, HargaMenu from Menu where NamaMenu = '{0}'", NamaMenu.Text);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            TombolSimpan.Text = "Save";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HargaMenu.Value = Convert.ToDecimal(reader[2]);
                    pictureBox1.Image = Image.FromFile($"{reader[1].ToString()}");
                    linkfoto = reader[1].ToString();
                }

                TombolSimpan.Text = "Update";
                TombolDelete.Enabled = true;
            }
            reader.Close();
        }

        private void TombolMasukkan_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Images";
            openFileDialog1.Filter = "All Images|*.jpg;*.png;*.bmp";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                linkfoto = openFileDialog1.FileName.ToString();
                pictureBox1.Image = Image.FromFile(linkfoto);
            }

        }

        private void TombolSimpan_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (TombolSimpan.Text == "Update")
                {
                    string sql = String.Format("update Menu set HargaMenu = convert(money,{0}), GambarMenu = '{1}' where NamaMenu = '{2}'", HargaMenu.Value, linkfoto, NamaMenu.Text);
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                }
                else
                {
                    string sql = String.Format("Insert into Menu values('{0}','{1}',convert(money,{2}),0)", NamaMenu.Text, linkfoto, HargaMenu.Value);
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                Reset();
            }

        }
        private void TombolDelete_Click(object sender, EventArgs e)
        {
            if (TombolSimpan.Text == "Update")
            {
                string sql = String.Format("Delete from Menu where NamaMenu = '{0}'", NamaMenu.Text);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Reset();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("SeaDishes", new Font("Consolas", 25, FontStyle.Bold), Brushes.Black, new Point(50, 10));
            e.Graphics.DrawLine(Pens.Black, new Point(0, 50), new Point(285, 50));
            e.Graphics.DrawLine(Pens.Black, new Point(0, 53), new Point(285, 53));
            e.Graphics.DrawString($"{DateTimeOffset.Now.ToString("dd MMM yyyy hh:mm:ss")}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(60, 60));

            string sql = String.Format("select m.NamaMenu,Qty, (HargaMenu * Qty) from Meja m inner join Menu n on m.NamaMenu = n.NamaMenu where TableNum = '{0}'", lblNoMeja.Text);
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            int inc = 0, initial = 110;
            e.Graphics.DrawString("Pesanan", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(30, 90));
            e.Graphics.DrawString("@", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(120, 90));
            e.Graphics.DrawString("Total", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(150, 90));
            while (reader.Read())
            {
                e.Graphics.DrawString($"{reader[0].ToString()}", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(30, initial + inc));
                e.Graphics.DrawString($"{reader[1].ToString()}", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(120, initial + inc));
                e.Graphics.DrawString($"Rp.{reader[2].ToString()}", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(150, initial + inc));
                inc += 15;
            }
            e.Graphics.DrawString($"Grand Total ....... Rp.{tagihan.ToString()}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(48, initial + inc + 20));
            e.Graphics.DrawString("Enjoy", new Font("Lucida Handwriting", 25, FontStyle.Bold), Brushes.Black, new Point(50, initial + inc + 40));
            reader.Close();
        }

        public void PrintBill(string noMeja, Color bg)
        {
            SqlDataAdapter da = new SqlDataAdapter($"select t.NamaMenu, HargaMenu, Qty, HargaMenu*Qty Total, Tanggal from Menu m inner join Meja t on m.NamaMenu = t.NamaMenu where TableNum = {noMeja}", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Menu");
            BillMeja.DataSource = ds.Tables["Menu"];
            lblNoMeja.Text = noMeja;
            if (bg == Color.Yellow)
                TombolCetak.Enabled = true;
            else
                TombolCetak.Enabled = false;
        }

        public void Reset()
        {
            TombolSimpan.Text = "Save";
            NamaMenu.Text = "";
            HargaMenu.Value = HargaMenu.Minimum;
            pictureBox1.Image = null;
            linkfoto = "";
            TombolSimpan.Enabled = false;
            TombolDelete.Enabled = false;
        }
    }
}
