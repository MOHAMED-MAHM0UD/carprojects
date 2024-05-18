namespace projecrDB.screens
{
    partial class addOrderScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrderScreen));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.newCarReintDataSet = new projecrDB.newCarReintDataSet();
            this.newCarReintDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newCarReintDataSet1 = new projecrDB.newCarReintDataSet1();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new projecrDB.newCarReintDataSet1TableAdapters.carsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textdays = new System.Windows.Forms.TextBox();
            this.textPrice = new JTextBox.JText_Box();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_license = new JTextBox.JText_Box();
            this.label5 = new System.Windows.Forms.Label();
            this.textNational_Id = new JTextBox.JText_Box();
            this.textAddress = new JTextBox.JText_Box();
            this.label4 = new System.Windows.Forms.Label();
            this.textPhone = new JTextBox.JText_Box();
            this.textFullName = new JTextBox.JText_Box();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCarReintDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCarReintDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCarReintDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-43, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 119);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "CarRent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(585, 402);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 39);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // newCarReintDataSet
            // 
            this.newCarReintDataSet.DataSetName = "newCarReintDataSet";
            this.newCarReintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newCarReintDataSetBindingSource
            // 
            this.newCarReintDataSetBindingSource.DataSource = this.newCarReintDataSet;
            this.newCarReintDataSetBindingSource.Position = 0;
            // 
            // newCarReintDataSet1
            // 
            this.newCarReintDataSet1.DataSetName = "newCarReintDataSet1";
            this.newCarReintDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.newCarReintDataSet1;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(339, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 34);
            this.label9.TabIndex = 17;
            this.label9.Text = "End Date :";
            // 
            // end_date
            // 
            this.end_date.CustomFormat = "mm/dd/yy";
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date.Location = new System.Drawing.Point(585, 310);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(317, 38);
            this.end_date.TabIndex = 18;
            this.end_date.ValueChanged += new System.EventHandler(this.end_date_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Full Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(589, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "license :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(578, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 34);
            this.label10.TabIndex = 23;
            this.label10.Text = "National Id :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textdays);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.text_license);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.end_date);
            this.groupBox1.Controls.Add(this.textNational_Id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textAddress);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.textFullName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(118, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 649);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Order";
            // 
            // textdays
            // 
            this.textdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textdays.Location = new System.Drawing.Point(248, 404);
            this.textdays.Name = "textdays";
            this.textdays.ReadOnly = true;
            this.textdays.Size = new System.Drawing.Size(84, 38);
            this.textdays.TabIndex = 32;
            // 
            // textPrice
            // 
            this.textPrice.BorderColor = System.Drawing.Color.Gray;
            this.textPrice.BorderThickness = 3;
            this.textPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPrice.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPrice.Location = new System.Drawing.Point(431, 483);
            this.textPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textPrice.MaxLength = 32767;
            this.textPrice.Name = "textPrice";
            this.textPrice.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.textPrice.PasswordChar = '\0';
            this.textPrice.RoundedBorder = 2;
            this.textPrice.Size = new System.Drawing.Size(286, 44);
            this.textPrice.TabIndex = 31;
            this.textPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPrice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPrice.TextInput = "";
            this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 37);
            this.label7.TabIndex = 30;
            this.label7.Text = "Total Price :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 34);
            this.label11.TabIndex = 29;
            this.label11.Text = "Rent Period :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_license
            // 
            this.text_license.BorderColor = System.Drawing.Color.Gray;
            this.text_license.BorderThickness = 3;
            this.text_license.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_license.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_license.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_license.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_license.Location = new System.Drawing.Point(585, 203);
            this.text_license.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.text_license.MaxLength = 32767;
            this.text_license.Name = "text_license";
            this.text_license.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.text_license.PasswordChar = '\0';
            this.text_license.RoundedBorder = 2;
            this.text_license.Size = new System.Drawing.Size(318, 44);
            this.text_license.TabIndex = 27;
            this.text_license.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_license.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_license.TextInput = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 34);
            this.label5.TabIndex = 25;
            this.label5.Text = "Car Model :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNational_Id
            // 
            this.textNational_Id.BorderColor = System.Drawing.Color.Gray;
            this.textNational_Id.BorderThickness = 3;
            this.textNational_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNational_Id.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNational_Id.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNational_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNational_Id.Location = new System.Drawing.Point(585, 106);
            this.textNational_Id.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textNational_Id.MaxLength = 32767;
            this.textNational_Id.Name = "textNational_Id";
            this.textNational_Id.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.textNational_Id.PasswordChar = '\0';
            this.textNational_Id.RoundedBorder = 2;
            this.textNational_Id.Size = new System.Drawing.Size(318, 44);
            this.textNational_Id.TabIndex = 26;
            this.textNational_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textNational_Id.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNational_Id.TextInput = "";
            // 
            // textAddress
            // 
            this.textAddress.BorderColor = System.Drawing.Color.Gray;
            this.textAddress.BorderThickness = 3;
            this.textAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAddress.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textAddress.Location = new System.Drawing.Point(38, 310);
            this.textAddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textAddress.MaxLength = 32767;
            this.textAddress.Name = "textAddress";
            this.textAddress.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.textAddress.PasswordChar = '\0';
            this.textAddress.RoundedBorder = 2;
            this.textAddress.Size = new System.Drawing.Size(318, 44);
            this.textAddress.TabIndex = 24;
            this.textAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textAddress.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textAddress.TextInput = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 34);
            this.label4.TabIndex = 23;
            this.label4.Text = "Addrees :";
            // 
            // textPhone
            // 
            this.textPhone.BorderColor = System.Drawing.Color.Gray;
            this.textPhone.BorderThickness = 3;
            this.textPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhone.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPhone.Location = new System.Drawing.Point(38, 203);
            this.textPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textPhone.MaxLength = 32767;
            this.textPhone.Name = "textPhone";
            this.textPhone.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.textPhone.PasswordChar = '\0';
            this.textPhone.RoundedBorder = 2;
            this.textPhone.Size = new System.Drawing.Size(318, 44);
            this.textPhone.TabIndex = 22;
            this.textPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textPhone.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPhone.TextInput = "";
            // 
            // textFullName
            // 
            this.textFullName.BorderColor = System.Drawing.Color.Gray;
            this.textFullName.BorderThickness = 3;
            this.textFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textFullName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFullName.FontStyles = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textFullName.Location = new System.Drawing.Point(38, 104);
            this.textFullName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textFullName.MaxLength = 32767;
            this.textFullName.Name = "textFullName";
            this.textFullName.onFocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(28)))), ((int)(((byte)(106)))));
            this.textFullName.PasswordChar = '\0';
            this.textFullName.RoundedBorder = 2;
            this.textFullName.Size = new System.Drawing.Size(318, 44);
            this.textFullName.TabIndex = 21;
            this.textFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textFullName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textFullName.TextInput = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-11, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 729);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(1159, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 729);
            this.panel3.TabIndex = 34;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // addOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 793);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1075, 840);
            this.Name = "addOrderScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add order";
            this.Load += new System.EventHandler(this.addOrderScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCarReintDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCarReintDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newCarReintDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource newCarReintDataSetBindingSource;
        private newCarReintDataSet newCarReintDataSet;
        private newCarReintDataSet1 newCarReintDataSet1;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private newCarReintDataSet1TableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private JTextBox.JText_Box textAddress;
        private System.Windows.Forms.Label label4;
        private JTextBox.JText_Box textPhone;
        private JTextBox.JText_Box textFullName;
        private JTextBox.JText_Box text_license;
        private JTextBox.JText_Box textNational_Id;
        private System.Windows.Forms.Label label11;
        private JTextBox.JText_Box textPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textdays;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}