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
    public partial class carType : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Quanlyxedulichh;Integrated Security=True");
        string SearchQueryCmdFull = @"SELECT * FROM dbo.Type ;";
        string SearchQueryCmd;
        DataSet type_ds = new DataSet();

        public carType()
        {
            InitializeComponent();
        }

        private void carType_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillDataToGirdView(SearchQueryCmdFull, type_ds);
        }

        private void Manager_BookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void FillDataToGirdView(string QueryCmd, DataSet type_ds)
        {
            type_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(type_ds);
            dataGridView.AutoSize = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = type_ds.Tables[0].DefaultView;
        }

        private void clearText()
        {
            tbxCarType.Text = "";
            tbxPricePerHourExceed.Text = "";
            tbxPricePerKmExceed.Text = "";
        }

        private void fillTextBox(int rowNum)
        {
            tbxCarType.ReadOnly = true;

            if ((dataGridView.Rows[rowNum].Cells[0].Value.ToString() is "") is false)
            {
                tbxCarType.Text = dataGridView.Rows[rowNum].Cells[0].Value.ToString();
                tbxPricePerKmExceed.Text = dataGridView.Rows[rowNum].Cells[1].Value.ToString();
                tbxPricePerHourExceed.Text = dataGridView.Rows[rowNum].Cells[2].Value.ToString();
            }
            else
            {
                clearText();
                tbxCarType.ReadOnly = false;
            }

        }

        private void executeCmd()
        {
            SqlCommand sqlMethod = new SqlCommand(SearchQueryCmd, conn);
            sqlMethod.ExecuteNonQuery();
            FillDataToGirdView(SearchQueryCmdFull, type_ds);
            clearText();
        }

        private bool isExist()
        {
            SqlCommand CmdCheck = new SqlCommand(@"SELECT * FROM dbo.Type WHERE Type.carType ='" + tbxCarType.Text.Trim() + "'", conn);
            if (CmdCheck.ExecuteScalar() is null) { return false; }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SearchQueryCmd = @"insert into dbo.[Type](carType, pricePerDayExceed, interest) values (N'" + tbxCarType.Text + "', '" + tbxPricePerKmExceed.Text + "','" + tbxPricePerHourExceed.Text + "')";
            executeCmd();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTextBox(dataGridView.CurrentRow.Index);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                SearchQueryCmd = "UPDATE dbo.[Type] set carType = N'" + tbxCarType.Text.Trim() + "', pricePerDayExceed = '" + tbxPricePerKmExceed.Text.Trim() + "',interest = '" + tbxPricePerHourExceed.Text.Trim() + "' where carType = '" + tbxCarType.Text + "' ";
                executeCmd();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                SearchQueryCmd = "DELETE FROM dbo.[Type] where carType ='" + tbxCarType.Text.Trim() + "'";
                executeCmd();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Tìm kiếm") { 
            string keyword = tbxCarType.Text.Trim();
            bool IsNumber = int.TryParse(keyword, out int number);
            if (IsNumber)
            {
                SearchQueryCmd = @"SELECT * FROM dbo.[Type] WHERE Type.carType ='" + keyword + "'";
                FillDataToGirdView(SearchQueryCmd, type_ds);
                if (isExist()) { fillTextBox(0); }
                else { MessageBox.Show("Mã xe " + tbxCarType.Text + " không tồn tại!"); }
            }
            else
            {
                if (keyword != "")
                {
                    SearchQueryCmd = @"SELECT * FROM dbo.[Type] WHERE [Type].carType like N'%" + keyword + "%'";
                    FillDataToGirdView(SearchQueryCmd, type_ds);
                }
                else { MessageBox.Show("Vui lòng nhập dữ liệu tìm kiếm!"); }
            }
                btnSearch.Text = "Hủy tìm kiếm";
            }
            else
            {
                FillDataToGirdView(SearchQueryCmdFull, type_ds);
                btnSearch.Text = "tìm kiếm";
            }
        }
        
     
    }
}
