using IMS.DL;
using IMS.DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL
{
    public class CompanyBL
    {
        protected CompanyDL companyDL = new CompanyDL() ;
        public List<CompanyVM> GetCompanyList()
        {
            List<CompanyVM> companiesVM = new List<CompanyVM>();
            List<Company> companies = companyDL.GetCompanyList();
            foreach (Company company in companies)
            {
                CompanyVM companyVM = new CompanyVM();
                companyVM.AccountNumber = company.AccountNumber;
                companyVM.Address = company.Address;
                companyVM.BankName = company.BankName;
                companyVM.CINNum = company.CINNum;
                companyVM.City = company.City != null ? company.City.Name : String.Empty;
                companyVM.ContactPerson = company.ContactPerson;
                companyVM.Email = company.Email;
                companyVM.GSTINNUM = company.GSTINNUM;
                companyVM.ID = company.ID;
                companyVM.IFSCCode = company.IFSCCode;
                companyVM.IsActive = company.IsActive;
                companyVM.Name = company.Name;
                companyVM.PANNumber = company.PANNumber;
                companyVM.Phone = company.Phone;
                companyVM.State = company.State != null ? company.State.Name : string.Empty;
                companyVM.Type = company.Type != null ? company.Type.Type : string.Empty;
                companyVM.Zip = company.Zip;
                companiesVM.Add(companyVM);
            }

            return companiesVM;
        }

        public List<State> GetStates()
        {
            return companyDL.GetStates();  
        }

        public List<City> GetCities(int StateId)
        {
            return companyDL.GetCities(StateId);  
        }

        public List<CompanyType> GetCompanyTypes()
        {
            return companyDL.GetCompanyTypes();  
        }

        public int AddCompany(Company comp)
        {
            return companyDL.AddCompany(comp);
        }
    }
}
