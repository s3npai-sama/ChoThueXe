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
    public partial class carStatistics : Form
    {
        public carStatistics()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Quanlyxedulichh;Integrated Security=True");
        string SearchQueryCmdFull = @"SELECT Car.[carID],Car.[carName],Car.[brand],Car.[carType],Car.[seatNumber],Car.[licencePlate],Car.[rentPricePerDay],Type.[pricePerDayExceed],Type.[interest],Car.[Status] FROM dbo.[Car], dbo.[Type] where Car.[carType] = Type.[carType] ;";
        string SearchQueryCmd;
        DataSet carStatistic_ds = new DataSet();
        private void carStatisticcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyxedulichhDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.quanlyxedulichhDataSet.Type);
            FillDataToGirdView1(SearchQueryCmdFull,carStatistic_ds);
            conn.Open();
        }

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

        private void carStatisticcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbxStatistic_SelectedIndexChanged( sender, e);
        }

        private void cbxStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStatistic.Text == "Các xe đang được thuê")
            {
                SearchQueryCmd = @"Select dbo.Car.carID, dbo.Car.carName, dbo.Car.brand, dbo.Car.carType, dbo.Car.seatNumber, dbo.Car.licencePlate, dbo.Car.rentPricePerDay, dbo.Type.pricePerDayExceed, dbo.Type.interest, dbo.Contract.dateRent, dbo.Contract.dateReturnExpected,dbo.Contract.dateReturn
                                   from dbo.Car, dbo.Type , dbo.Contract 
                                   where(dbo.Car.carType = dbo.Type.carType and dbo.Car.carID = dbo.Contract.carID and dbo.Contract.dateReturn is NULL);";
                FillDataToGirdView1(SearchQueryCmd, carStatistic_ds);
            }
            else if (cbxStatistic.Text == "Tất cả xe")
            {
                SearchQueryCmd = "SELECT * From dbo.Car";
                FillDataToGirdView1(SearchQueryCmd, carStatistic_ds);
            }
        }
    }
}
