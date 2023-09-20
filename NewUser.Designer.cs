namespace Task3_LoginPage
{
    partial class NewUser
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
            this.employeeDataSet = new Task3_LoginPage.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet2 = new Task3_LoginPage.EmployeeDataSet2();
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONTableAdapter = new Task3_LoginPage.EmployeeDataSet2TableAdapters.PERSONTableAdapter();
            this.employeeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fname = new System.Windows.Forms.TextBox();
            this.Fi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.employeeDataSet1 = new Task3_LoginPage.EmployeeDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataSetBindingSource
            // 
            this.employeeDataSetBindingSource.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource.Position = 0;
            // 
            // employeeDataSet2
            // 
            this.employeeDataSet2.DataSetName = "EmployeeDataSet2";
            this.employeeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataMember = "PERSON";
            this.pERSONBindingSource.DataSource = this.employeeDataSet2;
            // 
            // pERSONTableAdapter
            // 
            this.pERSONTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDataSetBindingSource1
            // 
            this.employeeDataSetBindingSource1.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource1.Position = 0;
            // 
            // fname
            // 
            this.fname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(211, 116);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(160, 27);
            this.fname.TabIndex = 1;
            this.fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Fi
            // 
            this.Fi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fi.AutoSize = true;
            this.Fi.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fi.Location = new System.Drawing.Point(38, 113);
            this.Fi.Name = "Fi";
            this.Fi.Size = new System.Drawing.Size(127, 28);
            this.Fi.TabIndex = 2;
            this.Fi.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lname
            // 
            this.lname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(211, 192);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(160, 27);
            this.lname.TabIndex = 5;
            // 
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "EmployeeDataSet";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email Id :";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(211, 269);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(160, 27);
            this.email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password :";
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(211, 350);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(160, 27);
            this.password.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone No :";
            // 
            // phone
            // 
            this.phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(211, 431);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(160, 27);
            this.phone.TabIndex = 11;
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.gender.Location = new System.Drawing.Point(698, 113);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 28);
            this.gender.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Country :";
            // 
            // country
            // 
            this.country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(698, 353);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(160, 27);
            this.country.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "State :";
            // 
            // state
            // 
            this.state.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(698, 272);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(160, 27);
            this.state.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "City :";
            // 
            // city
            // 
            this.city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(698, 191);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(160, 27);
            this.city.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 431);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Age :";
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.FormattingEnabled = true;
            this.age.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.age.Location = new System.Drawing.Point(698, 431);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(121, 28);
            this.age.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(698, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(250, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(387, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 48);
            this.label10.TabIndex = 25;
            this.label10.Text = "Sign up";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 584);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.state);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.Fi);
            this.Controls.Add(this.fname);
            this.Name = "NewUser";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private EmployeeDataSet employeeDataSet;
        private EmployeeDataSet2 employeeDataSet2;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private EmployeeDataSet2TableAdapters.PERSONTableAdapter pERSONTableAdapter;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label Fi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lname;
        private EmployeeDataSet employeeDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox age;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}