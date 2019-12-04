using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NipponBudget.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using EncryptPwd;

namespace NipponBudget.Models
{
    public class DA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlConnection conhdn = new SqlConnection(ConfigurationManager.ConnectionStrings["HDNconnection"].ConnectionString);
        SqlConnection Econ = new SqlConnection(ConfigurationManager.ConnectionStrings["Employeeconnection"].ConnectionString);

        SqlCommand cmd = new SqlCommand();
        public string CreateBudget(Budgetcode Bcobj)
        {
            cmd = new SqlCommand("spInsertNewBudget", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BudgetName", Bcobj.BudgetName);
            //cmd.Parameters.AddWithValue("@Budgetdescription ", Bcobj.Budgetdescription);
            cmd.Parameters.AddWithValue("@BudgetStartDate ", Bcobj.BudgetStartDate);
            cmd.Parameters.AddWithValue("@BudgetEndDate ", Bcobj.BudgetEndDate);
            cmd.Parameters.AddWithValue("@SOStartDate ", Bcobj.SOStartDate);
            cmd.Parameters.AddWithValue("@SOEndDate ", Bcobj.SOEndDate);
            cmd.Parameters.AddWithValue("@ApproverStartDate ", Bcobj.ApproverStartDate);
            cmd.Parameters.AddWithValue("@ApproverEndDate ", Bcobj.ApproverEndDate);
            cmd.Parameters.AddWithValue("@Active ", Bcobj.Active);
            cmd.Parameters.AddWithValue("@CreatedBy ", Bcobj.CreatedBy);
            /*The output parameter*/
            cmd.Parameters.Add("@BudgetCode", SqlDbType.VarChar, 100);
            cmd.Parameters["@BudgetCode"].Direction = ParameterDirection.Output;
            /*End*/
            int count = cmd.ExecuteNonQuery();
            string data = Convert.ToString(cmd.Parameters["@BudgetCode"].Value);
            con.Close();
            cmd = new SqlCommand();

            if (count != 0)
            {

                return data;
            }
            else
            {
                return data;

            }
        }

        public string UpdateBudget(budgetupdate Bcobj)
        {
            cmd = new SqlCommand("spBudgetUpdate", con);
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BudgetName", Bcobj.BudgetName);
            cmd.Parameters.AddWithValue("@Budgetdescription ", Bcobj.Budgetdescription);
            cmd.Parameters.AddWithValue("@BudgetStartDate ", Bcobj.BudgetStartDate);
            cmd.Parameters.AddWithValue("@BudgetEndDate ", Bcobj.BudgetEndDate);
            cmd.Parameters.AddWithValue("@SOStartDate ", Bcobj.SOStartDate);
            cmd.Parameters.AddWithValue("@SOEndDate ", Bcobj.SOEndDate);
            cmd.Parameters.AddWithValue("@ApproverStartDate ", Bcobj.ApproverStartDate);
            cmd.Parameters.AddWithValue("@ApproverEndDate ", Bcobj.ApproverEndDate);
            cmd.Parameters.AddWithValue("@Active ", Bcobj.Active);          
            /*The output parameter*/
            cmd.Parameters.AddWithValue("@BudgetCode", Bcobj.BudgetCode);
        
            /*End*/
            int count = cmd.ExecuteNonQuery();
           
            con.Close();
            cmd = new SqlCommand();

            if (count != 0)
            {

                return "Updated";
            }
            else
            {
                return "NotUpdated";

            }


        }
        public IEnumerable<SelectDealerValue> bindDealerValue(SelectDealerValue Dealerobj)
        {

            List<SelectDealerValue> Dealerlist = new List<SelectDealerValue>();
            cmd = new SqlCommand("spSelectDealerValue", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@salesgroup", Dealerobj.salesgroup);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Dealerobj = new SelectDealerValue();
                    Dealerobj.DealerName = dr["Dealer"].ToString();
                    Dealerobj.Amount = Convert.ToDecimal(dr["Amount"]).ToString();
                    Dealerobj.Projectedamount = dr["ProjectionAmount"].ToString();
                    Dealerlist.Add(Dealerobj);


                }

            }
            con.Close();
            return Dealerlist;


        }

        public IEnumerable<SelectNewDealerValue> bindNewDealerValue(SelectNewDealerValue Dealerobj)
        {

            List<SelectNewDealerValue> Dealerlist = new List<SelectNewDealerValue>();
            cmd = new SqlCommand("spSelectNewDealerValue", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Dealerobj = new SelectNewDealerValue();
                    Dealerobj.DealerName = dr["DealerName"].ToString();
                    Dealerobj.Amount = dr["Amount"].ToString();
                    Dealerobj.Projectedamount = dr["Amount"].ToString();

                    Dealerlist.Add(Dealerobj);
                }

            }
            con.Close();
            return Dealerlist;


        }


        public IEnumerable<BudgetDetails> bindShowBudgetDetails(BudgetDetails Pdobj)
        {

            List<BudgetDetails> Budgetlist = new List<BudgetDetails>();
            cmd = new SqlCommand("Sp_GetBudgetDetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pdobj = new BudgetDetails();
                    Pdobj.ID = dr["ID"].ToString();
                    Pdobj.BudgetName = dr["BudgetName"].ToString();
                    Pdobj.BudgetCode = dr["BudgetCode"].ToString();
                    Pdobj.BudgetStartDate = dr["BudgetStartDate"].ToString();
                    Pdobj.BudgetEndDate = dr["BudgetEndDate"].ToString();
                    Pdobj.SOStartDate = dr["SOStartDate"].ToString();
                    Pdobj.SOEndDate = dr["SOEndDate"].ToString();
                    Pdobj.ApproverStartDate = dr["ApproverStartDate"].ToString();
                    Pdobj.ApproverEndDate = dr["ApproverEndDate"].ToString();
                    Pdobj.CreatedBy = dr["CreatedBy"].ToString();
                    Pdobj.Active = dr["Active"].ToString();
                    Budgetlist.Add(Pdobj);
                }

            }
            con.Close();
            return Budgetlist;


        }





        public user login(user userobj)
        {
            string encryptpwd = Encrypt.getEncrValue(userobj.password, "10");
            userobj.SOPassword = userobj.password;
            cmd = new SqlCommand("spgetlogindetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", userobj.userid);
            cmd.Parameters.AddWithValue("@SOPassword", userobj.SOPassword);
            cmd.Parameters.AddWithValue("@password", encryptpwd); 
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string _usertype = dr["UserType"].ToString();
                    userobj.usertype = _usertype.ToString();
                    if (userobj.usertype == "Sales Officer")
                    {
                        userobj.userid = dr["userid"].ToString();
                        userobj.salesgroup = dr["salesgroup"].ToString();
                        userobj.territory = dr["territory"].ToString();
                        userobj.businesstype = dr["businesstype"].ToString();
                        userobj.status = dr["status"].ToString();
                    }
                    else if (userobj.usertype == "User does not exist")
                    {

                        userobj.username = "";
                        userobj.status = "User does not exist";  

                    }
                    else
                    {
                        userobj.userid = dr["userid"].ToString();
                        userobj.username = dr["username"].ToString();
                        userobj.status = dr["status"].ToString();
                    }     
                    userobj.password = "";
                    userobj.SOPassword = ""; 
                }

            }
            con.Close();
            return userobj;
        }
    }
}
//public user FetchEmpDetails(user userobj, string encriptpwd)
//{


//    cmd = new SqlCommand("select count(muser_empno) as exist from HDNNippon.dbo.Musers WHERE  muser_empno=@muser_empno and muser_password=@muser_password", conhdn);
//    conhdn.Open();
//    cmd.CommandType = CommandType.Text;
//    cmd.Parameters.AddWithValue("@muser_empno", userobj.userid);
//    cmd.Parameters.AddWithValue("@muser_password", encriptpwd);
//    int exist = (int)cmd.ExecuteScalar();
//    conhdn.Close();

//    user _Empdetails = new user();
//    if (exist != 0)
//    {

//        cmd = new SqlCommand("select EmpNo,Name from  employees where Status='Active' and EmpNo=@EmpNo", Econ);
//        Econ.Open();
//        cmd.CommandType = CommandType.Text;
//        cmd.Parameters.AddWithValue("@EmpNo", userobj.userid);
//        SqlDataReader dr = cmd.ExecuteReader();
//        if (dr.HasRows)
//        {
//            while (dr.Read())
//            {
//                //Employeedetails Cred = new Employeedetails();
//                userobj.userid = dr["EmpNo"].ToString();
//                userobj.username = dr["Name"].ToString();


//                userobj.password = "";                  // _Empdetails.Add(Cobj);
//            }
//        }
//        Econ.Close();
//        return userobj;

//    }

//    else
//    {
//        _Empdetails = null;

//        return _Empdetails;
//    }
//}

