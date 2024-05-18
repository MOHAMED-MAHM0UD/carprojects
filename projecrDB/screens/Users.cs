using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecrDB.screens
{
    public partial class Users : Form
    {
        int id;
        newCarReintEntities db = new newCarReintEntities();


        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newCarReintDataSet3.users' table. You can move, or remove it, as needed.
            // this.usersTableAdapter1.Fill(this.newCarReintDataSet3.users);
            // TODO: This line of code loads data into the 'newCarReintDataSet2.users' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = db.users.ToList();
            // Assuming dataGridView1 is your DataGridView instance

            // Find the index of the column you want to delete (replace "columnName" with your actual column name)
            int columnIndex = dataGridView1.Columns["invoices"].Index;

            // Remove the column from the DataGridView
            dataGridView1.Columns.RemoveAt(columnIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usrtxtbox.TextInput = null;
            passtxtbox.TextInput = null;
            button2.Visible = false;
            addbtn1();




        }
      

        private void savenewuserbtn_Click(object sender, EventArgs e)
        {

            try
            {
                var r = MessageBox.Show($" Are you sure you want to add {Usrtxtbox.TextInput} as new user  ", "Add new user", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    user user = new user();
                    user.u_userName = Usrtxtbox.TextInput;
                    user.u_password = passtxtbox.TextInput;
                    db.users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show($"User : {Usrtxtbox.TextInput} added successfully  ");
                    dataGridView1.DataSource = db.users.ToList();
                    button2.Visible = true;


                }

            }
            catch
            {


            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var Result = db.users.SingleOrDefault(x => x.user_id == id);
                Usrtxtbox.TextInput = Result.u_userName;
                passtxtbox.TextInput = Result.u_password;

            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var reslt = MessageBox.Show("Are you sure you want to save changes ?", "Save Changes", MessageBoxButtons.YesNo);
                if (reslt == DialogResult.Yes)
                {
                    var user1 = db.users.Find(id);
                    user1.u_userName = Usrtxtbox.TextInput;
                    user1.u_password = passtxtbox.TextInput;

                    db.SaveChanges();
                    MessageBox.Show("done");
                    dataGridView1.DataSource = db.users.ToList();




                }

            }
            catch { }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var l = MessageBox.Show($"Are you sure you want to delet User :  {Usrtxtbox.TextInput} ?", "Delet User ", MessageBoxButtons.YesNo);
            if (l == DialogResult.Yes)
            {
                var userdel = db.users.Find(id);
                db.users.Remove(userdel);
                db.SaveChanges();
                MessageBox.Show($"User :  {Usrtxtbox.TextInput} has been deleted ");
                Usrtxtbox.TextInput = null;
                passtxtbox.TextInput = null;
                dataGridView1.DataSource = db.users.ToList();


            }
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {

            Usrtxtbox.TextInput = null;
            passtxtbox.TextInput = null;
            button1.Visible = false;
            addbtn1();

        }
        public void addbtn1()
        {
            Button savenewuserbtn = new Button();
            savenewuserbtn.Text = "Add ";
            savenewuserbtn.Location = new Point(30, 409);
            savenewuserbtn.Size = new Size(155, 45);
            savenewuserbtn.BackColor = Color.Green;
            savenewuserbtn.ForeColor = Color.White;
            savenewuserbtn.Visible = true;
            this.Controls.Add(savenewuserbtn);
            savenewuserbtn.Click += new EventHandler(savenewuserbtn_Click1);


            // 

        }
        private void savenewuserbtn_Click1(object sender, EventArgs e)
        {

            try
            {
                var r = MessageBox.Show($" Are you sure you want to add {Usrtxtbox.TextInput} as new user  ", "Add new user", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    user user = new user();
                    user.u_userName = Usrtxtbox.TextInput;
                    user.u_password = passtxtbox.TextInput;
                    db.users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show($"User : {Usrtxtbox.TextInput} added successfully  ");
                    dataGridView1.DataSource = db.users.ToList();             
                    dataGridView1.DataSource = db.users.ToList();                 
                    // Find the index of the column you want to delete (replace "columnName" with your actual column name)
                    int columnIndex = dataGridView1.Columns["invoices"].Index;

                    // Remove the column from the DataGridView
                    dataGridView1.Columns.RemoveAt(columnIndex);
                    button1.Visible = true;


                }

            }
            catch
            {


            }
        }


        private void button2_Click_2(object sender, EventArgs e)
        {
            try
            {
                var reslt = MessageBox.Show("Are you sure you want to save changes ?", "Save Changes", MessageBoxButtons.YesNo);
                if (reslt == DialogResult.Yes)
                {
                    var user1 = db.users.Find(id);

                    user1.u_userName = Usrtxtbox.TextInput;
                    user1.u_password = passtxtbox.TextInput;

                    db.SaveChanges();
                    MessageBox.Show("done");
                    dataGridView1.DataSource = db.users.ToList();
                 
                    dataGridView1.DataSource = db.users.ToList();
                   

                    // Find the index of the column you want to delete (replace "columnName" with your actual column name)
                    int columnIndex = dataGridView1.Columns["invoices"].Index;

                    // Remove the column from the DataGridView
                    dataGridView1.Columns.RemoveAt(columnIndex);




                }

            }
            catch { }
        }

     

        private void button3_Click(object sender, EventArgs e)
        {
            var l = MessageBox.Show($"Are you sure you want to delet User :  {Usrtxtbox.TextInput} ?", "Delet User ", MessageBoxButtons.YesNo);
            if (l == DialogResult.Yes)
            {
                var userdel = db.users.Find(id);
                db.users.Remove(userdel);
                db.SaveChanges();
                MessageBox.Show($"User :  {Usrtxtbox.TextInput} has been deleted ");
                Usrtxtbox.TextInput = null;
                passtxtbox.TextInput = null;
                dataGridView1.DataSource = db.users.ToList();
           
                dataGridView1.DataSource = db.users.ToList();
                // Assuming dataGridView1 is your DataGridView instance

                // Find the index of the column you want to delete (replace "columnName" with your actual column name)
                int columnIndex = dataGridView1.Columns["invoices"].Index;

                // Remove the column from the DataGridView
                dataGridView1.Columns.RemoveAt(columnIndex);


            }

        }

        private void checkBoxshowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxshowPassword.Checked)
            {
                // If the checkbox is checked, show the password as clear text.
                passtxtbox.PasswordChar = '\0';
            }
            else
            {
                // If the checkbox is not checked, hide the password with '*'.
                passtxtbox.PasswordChar = '\u25CF';
            }
        }

        private void dataGridView1_SelectionChanged_2(object sender, EventArgs e)
        {

            try
            {

                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var Result = db.users.SingleOrDefault(x => x.user_id == id);
                Usrtxtbox.TextInput = Result.u_userName;
                passtxtbox.TextInput = Result.u_password;

            }
            catch { }
        }
    }
}