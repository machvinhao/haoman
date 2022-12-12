using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"data source=LAPTOP-Q0OIV3BA\SQLEXPRESS;initial catalog=QLdienthoai;persist security info=True;user id=sa;password=sa";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        //hien thi du lieu
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Donhang";
            adapter.SelectCommand = command; // thuc thi truy van
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;
        private void bt_print_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
