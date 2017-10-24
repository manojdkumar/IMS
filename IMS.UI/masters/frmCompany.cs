using IMS.BL;
using IMS.DM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UI.masters
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
            CompanyBL companyBL = new CompanyBL();
            List<State> states = companyBL.GetStates();
            List<CompanyType> compTypes = companyBL.GetCompanyTypes();
            
            ddlState.ValueMember = "ID";
            ddlState.DisplayMember = "Name";
            ddlState.DataSource = states;

            
            ddlCompType.ValueMember = "ID";
            ddlCompType.DisplayMember = "Type";
            ddlCompType.DataSource = compTypes;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

      

        private void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlState.SelectedValue.ToString() != null)
            {
                int stateId =Convert.ToInt32(ddlState.SelectedValue);
                CompanyBL companyBL = new CompanyBL();
                List<City> cities = companyBL.GetCities(stateId);
                
                ddlCity.ValueMember = "ID";
                ddlCity.DisplayMember = "Name";
                ddlCity.DataSource = cities;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CompanyBL companyBL = new CompanyBL();
            Company comp = new Company { AccountNumber = txtAccountNumber.Text, Address = txtAddress.Text, BankName = txtBankName.Text, IFSCCode = txtIFSC.Text, CINNum = txtCIN.Text, ContactPerson = txtContactPerson.Text, PANNumber = txtPAN.Text, Zip = txtZip.Text, State = new State { ID =Convert.ToInt32(ddlState.SelectedValue), Name = ddlState.SelectedText, IsActive = true }, City = new City { ID = Convert.ToInt32(ddlCity.SelectedValue), Name = ddlCity.SelectedText, IsActive = true }, Email = txtEmail.Text, GSTINNUM = txtGSTN.Text, IsActive = true, Name = txtCompName.Text, Phone = txtPhone.Text, Type = new CompanyType { ID = Convert.ToInt32(ddlCompType.SelectedValue), Type = ddlCompType.SelectedText, IsActive = true} };
            int i = companyBL.AddCompany(comp);
            this.Close();
        }
    }
}
