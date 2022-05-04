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
    public partial class carDepot : Form
    {
        public carDepot()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Quanlyxedulichh;Integrated Security=True");
        string SearchQueryCmdFull = @"SELECT * FROM dbo.[Car] ;";
        string SearchQueryCmd;
        DataSet carDepot_ds = new DataSet();
        DataSet type_ds = new DataSet();

        private void carDepot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyxedulichhDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.quanlyxedulichhDataSet.Type);
            conn.Open();
            FillDataToGirdView1(SearchQueryCmdFull,carDepot_ds);
            FillDataToGirdView2(@"SELECT * FROM dbo.Type ; ",type_ds);

        }

        private void carDepot_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void FillDataToGirdView1(string QueryCmd, DataSet type_ds)
        {
            type_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(type_ds);
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = type_ds.Tables[0].DefaultView;
        }

        private void FillDataToGirdView2(string QueryCmd, DataSet type_ds)
        {
            type_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(type_ds);
            dataGridView2.AutoSize = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = type_ds.Tables[0].DefaultView;
        }

        private void clearText()
        {
            tbxCarID.Text = "";
            tbxCarName.Text = "";
            cbxCarType.SelectedIndex = 0;
            cbxBrand.SelectedIndex = 0;
            cbxSeatNumber.SelectedIndex = 0;
            tbxLicencePlate.Text = "";
            tbxRentPricePerDay.Text = "";
            cbxStatus.SelectedIndex = 0;
        }

        private void executeCmd()
        {
            SqlCommand sqlMethod = new SqlCommand(SearchQueryCmd, conn);
            sqlMethod.ExecuteNonQuery();
            FillDataToGirdView1(SearchQueryCmdFull, carDepot_ds);
            clearText();
        }

        private bool isExist()
        {
            SqlCommand CmdCheck = new SqlCommand(@"SELECT * FROM dbo.[Car] WHERE [Car].carID ='" + tbxCarID.Text.Trim() + "'", conn);
            if (CmdCheck.ExecuteScalar() is null) { return false; }
            return true;
        }

        private void fillTextBox(int rowNum)
        {

            if ((dataGridView1.Rows[rowNum].Cells[0].Value.ToString() is "") is false)
            {
                tbxCarID.Text = dataGridView1.Rows[rowNum].Cells[0].Value.ToString();
                tbxCarName.Text = dataGridView1.Rows[rowNum].Cells[1].Value.ToString();
                //cbxCarType = dataGridView1.Rows[rowNum].Cells[2].Value;
                cbxCarType.SelectedIndex = returnIndex(cbxCarType, dataGridView1.Rows[rowNum].Cells[3].Value.ToString());
                //cbxBrand = dataGridView1.Rows[rowNum].Cells[3].Value.ToString();
                cbxBrand.SelectedIndex = returnIndex(cbxBrand, dataGridView1.Rows[rowNum].Cells[2].Value.ToString());
                //cbxSeatNumber = dataGridView1.Rows[rowNum].Cells[4].Value.ToString
                cbxSeatNumber.SelectedIndex = returnIndex(cbxSeatNumber, dataGridView1.Rows[rowNum].Cells[4].Value.ToString());
                tbxLicencePlate.Text = dataGridView1.Rows[rowNum].Cells[5].Value.ToString();
                tbxRentPricePerDay.Text = dataGridView1.Rows[rowNum].Cells[6].Value.ToString();
                //cbxStatus = dataGridView1.Rows[rowNum].Cells[7].Value.ToString();
                cbxStatus.SelectedIndex = returnIndex(cbxStatus, dataGridView1.Rows[rowNum].Cells[7].Value.ToString());
            }
            else
            {
                clearText();
            }
        }

        private int returnIndex(ComboBox cbx, string str)
        {
            for ( int i = 0; i< Convert.ToInt16(cbx.Items.Count); i++ )
            {
                if (string.Equals((cbx.SelectedIndex=i).ToString(),str))
                {
                    return i;
                }
            }
            return 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTextBox(dataGridView1.CurrentRow.Index);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //tbxCarName.Text = cbxCarType.Selected1.ToString();
            SearchQueryCmd = @"insert into dbo.[Car](carName,brand,carType,seatNumber,licencePlate,rentPricePerDay,status ) values (N'" + tbxCarName.Text+"',N'"+cbxBrand.SelectedItem.ToString()+"','"+ cbxCarType.SelectedValue.ToString() + "',N'"+cbxSeatNumber.SelectedItem.ToString() + "',N'"+tbxLicencePlate.Text+"',N'"+tbxRentPricePerDay.Text+"',N'"+cbxStatus.SelectedItem.ToString() + "')";
            executeCmd();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                SearchQueryCmd = "UPDATE dbo.[Car] set carName = N'"+tbxCarName.Text.Trim()+"',brand = N'"+cbxBrand.SelectedItem.ToString()+"',carType = '" + cbxCarType.SelectedValue.ToString() + "',seatNumber = N'" + cbxSeatNumber.SelectedItem.ToString() + "',licencePlate = '"+tbxLicencePlate.Text+"',rentPricePerDay = '"+tbxRentPricePerDay.Text+"',status =N'"+cbxStatus.SelectedItem.ToString()+"'  where carID = '" + tbxCarID.Text + "' ";
                executeCmd();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                SearchQueryCmd = "DELETE FROM dbo.[Car] where carID ='" + tbxCarID.Text.Trim() + "'";
                executeCmd();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Tìm kiếm")
            {
                string keyword = tbxCarName.Text.Trim();
                bool IsNumber = int.TryParse(keyword, out int number);
                if (IsNumber)
                {
                    SearchQueryCmd = @"SELECT * FROM dbo.[Car] WHERE Car.carName ='" + keyword + "'";
                    FillDataToGirdView1(SearchQueryCmd, type_ds);
                    if (isExist()) { fillTextBox(0); }
                    else { MessageBox.Show("Mã xe " + tbxCarName.Text + " không tồn tại!"); }
                }
                else
                {
                    if (keyword != "")
                    {
                        SearchQueryCmd = @"SELECT * FROM dbo.[Car] WHERE [Car].carName like N'%" + keyword + "%'";
                        FillDataToGirdView1(SearchQueryCmd, type_ds);
                    }
                    else { MessageBox.Show("Vui lòng nhập dữ liệu tìm kiếm!"); }
                }
                btnSearch.Text = "Hủy tìm kiếm";
            }
            else
            {
                FillDataToGirdView1(SearchQueryCmdFull, carDepot_ds);
                btnSearch.Text = "tìm kiếm";
            }
        }
    }
}
