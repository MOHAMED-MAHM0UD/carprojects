using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Threading.Timer;


namespace projecrDB.screens
{
    public partial class addOrderScreen : Form
    {

        newCarReintEntities db = new newCarReintEntities();
        string result;
        string full_name, phone,nationalID,model,startDate,endDate,totalPrice,rentPeriode , address = null;
       
        public addOrderScreen()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addOrderScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newCarReintDataSet1.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.newCarReintDataSet1.cars);
             SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("select c_model from cars where c_state = 1 ", con);
             SqlDataReader myreader;
             try
             {
                 con.Open();
                 myreader = cmd.ExecuteReader();
                 while (myreader.Read())
                 {
                     string sName = myreader.GetString(0);
                     comboBox1.Items.Add(sName);

                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
           



            //--------------------
            /*SqlConnection con2 = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("select c_id,c_model from cars where c_state = 1 ", con);
             SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            customer newCustomer = new customer();
            car newCa = new car();
            invoice newInvoice = new invoice();
            //-------------
            string[] fullName = textFullName.TextInput.Split(' ');
            string firstName = fullName[0];
            string lastName = fullName[1];
            //-----------
            newCustomer.cus_Fname = firstName;
            newCustomer.cus_Lname = lastName;
            newCustomer.cus_phone = textPhone.TextInput;
            newCustomer.cus_address = textAddress.TextInput;
            newCustomer.cus_licensesNum = text_license.TextInput;
            newCustomer.cus_nationalID = textNational_Id.TextInput;
            newCustomer.c_id_FK_ = int.Parse(result);
            newInvoice.in_sDate = DateTime.Now;
            newInvoice.in_EDate = end_date.Value;
            int days = CalculateRentPeriode(DateTime.Now, end_date.Value);
            newInvoice.rent_period = days;
           // textdays.TextInput = days.ToString();
            newInvoice.car_id_FK_ = int.Parse(result);
            newInvoice.cus_id_FK_ = newCustomer.cus_id;
            //-----to set that car => noavailable-----
            SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"update cars set c_state = 0 where c_id = {int.Parse(result)} ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            //--------------
           SqlCommand cmd_for_userID = new SqlCommand($"select user_id from users where u_userName = '{loginscreen.name}'",con);
            int user_id = (int)cmd_for_userID.ExecuteScalar();

            newInvoice.user_id_FK_ = user_id;
            
           //------------
            db.customers.Add(newCustomer);
            db.invoices.Add(newInvoice);
            db.SaveChanges();
            //  MessageBox.Show("Data Saved");
            DialogResult output = MessageBox.Show("Data Saved, Do you want to print invoice..?","", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (output == DialogResult.Yes)
            {
                full_name = String.Join(" ",fullName);
                phone = textPhone.TextInput;
                model = comboBox1.SelectedItem.ToString();
                startDate = DateTime.Now.ToString("d");
                endDate = end_date.Value.ToString("d");
                rentPeriode = textdays.Text;
                totalPrice = textPrice.TextInput;
                nationalID = textNational_Id.TextInput;
                address = textAddress.TextInput;

                print();
            }

            clear();




        }
        void clear()
        {
            textFullName.TextInput = null;
            textAddress.TextInput = null;
            textNational_Id.TextInput = null;
            textPhone.TextInput = null;
            text_license.TextInput = null;
            end_date.Text = null;
            textPrice.TextInput = null;
            textdays.Text = null;
            comboBox1.SelectedItem = null;
           
        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
          


        }
        public static int CalculateRentPeriode(DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate - startDate;

            int days = timeSpan.Days;

            return days;
        }



        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {     
            SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"select c_id from cars where c_model = '{comboBox1.SelectedItem}' ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            System.Text.StringBuilder id_car = new System.Text.StringBuilder();
            foreach (DataRow row in dt.Rows)
            {
                foreach (object item in row.ItemArray)
                {
                    id_car.Append($"{item}\t");
                }
                id_car.AppendLine();
            }
             result = id_car.ToString();
           
            try
            {
                textPrice.TextInput = calc_price(int.Parse(result)).ToString();

            }catch(Exception ex) 
            {
               
            }
           
           


        }
        private double calc_price(int index)
        {
            SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            SqlCommand cmd = new SqlCommand($"select c_dalyPrice from cars where c_id = '{index}' ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            System.Text.StringBuilder id_car = new System.Text.StringBuilder();
            foreach (DataRow row in dt.Rows) // loop on rows
            {
                foreach (object item in row.ItemArray)
                {
                    id_car.Append($"{item}\t");
                }
                id_car.AppendLine();
            }
   

            
            
            double price = double.Parse(id_car.ToString());
            int rentDays = CalculateRentPeriode(DateTime.Now,end_date.Value);

            return price * rentDays;
        }

  
        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void end_date_ValueChanged(object sender, EventArgs e)
        {
            int days = CalculateRentPeriode(DateTime.Now, end_date.Value);
            textdays.Text = days.ToString();   
               
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 50;
            int y = 150;
            Font myFont = new Font("Century Gothic", 18, FontStyle.Bold);
            Pen pen = new Pen(Color.Gray, 5);
            e.Graphics.DrawString("Car Rent", myFont, Brushes.Black, 350, 80);
            e.Graphics.DrawString("Name : " + full_name, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("Phone : " + phone, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("National ID : " + nationalID, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("Address : " + address, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("Start Date : " + startDate, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("End Date : " + endDate, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("Car Model : " + model, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("Rent Periode : " + rentPeriode, myFont, Brushes.Black, x, y);
            y += 70;
            e.Graphics.DrawString("Total Price : " + totalPrice, myFont, Brushes.Black, 200, y);
            e.Graphics.DrawString("Signature", myFont, Brushes.Black, 600, y);
            e.Graphics.DrawLine(pen, new Point(590, y+70), new Point(730, y+70));



        }
        void print()
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
