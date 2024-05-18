using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecrDB.screens
{
    public partial class carsView : Form
    {
        public carsView()
        {
            InitializeComponent();

        }

        private void carsView_Load(object sender, EventArgs e)
        {
            //dataGridView1.EnableHeadersVisualStyles = false;
            SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            SqlCommand cmd_select = new SqlCommand($"select c_model as \" Model\" , c_color as \"Color\",c_state as 'State',c_dalyPrice as \"price\" from cars", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd_select);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
