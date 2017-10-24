using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using IMS.BL;
using IMS.DM;

namespace IMS.UI.masters
{
    public partial class frmCompanyList : Form
    {
        protected CompanyBL companyBL = new CompanyBL(); 
        public frmCompanyList()
        {
            InitializeComponent();
            BindDataGrid();
        }

        private void BindDataGrid()
        {
                                            
            List<CompanyVM> companies = companyBL.GetCompanyList(); 
            // Populate Data Grid
            this.dataGridView1.DataSource = companies;//ds.Tables["tblCompany"].DefaultView;
                  

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmComp = new frmCompany();
            frmComp.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
