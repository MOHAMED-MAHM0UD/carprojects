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
    public partial class adminform : Form
    {
        newCarReintEntities db = new newCarReintEntities();
        public adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            screens.addCarScreen addCarScreen = new screens.addCarScreen();
            addCarScreen.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            screens.addOrderScreen addOrderScreen = new screens.addOrderScreen();
            addOrderScreen.Show();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            /* invoice newInvoice = new invoice();
              SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
              SqlCommand cmd = new SqlCommand($"select invoices.[car_id(FK)] ,[cus_id(FK)] from invoices where in_EDate = '2024-05-17' ", con);
              SqlDataAdapter adapter = new SqlDataAdapter(cmd);
              DataTable dt = new DataTable();
              adapter.Fill(dt);
              dataGridView1.DataSource = dt;
              int car_id_FK = Convert.ToInt32(dataGridView1.Rows[0].Cells["car_id(FK)"].Value);
              int cus_id_FK = Convert.ToInt32(dataGridView1.Rows[0].Cells["cus_id(FK)"].Value);
              //--------------------------*/
            SqlConnection con_update = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            SqlCommand cmd_update = new SqlCommand($"update cars set c_state = 1 from cars join invoices on c_id = [car_id(FK)] where in_EDate = '{DateTime.Now}' ", con_update);
            con_update.Open();
            cmd_update.ExecuteNonQuery();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            screens.carsView carsView = new screens.carsView();
            carsView.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_invoices_Click(object sender, EventArgs e)
        {
            screens.invoicesView newInvoices = new screens.invoicesView();
            newInvoices.Show();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            screens.Search newSearch = new screens.Search();
            newSearch.Show();
        }

        private void usersbtn_Click(object sender, EventArgs e)
        {
            screens.Users users = new screens.Users();
            users.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            screens.addCarScreen addCarScreen = new screens.addCarScreen();
            addCarScreen.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            screens.addOrderScreen addOrderScreen = new screens.addOrderScreen();
            addOrderScreen.Show();
        }

        private void butSearch_Click_1(object sender, EventArgs e)
        {
            screens.Search newSearch = new screens.Search();
            newSearch.Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_invoices_Click_1(object sender, EventArgs e)
        {
            screens.invoicesView newInvoices = new screens.invoicesView();
            newInvoices.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            screens.carsView carsView = new screens.carsView();
            carsView.Show();
        }
    }
}
