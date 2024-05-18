using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projecrDB.screens //hellow world 

{
    public partial class addCarScreen : Form
    {
        newCarReintEntities db = new newCarReintEntities();
        public addCarScreen()
        {
            InitializeComponent();
        }

        private void addCarScreen_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            car myCar = new car();
            myCar.c_color = textColor.TextInput;
            myCar.c_model = textmodel.TextInput;
            myCar.c_state = true;
            myCar.c_dalyPrice = Decimal.Parse(textPrice.TextInput);
            db.cars.Add(myCar);
            db.SaveChanges();
            MessageBox.Show("data saved");
            clear();


        }
        void clear()
        {
            textColor.TextInput = null;
            textmodel.TextInput = null;
            textPrice.TextInput = null;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textColor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
