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

namespace WindowsFormsApp1.childForm
{
    public partial class contractStatistic : Form
    {
        public contractStatistic()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Quanlyxedulichh;Integrated Security=True");
        string SearchQueryCmdFull = @"SELECT * FROM dbo.[Contract] ;";
        string SearchQueryCmd;
        DataSet contractStatistic_ds = new DataSet();

        private void FillDataToGirdView1(string QueryCmd, DataSet carStatistic_ds)
        {
            carStatistic_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(carStatistic_ds);
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = carStatistic_ds.Tables[0].DefaultView;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void contractStatistic_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillDataToGirdView1(SearchQueryCmdFull, contractStatistic_ds);

        }

        private void contractStatistic_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void changeVisibility()
        {
            if (panelOptionalFilter.Visible == true)
                panelOptionalFilter.Visible = false;
            else {

                panelOptionalFilter.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Thống kê tất cả hợp đồng
            Thống kê hợp đồng trong tháng
            Thống kê hợp đồng thuê theo ngày tuỳ chọn
            Thống kê hợp đồng đã thanh toán
            Thống kê hợp đồng đã thanh toán theo ngày tuỳ chọn
            Thống kê hợp đồng chưa thanh toán*/
            switch (comboBox1.SelectedIndex)
            {
                // Thống kê tất cả phiếu mượn
                case 0:
                    SearchQueryCmd = @"Select * from dbo.Contract;";
                    FillDataToGirdView1(SearchQueryCmd, contractStatistic_ds);
                    break;

                // Thống kê phiếu mượn trong tháng
                case 1:
                    SearchQueryCmd = @"Select * from dbo.Contract
		                            where (MONTH(dbo.Contract.dateRent) = MONTH(GETDATE()) 
			                        AND YEAR(dbo.Contract.dateRent) = YEAR(GETDATE()));";
                    FillDataToGirdView1(SearchQueryCmd, contractStatistic_ds);

                    break;

                // Thống kê phiếu mượn theo ngày tuỳ chọn
                case 2:
                    changeVisibility();
                    break;

                // Thống kê phiếu mượn đã trả trong tháng
                case 3:
                    SearchQueryCmd = @"Select * from dbo.Contract 
		                                where (MONTH(dbo.Contract.dateReturn) = MONTH(GETDATE()) 
			                            AND YEAR(dbo.Contract.dateReturn) = YEAR(GETDATE()));";
                    FillDataToGirdView1(SearchQueryCmd, contractStatistic_ds);

                    break;
                // Thống kê phiếu mượn đã trả theo ngày tuỳ chọn
                case 4:
                    changeVisibility();
                    break;
                // Thống kê phiếu mượn chưa trả
                case 5:
                    SearchQueryCmd = @"Select * from dbo.Contract 
		                               where (dbo.Contract.dateReturn is NULL);";
                    FillDataToGirdView1(SearchQueryCmd, contractStatistic_ds);

                    break;

            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Thống kê hợp đồng theo ngày tuỳ chọn")
            {
                SearchQueryCmd = @"Select * from dbo.phieumuon 
		        where (dbo.Contract.dateRent >='" + dtpStartDate.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.Contract.dateRent <= '" + dtpEndDate.Value.Date.ToString("yyyy/MM/dd") + "');";
                FillDataToGirdView1(SearchQueryCmd, contractStatistic_ds);

            }
            else if (comboBox1.Text == "Thống kê hợp đồng đã thanh toán theo ngày tuỳ")
            {
                SearchQueryCmd = @"Select * from dbo.phieumuon 
		        where (dbo.Contract.dateRent >='" + dtpStartDate.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.Contract.dateRent <= '" + dtpEndDate.Value.Date.ToString("yyyy/MM/dd") + "');";
                FillDataToGirdView1(SearchQueryCmd, contractStatistic_ds);
            }
        }
    }
}
