namespace _7.Address_Book_Maintenance_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.formsDbDataSet = new _7.Address_Book_Maintenance_System.FormsDbDataSet();
            this.citizendetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citizendetailsTableAdapter = new _7.Address_Book_Maintenance_System.FormsDbDataSetTableAdapters.citizendetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.phonedbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maildbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countrydbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statedbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citydbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pindbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formsDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizendetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 187);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Aadhar Card Number";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 53);
            this.button4.TabIndex = 15;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(530, 87);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 20);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "Mail Id";
            this.textBox8.Click += new System.EventHandler(this.textBox8_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(530, 51);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Phone Number ";
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(530, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 20);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Pin Number";
            this.textBox6.Click += new System.EventHandler(this.textBox6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(424, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "City";
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(337, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "State";
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Country";
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(250, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 50);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Street Address";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // formsDbDataSet
            // 
            this.formsDbDataSet.DataSetName = "FormsDbDataSet";
            this.formsDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // citizendetailsBindingSource
            // 
            this.citizendetailsBindingSource.DataMember = "citizendetails";
            this.citizendetailsBindingSource.DataSource = this.formsDbDataSet;
            // 
            // citizendetailsTableAdapter
            // 
            this.citizendetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phonedbDataGridViewTextBoxColumn,
            this.maildbDataGridViewTextBoxColumn,
            this.countrydbDataGridViewTextBoxColumn,
            this.statedbDataGridViewTextBoxColumn,
            this.citydbDataGridViewTextBoxColumn,
            this.pindbDataGridViewTextBoxColumn,
            this.addressdbDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.citizendetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // phonedbDataGridViewTextBoxColumn
            // 
            this.phonedbDataGridViewTextBoxColumn.DataPropertyName = "phonedb";
            this.phonedbDataGridViewTextBoxColumn.HeaderText = "phonedb";
            this.phonedbDataGridViewTextBoxColumn.Name = "phonedbDataGridViewTextBoxColumn";
            // 
            // maildbDataGridViewTextBoxColumn
            // 
            this.maildbDataGridViewTextBoxColumn.DataPropertyName = "maildb";
            this.maildbDataGridViewTextBoxColumn.HeaderText = "maildb";
            this.maildbDataGridViewTextBoxColumn.Name = "maildbDataGridViewTextBoxColumn";
            // 
            // countrydbDataGridViewTextBoxColumn
            // 
            this.countrydbDataGridViewTextBoxColumn.DataPropertyName = "countrydb";
            this.countrydbDataGridViewTextBoxColumn.HeaderText = "countrydb";
            this.countrydbDataGridViewTextBoxColumn.Name = "countrydbDataGridViewTextBoxColumn";
            // 
            // statedbDataGridViewTextBoxColumn
            // 
            this.statedbDataGridViewTextBoxColumn.DataPropertyName = "statedb";
            this.statedbDataGridViewTextBoxColumn.HeaderText = "statedb";
            this.statedbDataGridViewTextBoxColumn.Name = "statedbDataGridViewTextBoxColumn";
            // 
            // citydbDataGridViewTextBoxColumn
            // 
            this.citydbDataGridViewTextBoxColumn.DataPropertyName = "citydb";
            this.citydbDataGridViewTextBoxColumn.HeaderText = "citydb";
            this.citydbDataGridViewTextBoxColumn.Name = "citydbDataGridViewTextBoxColumn";
            // 
            // pindbDataGridViewTextBoxColumn
            // 
            this.pindbDataGridViewTextBoxColumn.DataPropertyName = "pindb";
            this.pindbDataGridViewTextBoxColumn.HeaderText = "pindb";
            this.pindbDataGridViewTextBoxColumn.Name = "pindbDataGridViewTextBoxColumn";
            // 
            // addressdbDataGridViewTextBoxColumn
            // 
            this.addressdbDataGridViewTextBoxColumn.DataPropertyName = "addressdb";
            this.addressdbDataGridViewTextBoxColumn.HeaderText = "addressdb";
            this.addressdbDataGridViewTextBoxColumn.Name = "addressdbDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Operation Message";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(650, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "check";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(530, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Update Please";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(424, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Confirm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(250, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Address Book Maintenance System";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formsDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citizendetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private FormsDbDataSet formsDbDataSet;
        private System.Windows.Forms.BindingSource citizendetailsBindingSource;
        private FormsDbDataSetTableAdapters.citizendetailsTableAdapter citizendetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonedbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maildbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countrydbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statedbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citydbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pindbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressdbDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}