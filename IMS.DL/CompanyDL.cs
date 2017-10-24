using IMS.DM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IMS.DL
{
    public class CompanyDL
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["conIMS"].ConnectionString;
        }
        public List<Company> GetCompanyList()
        {
            SqlCommand myCommand = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlConnection myConnection=null;
            try
            {
                 myConnection = new SqlConnection(GetConnectionString());

                myConnection.Open();

                string strSql = @"SELECT c.[CompanyId] 
                                ,c.[CompanyTypeID]
	                            ,c.[Name]
                                ,c.[GSTINNumber]
                                ,c.[Phone]
                                ,c.[Email]
                                ,c.[Address]
                                ,c.[CityId]
                                ,c.[StateId]
                                ,c.[Zip]
                                ,c.[PANNumber]
                                ,c.[ContactPerson]
                                ,c.[CINNumber]
                                ,c.[BankName]
                                ,c.[AccountNumber]
                                ,c.[IFSCCode]
                                ,c.[IsActive]
                                ,ci.[cityId],
                                ci.[Name] [CityName],
                                ci.[IsActive] [CityIsActive]
                                ,s.[stateId],
                                s.[Name] [StateName],
                                s.[IsActive] [StateIsActive]
                                ,ct.[CompanyTypeId],
                                ct.[Type],
                                ct.[IsActive] [CompanyTypeIsActive]
                            FROM [dbo].[tblCompany] c   
                            INNER JOIN [dbo].[tblCity] ci  
	                        ON c.CityId = ci.CityId 
                            INNER JOIN [dbo].[tblState] s 
	                        ON c.stateId = s.stateId
                            INNER JOIN [dbo].[tblCompanyType] 
	                        ct ON c.companyTypeId = ct.CompanyTypeId";

                myCommand = new SqlCommand("Command String", myConnection);
                myCommand.Connection = myConnection;
                myCommand.CommandText = strSql;

                 da = new SqlDataAdapter(myCommand);

                 ds = new DataSet();
                da.Fill(ds, "tblCompany");

                List<Company> companies = new List<Company>();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Company company = new Company();
                        company.ID = Convert.ToInt32(dr["CompanyId"]);
                        company.AccountNumber = Convert.ToString(dr["AccountNumber"]);
                        company.BankName = Convert.ToString(dr["BankName"]);
                        company.CINNum = Convert.ToString(dr["CINNumber"]);
                        company.GSTINNUM = Convert.ToString(dr["GSTINNumber"]);
                        company.IFSCCode = Convert.ToString(dr["IFSCCode"]);
                        company.Name = Convert.ToString(dr["Name"]);
                        company.PANNumber = Convert.ToString(dr["PANNumber"]);
                        company.Zip = Convert.ToString(dr["Zip"]);
                        company.Phone = Convert.ToString(dr["Phone"]);
                        company.Address = Convert.ToString(dr["Address"]);
                        company.Email = Convert.ToString(dr["Email"]);
                        company.ContactPerson= Convert.ToString(dr["ContactPerson"]);

                        State state = new State();
                        state.ID = Convert.ToInt32(dr["StateId"]);
                        state.Name = Convert.ToString(dr["StateName"]);
                        state.IsActive = Convert.ToBoolean(dr["StateIsActive"]);
                        company.State = state;

                        City city = new City();
                        city.ID = Convert.ToInt32(dr["CityId"]);
                        city.Name = Convert.ToString(dr["CityName"]);
                        city.State = state;
                        city.IsActive = Convert.ToBoolean(dr["CityIsActive"]);
                        company.City = city;

                        CompanyType companyType = new CompanyType();
                        companyType.ID = Convert.ToInt32(dr["CompanyTypeID"]);
                        companyType.Type = Convert.ToString(dr["Type"]);
                        companyType.IsActive = Convert.ToBoolean(dr["CompanyTypeIsActive"]);
                        company.Type = companyType;

                        companies.Add(company);
                    }
                }
                return companies;

            }
            finally
            {
                
                if (myCommand != null)
                {
                    myCommand.Dispose(); 
                }
                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
                if(da != null)
                {
                    da.Dispose();
                }
                if (ds!= null)
                {
                    ds.Dispose();
                }
            }
        }

        public List<State> GetStates()
        {
            SqlCommand myCommand = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlConnection myConnection = null;
            try
            {
                 myConnection = new SqlConnection(GetConnectionString());

                myConnection.Open();

                string strSql = @"select stateid,Name,isActive from [dbo].[tblstate] where isactive = 1";

                myCommand = new SqlCommand("Command String", myConnection);
                myCommand.Connection = myConnection;
                myCommand.CommandText = strSql;

                da = new SqlDataAdapter(myCommand);

                ds = new DataSet();
                da.Fill(ds, "tblState");

                List<State> states = new List<State>();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        State state = new State();
                        state.ID = Convert.ToInt32(dr["StateId"]);
                        state.Name = Convert.ToString(dr["Name"]);
                        state.IsActive = Convert.ToBoolean(dr["IsActive"]);
                        
                        

                        states.Add(state);
                    }
                }
                return states;

            }
            finally
            {
                if (myCommand != null)
                {
                    myCommand.Dispose();
                }

                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }

                if (da != null)
                {
                    da.Dispose();
                }
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
        }

        public List<City> GetCities(int stateId)
        {
            SqlCommand myCommand = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(GetConnectionString());

                myConnection.Open();

                string strSql = @"select Cityid,Name,isActive from [dbo].[tblCity] where isactive = 1 AND StateId = " + stateId.ToString();

                myCommand = new SqlCommand("Command String", myConnection);
                myCommand.Connection = myConnection;
                myCommand.CommandText = strSql;

                da = new SqlDataAdapter(myCommand);

                ds = new DataSet();
                da.Fill(ds, "tblCity");

                List<City> cities = new List<City>();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        City state = new City();
                        state.ID = Convert.ToInt32(dr["CityId"]);
                        state.Name = Convert.ToString(dr["Name"]);
                        state.IsActive = Convert.ToBoolean(dr["IsActive"]);



                        cities.Add(state);
                    }
                }
                return cities;

            }
            finally
            {
                if (myCommand != null)
                {
                    myCommand.Dispose();
                }

                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }

                if (da != null)
                {
                    da.Dispose();
                }
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
        }

        public List<CompanyType> GetCompanyTypes()
        {
            SqlCommand myCommand = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(GetConnectionString());

                myConnection.Open();

                string strSql = @"select companytypeid,type,IsActive from [tblCompanyType] where isactive = 1";

                myCommand = new SqlCommand("Command String", myConnection);
                myCommand.Connection = myConnection;
                myCommand.CommandText = strSql;

                da = new SqlDataAdapter(myCommand);

                ds = new DataSet();
                da.Fill(ds, "tblCompanyType");

                List<CompanyType> companytypes = new List<CompanyType>();
                if (ds != null && ds.Tables.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        CompanyType companyType = new CompanyType();
                        companyType.ID = Convert.ToInt32(dr["CompanyTypeId"]);
                        companyType.Type = Convert.ToString(dr["Type"]);
                        companyType.IsActive = Convert.ToBoolean(dr["IsActive"]);



                        companytypes.Add(companyType);
                    }
                }
                return companytypes ;

            }
            finally
            {
                if (myCommand != null)
                {
                    myCommand.Dispose();
                }

                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }

                if (da != null)
                {
                    da.Dispose();
                }
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
        }

        public int AddCompany(Company comp)
        {
            SqlCommand myCommand = null;
            SqlDataAdapter da = null;
            DataSet ds = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(GetConnectionString());

                myConnection.Open();

                string strSql = String.Format(@"INSERT INTO dbo.tblCompany(CompanyTypeID,Name,GSTINNumber,Phone,Email,Address,CityId,StateId,Zip,PANNumber,ContactPerson,CINNumber,BankName,AccountNumber,IFSCCode, IsActive,CreatedBy,CreatedDate) values ({0},'{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}','{10}','{11}','{12}','{13}','{14}',{15},'{16}','{17}')",comp.Type.ID,comp.Name, comp.GSTINNUM,comp.Phone,comp.Email,comp.Address,comp.City.ID,comp.State.ID,comp.Zip,comp.PANNumber,comp.ContactPerson,comp.CINNum,comp.BankName,comp.AccountNumber,comp.IFSCCode,1,1,System.DateTime.Now);

                myCommand = new SqlCommand("Command String", myConnection);
                myCommand.Connection = myConnection;
                myCommand.CommandText = strSql;
                return myCommand.ExecuteNonQuery();
            }
            finally
            {
                if (myCommand != null)
                {
                    myCommand.Dispose();
                }

                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }

                if (da != null)
                {
                    da.Dispose();
                }
                if (ds != null)
                {
                    ds.Dispose();
                }
            }
        }
        }
        
        
    }

