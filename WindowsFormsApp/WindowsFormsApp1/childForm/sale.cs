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
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Quanlyxedulichh;Integrated Security=True");
        string SearchQueryCmdFull = @"SELECT temp.carID, temp.carName,  count(Contract.contractID) as numberOfContractID ,sum(Contract.payment * temp.interest ) as sumOfInterestPayment from  (select Car.carID, Car.carName,  Type.interest from  Car inner join Type on Car.[carType] = Type.[carType]) as temp, Contract where  Contract.CarID = temp.CarID group by temp.carID, temp.carName;";
        string SearchQueryCmd;
        DataSet saleStatistic_ds = new DataSet();

        private void FillDataToGirdView(string QueryCmd, DataSet saleStatistic_ds)
        {
            saleStatistic_ds.Reset();
            SqlCommand cmd = new SqlCommand(QueryCmd, conn);
            SqlDataAdapter typeDataAdaper = new SqlDataAdapter(cmd);
            typeDataAdaper.Fill(saleStatistic_ds);
            dataGridView.AutoSize = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = saleStatistic_ds.Tables[0].DefaultView;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchQueryCmd = @"SELECT temp.carID, temp.carName,  count(Contract.contractID) as numberOfContractID ,sum(Contract.payment * temp.interest) as sumOfInterestPayment from(select Car.carID, Car.carName, Type.interest from Car inner join Type on Car.[carType] = Type.[carType]) as temp, Contract where  (Contract.CarID = temp.CarID) AND (dbo.Contract.dateRent = '" + dateTimePicker1.Value.Date.ToString("yyyy / MM / dd") + "' AND (dbo.Contract.dateReturn <= '" + dateTimePicker2.Value.Date.ToString("yyyy / MM / dd") + "') AND (Contract.payment != 0)) group by temp.carID, temp.carName;  ";
            FillDataToGirdView(SearchQueryCmd, saleStatistic_ds);
        }


        private void sale_Load(object sender, EventArgs e)
        {
            conn.Open();
            FillDataToGirdView(SearchQueryCmdFull, saleStatistic_ds);
        }

        private void sale_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
