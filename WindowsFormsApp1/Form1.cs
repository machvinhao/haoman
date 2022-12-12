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

namespace WindowsFormsApp1
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
            command.CommandText = "select * from Sanpham";
            adapter.SelectCommand = command; // thuc thi truy van
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_msp.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_ten.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_giatien.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_soluong.Text =  dgv.Rows[i].Cells[3].Value.ToString();
            tb_maloai.Text = dgv.Rows[i].Cells[4].Value.ToString();
            textBox1.Text = dgv.Rows[i].Cells[5].Value.ToString();
            textBox2.Text = dgv.Rows[i].Cells[6].Value.ToString();
            textBox3.Text = dgv.Rows[i].Cells[7].Value.ToString();
            textBox4.Text = dgv.Rows[i].Cells[8].Value.ToString();
            textBox5.Text = dgv.Rows[i].Cells[9].Value.ToString();
            textBox6.Text = dgv.Rows[i].Cells[10].Value.ToString();
            textBox7.Text = dgv.Rows[i].Cells[11].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Sanpham values('"+tb_msp.Text+"' , '"+tb_ten.Text+"', '"+tb_giatien.Text+"','"+tb_soluong.Text+"', '"+tb_maloai.Text+ "', '"+textBox1.Text+"', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
            _ = command.ExecuteNonQuery(); //tra cau truy van
            loadData();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command= connection.CreateCommand();
            command.CommandText = "delete from Sanpham where Masp ='"+tb_msp.Text+"'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void bt_khoitao_Click(object sender, EventArgs e)
        {
            tb_msp.Text = "";
            tb_ten.Text = "";
            tb_giatien.Text = "";
            tb_soluong.Text = "";
            tb_maloai.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
