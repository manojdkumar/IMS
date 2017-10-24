namespace IMS.UI.masters
{
    partial class frmCompany
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ddlCompType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ddlState = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPAN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGSTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.ddlCompType);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.ddlCity);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.ddlState);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtIFSC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAccountNumber);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtBankName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCIN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtContactPerson);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPAN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtZip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGSTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCompName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 492);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Type";
            // 
            // ddlCompType
            // 
            this.ddlCompType.FormattingEnabled = true;
            this.ddlCompType.Location = new System.Drawing.Point(128, 344);
            this.ddlCompType.Name = "ddlCompType";
            this.ddlCompType.Size = new System.Drawing.Size(401, 21);
            this.ddlCompType.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "City";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ddlCity
            // 
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(128, 171);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(401, 21);
            this.ddlCity.TabIndex = 24;
            this.ddlCity.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "State";
            // 
            // ddlState
            // 
            this.ddlState.FormattingEnabled = true;
            this.ddlState.Location = new System.Drawing.Point(128, 140);
            this.ddlState.Name = "ddlState";
            this.ddlState.Size = new System.Drawing.Size(401, 21);
            this.ddlState.TabIndex = 22;
            this.ddlState.SelectedIndexChanged += new System.EventHandler(this.ddlState_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 463);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "IFSC Code";
            // 
            // txtIFSC
            // 
            this.txtIFSC.Location = new System.Drawing.Point(128, 465);
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(401, 20);
            this.txtIFSC.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Account Number";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(128, 435);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(401, 20);
            this.txtAccountNumber.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bank Name";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(128, 405);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(401, 20);
            this.txtBankName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "CIN Number";
            // 
            // txtCIN
            // 
            this.txtCIN.Location = new System.Drawing.Point(128, 375);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(401, 20);
            this.txtCIN.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Contact Person";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(128, 314);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(401, 20);
            this.txtContactPerson.TabIndex = 12;
            this.txtContactPerson.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "PAN Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPAN
            // 
            this.txtPAN.Location = new System.Drawing.Point(128, 284);
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.Size = new System.Drawing.Size(401, 20);
            this.txtPAN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Zip";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(128, 254);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(401, 20);
            this.txtZip.TabIndex = 8;
            this.txtZip.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(128, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(401, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(128, 80);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(401, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GSTIN Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGSTN
            // 
            this.txtGSTN.Location = new System.Drawing.Point(128, 50);
            this.txtGSTN.Name = "txtGSTN";
            this.txtGSTN.Size = new System.Drawing.Size(401, 20);
            this.txtGSTN.TabIndex = 2;
            this.txtGSTN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(128, 20);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(401, 20);
            this.txtCompName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 36);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(128, 198);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(401, 50);
            this.txtAddress.TabIndex = 28;
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCompany";
            this.Text = "Company";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGSTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCIN;
        private System.Windows.Forms.ComboBox ddlState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ddlCompType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddress;
    }
}