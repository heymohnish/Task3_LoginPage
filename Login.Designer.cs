namespace Task3_LoginPage
{
    partial class Login
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeDataSet = new Task3_LoginPage.EmployeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet1 = new Task3_LoginPage.EmployeeDataSet1();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new Task3_LoginPage.EmployeeDataSet1TableAdapters.EMPLOYEETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbutton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.Black;
            this.loginbutton.Location = new System.Drawing.Point(513, 387);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(174, 43);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(353, 125);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 43);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(353, 208);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(334, 43);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(67, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email Id :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
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
            // employeeDataSet1
            // 
            this.employeeDataSet1.DataSetName = "EmployeeDataSet1";
            this.employeeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.employeeDataSet1;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Log in ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(599, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 19);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "New User?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 665);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginbutton);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private EmployeeDataSet1 employeeDataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private EmployeeDataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

