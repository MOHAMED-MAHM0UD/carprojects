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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
                
                    con.Open();

                    string query = $"select cus_Fname as 'First Name', cus_Lname 'Last Name',cus_nationalID 'National ID', cus_phone'Phone',cus_address 'Addrees' ,c_model as 'Model'," +
                $"c_dalyPrice 'Price',in_sDate as'Start Date',in_EDate as'End Date',rent_period as'Period' from invoices " +
                $"join cars on c_id = [car_id(FK)] " +
                $"join customers on cus_id = [cus_id(FK)] " +
                $"where cus_phone = '{textSearch.TextInput}'  " +
                $"or cus_nationalID = '{textNational.TextInput}'";

                        SqlCommand cmd_select = new SqlCommand(query, con);
                        SqlDataAdapter newadapter = new SqlDataAdapter(cmd_select);
                        DataTable dt = new DataTable();
                        newadapter.Fill(dt);
                        dataGridView1.DataSource = dt;
   
                  
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            
        }
    }
}
