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

namespace QLBVMB
{
    public partial class QL_Sanbay : Form
    {
        SanbayBLL bllSB;
        DataConnection dc;
        public QL_Sanbay()
        {
            InitializeComponent();
            bllSB = new SanbayBLL();
        }

        public void ShowAllSanbay()
        {
            DataTable dt = bllSB.getAllSanbay();
            dataGridView_Sanbay.DataSource = dt;
        }

        private void QL_Sanbay_Load(object sender, EventArgs e)
        {
            ShowAllSanbay();
        }

        private bool CheckData()
        {
            //if (string.IsNullOrEmpty(textBox_masb.Text) || string.IsNullOrEmpty(textBox_tensb.Text))
            if (string.IsNullOrEmpty(textBox_tensb.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_masb.Focus(); //để con trỏ vào đây
                return false;
            }
            return true;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Sanbay sb = new Sanbay();
                //sb.masb = textBox_masb.Text;
                sb.tensb = textBox_tensb.Text;
                
                if (bllSB.InsertSanbay(sb))
                {
                    ShowAllSanbay();
                    textBox_masb.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tensb.Clear();                
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dataGridView_Sanbay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                //_ID = Int32.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                textBox_masb.Text = dataGridView_Sanbay.Rows[index].Cells["MASB"].Value.ToString();
                textBox_tensb.Text = dataGridView_Sanbay.Rows[index].Cells["TENSANBAY"].Value.ToString();
            }
        }



        private void button_Update_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                Sanbay sb = new Sanbay();

                sb.tensb = textBox_tensb.Text;
                sb.masb = textBox_masb.Text;
          

                if (bllSB.UpdateSanbay(sb))
                {
                    ShowAllSanbay();
                    textBox_masb.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tensb.Clear();

                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sân bay này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Sanbay sb = new Sanbay();
                //sb.id = _ID;
                sb.masb = textBox_masb.Text;
                if (bllSB.DeleteSanbay(sb))
                {
                    ShowAllSanbay();
                    textBox_masb.Clear();    // Clear() để xóa hết kí tự khi vừa thêm xong
                    textBox_tensb.Clear();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin hãy thử lại!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //--------------------------------------------
        //public DataTable GetAndSortDesc()
        //{
        //    SqlConnection con = dc.GetConnect();
        //    string sqlQuery = "SELECT MASB, TENSANBAY FROM SANBAY ORDER BY MASB DESC";
        //    SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        //private string TaoMaSanBay()
        //{
        //    DataTable dt = this.GetAndSortDesc();
        //    if (dt.Rows.Count == 0)
        //        return "SB000" + dt.Rows.Count;
        //    DataRow row = dt.Rows[0];
        //    string maTuyenBay = row[0].ToString().Substring(2);
        //    int count = int.Parse(maTuyenBay) + 1;
        //    int temp = count;
        //    string strSoKhong = "";
        //    int dem = 0;
        //    while (temp > 0)
        //    {
        //        temp /= 10;
        //        dem++;
        //    }
        //    for (int i = 0; i < 4 - dem; i++)
        //    {
        //        strSoKhong += "0";
        //    }
        //    return "SB" + strSoKhong + count;
        //}


    }
}
