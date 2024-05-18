using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecrDB.screens
{
    public partial class loginscreen : Form
    {
       // which access modifier can be shared on all app in c#
       

        public loginscreen()
        {
            InitializeComponent();
            jText_Box2.PasswordChar = '\u25CF';
        }
        public static string name = null;
        private void button2_Click(object sender, EventArgs e)
        {
            int? userId = null;
            //bool userExists = false;
            //object result = null;


            SqlConnection con = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=newCarReint;Integrated Security=True");
            string query = $@"
                                SELECT user_id, u_userName 
                                 FROM users 
                                 WHERE u_userName = '{jText_Box1.TextInput}' AND u_password = '{jText_Box2.TextInput}'
                                ;";

            using (con)
            {
                SqlCommand command = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    // queryResult = (int)command.ExecuteScalar();



                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // result = command.ExecuteScalar();

                        if (reader.Read())
                        {

                            userId = reader.GetInt32(0);
                            // Get the user_id from the first column
                            // MessageBox.Show($"The user ID is: {userId.Value}", "User ID", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }




                }
                catch (Exception ex)
                {
                    // Handle any exceptions here
                    Console.WriteLine(ex.Message);
                }

                //--------------------------------------------------

                if (userId != null)
                {
                    name = jText_Box1.TextInput;
                    if (userId.Value == 4) // check if the user id equal  admin id (admin id in database is 4 ) 
                    {

                        this.Close();
                        Thread th1 = new Thread(openadminfrom);//run new form as new task
                        th1.SetApartmentState(ApartmentState.STA);
                        th1.Start();
                    }
                    else // the normal user 
                    {

                        this.Close();
                        Thread th = new Thread(openform);//run new form as new task
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }

                }
                else
                {
                    MessageBox.Show(" invalid usename or password ! ");
                }


            }





        }
        void openform()
        {
            Application.Run(new Form1());
        }
        void openadminfrom()
        {
            Application.Run(new adminform());
        }
        private void jText_Box2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void loginscreen_Load(object sender, EventArgs e)
        {

        }

        private void loginscreen_Shown(object sender, EventArgs e)
        {
            jText_Box1.Focus(); 
        }
    }
}
