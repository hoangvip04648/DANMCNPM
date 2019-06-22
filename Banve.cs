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
    public partial class Banve : Form
    {
        DataConnection dc;
        SqlCommand cmd;
        SqlDataAdapter da;
        ChuyenbayBLL bll_Chuyenbay;

        public Banve()
        {
            InitializeComponent();
            dc = new DataConnection();
            bll_Chuyenbay = new ChuyenbayBLL();
        }

        public void ShowComboBoxDi()
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from SANBAY",con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            comboBox_sbdi.DataSource = table;
            comboBox_sbdi.DisplayMember = "TENSANBAY";
            comboBox_sbdi.ValueMember = "MASB";

        }

        public void ShowComboBoxDen()
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from SANBAY", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
          

            comboBox_sbden.DataSource = table;
            comboBox_sbden.DisplayMember = "TENSANBAY";
            comboBox_sbden.ValueMember = "MASB";

        }


        public void ShowComboBoxHv()
        {
            SqlConnection con = dc.GetConnect();
            cmd = new SqlCommand("Select * from HANGVE", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);


            comboBox_hv.DataSource = table;
            comboBox_hv.DisplayMember = "TENHV";
            comboBox_hv.ValueMember = "MAHV";

        }

        private void Banve_Load(object sender, EventArgs e)
        {
            this.ShowComboBoxDi();
            this.ShowComboBoxDen();
            this.ShowComboBoxHv();
            


            





        }


        private void TaoBangDSChuyenBayTheoYeuCau(string maSanBayDen, string maSanBayDi, DateTime thoiGianKH, DateTime thoiGianKH2, string tmp)
        {
            DataTable dtChuyenBay = bll_Chuyenbay.Search(maSanBayDen,maSanBayDi, thoiGianKH,thoiGianKH2,tmp);
            dataGridView_tracuu.DataSource = dtChuyenBay;
            dataGridView_tracuu.Sort(dataGridView_tracuu.Columns[0], ListSortDirection.Descending);
            dataGridView_tracuu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_tracuu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }


        private void button_Timkiem_Click(object sender, EventArgs e)
        {
            if (comboBox_sbdi.Text != "" && comboBox_sbden.Text != "" && dateTimePicker_thoigian1.Text != "")
            {
                try
                {
                    string maSanBayDi = comboBox_sbdi.SelectedValue.ToString();
                    string maSanBayDen = comboBox_sbden.SelectedValue.ToString();
                    DateTime ngayKH = dateTimePicker_thoigian1.Value;
                    DateTime ngayKH2 = dateTimePicker_thoigian2.Value;
                    string tmp = dateTimePicker_thoigian1.Value.ToShortDateString();
                    
                    TaoBangDSChuyenBayTheoYeuCau(maSanBayDi, maSanBayDen, ngayKH,ngayKH2,tmp);
                }
                catch (Exception a)
                {

                }
                finally
                {
                    // TaoLai();
                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //string maSanBayDi = comboBox_sbdi.SelectedValue.ToString();
            //string maSanBayDen = comboBox_sbden.SelectedValue.ToString();
            //DateTime ngayKH = dateTimePicker_thoigian.Value;

            //TaoBangDSChuyenBayTheoYeuCau(maSanBayDi, maSanBayDen, ngayKH);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox_test.Text = dateTimePicker_thoigian1.Value.ToString();

        }
    }
}
