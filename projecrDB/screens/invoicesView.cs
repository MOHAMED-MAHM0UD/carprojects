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

namespace projecrDB.screens
{
    public partial class invoicesView : Form
    {
        public invoicesView()
        {
            InitializeComponent();
        }

        private void invoicesView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");

            con.Open();

            string query = $"select in_id as 'Invoice ID',cus_Fname as 'First Name', cus_Lname 'Last Name',cus_nationalID 'National ID', cus_phone'Phone',cus_address 'Addrees' ,c_model as 'Model'," +
        $"c_dalyPrice 'Price',in_sDate as'Start Date',in_EDate as'End Date',rent_period as'Period' from invoices " +
        $"join cars on c_id = [car_id(FK)] " +
        $"join customers on cus_id = [cus_id(FK)] ";

            SqlCommand cmd_select = new SqlCommand(query, con);
            SqlDataAdapter newadapter = new SqlDataAdapter(cmd_select);
            DataTable dt = new DataTable();
            newadapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
