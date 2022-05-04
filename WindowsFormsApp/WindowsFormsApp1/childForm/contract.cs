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
    public partial class contract : Form
    {
        public contract()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Quanlyxedulichh;Integrated Security=True");
        string SearchQueryCmdFull = @"SELECT * FROM dbo.[Contract] ;";
        string SearchQueryCmd;
        DataSet contract_ds = new DataSet();
        DataSet carDepot_ds = new DataSet();
        DataSet type_ds = new DataSet();

        private void contract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyxedulichhDataSet1.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.quanlyxedulichhDataSet1.Car);
            FillDataToGirdViewMain(SearchQueryCmdFull, contract_ds);
            FillDataToGirdViewSub1(@"SELECT * FROM dbo.Car ;", carDepot_ds);
            FillDataToGirdViewSub2(@"SELECT * FROM dbo.Type ; ", type_ds);
            conn.Open();
        }

        private void fillTextBox(int rowNum)
        {

            if ((dataGridViewMain.Rows[rowNum].Cells[0].Value.ToString() is "") is false)
            {
                tbxContractID.Text = dataGridViewMain.Rows[rowNum].Cells[0].Value.ToString();
                tbxCustomerName.Text = dataGridViewMain.Rows[rowNum].Cells[2].Value.ToString();
                tbxCustomerID.Text = dataGridViewMain.Rows[rowNum].Cells[2].Value.ToString();
                tbxPhoneNumber.Text = dataGridViewMain.Rows[rowNum].Cells[3].Value.ToString();
                cbxCarID.SelectedValue = dataGridViewMain.Rows[rowNum].Cells[4].Value.ToString(); 
                dtpDateRent.Value = DateTime.Parse(dataGridViewMain.Rows[rowNum].Cells[5].Value.ToString());
                dtpDateReturnExpected.Value = DateTime.Parse(dataGridViewMain.Rows[rowNum].Cells[6].Value.ToString());
                dtpDateReturn.Value = DateTime.Parse(dataGridViewMain.Rows[rowNum].Cells[7].Value.ToString());
                tbxDeposit.Text = dataGridViewMain.Rows[rowNum].Cells[8].Value.ToString();
                cbxStatus.SelectedIndex = returnIndex(cbxStatus, dataGridViewMain.Rows[rowNum].Cells[10].Value.ToString());
            }
            else
            {
                clearText();
            }
        }

        private int returnIndex(ComboBox cbx, string str)
        {
            for (int i = 0; i < Convert.ToInt16(cbx.Items.Count); i++)
            {
                if (string.Equals((cbx.SelectedIndex = i).ToString(), str))
                {
                    return i;
                }
            }
            return 0;
        }

        private void clearText()
        {
            tbxCustomerName.Text = "";
            tbxCustomerID.Text = "";
            tbxPhoneNumber.Text = "";
            cbxCarID.SelectedIndex = 0;
            dtpDateRent.Value = DateTime.Today;
            dtpDateReturnExpected.Value = DateTime.Today;
            dtpDateReturn.Value = DateTime.Today;
            cbxStatus.SelectedIndex = 0;
        }

        private void executeCmd()
        {
            SqlCommand sqlMethod = new SqlCommand(SearchQueryCmd, conn);
            sqlMethod.ExecuteNonQuery();
            FillDataToGirdViewMain(SearchQueryCmdFull, contract_ds);
            clearText();
        }

        private bool isExist()
        {
            SqlCommand CmdCheck = new SqlCommand(@"SELECT * FROM dbo.Contract WHERE Contract.contractID ='" + tbxContractID.Text.Trim() + "'", conn);
            if (CmdCheck.ExecuteScalar() is null) { return false; }
            return true;
        }

        private void FillDataToGirdViewMain(string QueryCmd, DataSet contract_ds)
        {
            contract_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(contract_ds);
            dataGridViewMain.AutoSize = true;
            dataGridViewMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMain.DataSource = contract_ds.Tables[0].DefaultView;
        }

        private void FillDataToGirdViewSub1(string QueryCmd, DataSet carDepot_ds)
        {
            carDepot_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(carDepot_ds);
            dataGridViewSub1.AutoSize = true;
            dataGridViewSub1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSub1.DataSource = carDepot_ds.Tables[0].DefaultView;
        }

        private void FillDataToGirdViewSub2(string QueryCmd, DataSet type_ds)
        {
            type_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(type_ds);
            dataGridViewSub2.AutoSize = true;
            dataGridViewSub2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSub2.DataSource = type_ds.Tables[0].DefaultView;
        }

        private void contract_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                SearchQueryCmd = @"insert into dbo.[Contract](customerName,customerID,phoneNumber,carID,dateRent,dateReturnExpected,dateReturn,deposit,payment,status ) values (N'" + tbxCustomerName.Text + "',N'" + tbxCustomerID.Text + "','" + tbxPhoneNumber.Text + "',N'" + cbxCarID.SelectedValue.ToString() + "','" + dtpDateRent.Value.ToString("yyyy/MM/dd") + "','" + dtpDateReturnExpected.Value.ToString("yyyy/MM/dd") + "', NULL,'"+tbxDeposit.Text+"','0',N'" + cbxStatus.SelectedItem.ToString() + "')";
                executeCmd();

            
            //SearchQueryCmd = "UPDATE dbo.[Contract] set dbo.Contract.payment = (dbo.Car.rentPricePerDay * (dbo.Car.dateReturnExpected-dbo.Car.dateRent) + ()) ;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                if (cbxStatus.SelectedValue == "Đã thanh toán")
                {
                    SearchQueryCmd = "UPDATE Contract set payment = (Car.rentPricePerDay * (DATEDIFF(day, Contract.daterent, Contract.dateReturnExpected)) + (DATEDIFF(day, Contract.dateReturnExpected, Contract.dateReturn)) * Type.pricePerDayExceed) FROM Contract, Car, Type where(Car.carID = Contract.carId) AND(Car.carType = Type.carType) AND (Contract.contractID = N'"+tbxContractID+"')";
                    SearchQueryCmd = "UPDATE dbo.[Contract](set customerName =N'" + tbxCustomerName + "', customerID = N'" + tbxCustomerID + "',phoneNumber = '" + tbxPhoneNumber + "' ,carID ='" + cbxCarID.SelectedItem.ToString() + "',dateRent = '" + dtpDateRent.Value.ToString("yyyy/MM/dd") + "',dateReturnExpected = '" + dtpDateReturnExpected.Value.ToString("yyyy / MM / dd") + "',dateReturn = '"+dtpDateReturn.Value.ToString("yyyy/MM/dd")+"',deposit = '" + tbxDeposit.ToString() + "'N'" + cbxStatus.SelectedItem.ToString() + "')";
                }
                else
                {
                SearchQueryCmd = "UPDATE dbo.[Contract](set customerName =N'" + tbxCustomerName + "', customerID = N'" + tbxCustomerID + "',phoneNumber = '" + tbxPhoneNumber + "' ,carID ='" + cbxCarID.SelectedItem.ToString() + "',dateRent = '" + dtpDateRent.Value.ToString("yyyy/MM/dd") + "',dateReturnExpected = '" + dtpDateReturnExpected.Value.ToString("yyyy / MM / dd") + "',dateReturn = 'NULL',deposit = '"+tbxDeposit.ToString()+"'N'" + cbxStatus.SelectedItem.ToString() + "')"; 
                executeCmd();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                SearchQueryCmd = "DELETE FROM dbo.[Contract] where contractID ='" + tbxContractID.Text.Trim() + "'";
                executeCmd();
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Tìm kiếm")
            {
                string keyword = tbxContractID.Text.Trim();
                bool IsNumber = int.TryParse(keyword, out int number);
                if (IsNumber)
                {
                    SearchQueryCmd = @"SELECT * FROM dbo.[Contract] WHERE Contract.contractID ='" + keyword + "'";
                    FillDataToGirdViewMain(SearchQueryCmd, type_ds);
                    if (isExist()) { fillTextBox(0); }
                    else { MessageBox.Show("Mã xe " + tbxContractID.Text + " không tồn tại!"); }
                }
                else
                {
                    if (keyword != "")
                    {
                        SearchQueryCmd = @"SELECT * FROM dbo.[Contract] WHERE [Contract].contractID like N'%" + keyword + "%'";
                        FillDataToGirdViewMain(SearchQueryCmd, type_ds);
                    }
                    else { MessageBox.Show("Vui lòng nhập dữ liệu tìm kiếm!"); }
                }
                btnSearch.Text = "Hủy tìm kiếm";
            }
            else
            {
                FillDataToGirdViewMain(SearchQueryCmdFull, carDepot_ds);
                btnSearch.Text = "tìm kiếm";
            }
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillTextBox(dataGridViewMain.CurrentRow.Index);
        }
    }
}
