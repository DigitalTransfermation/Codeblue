using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Nphrisservice.Models
{
    public class DataAccess
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlConnection conhdn = new SqlConnection(ConfigurationManager.ConnectionStrings["HDNconnection"].ConnectionString);

        SqlCommand cmd = new SqlCommand();
        public bool CheckCredentials(Employeedetails Cobj)
        {
            cmd = new SqlCommand("select count(EmpNo) as exist from employees where Status='Active' and EmpNo=@EmpNo", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@EmpNo", Cobj.EmployeeId);
            int exist = (int)cmd.ExecuteScalar();

            con.Close();
            if (exist == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public Employeedetails FetchEmpDetails(Employeedetails Cobj, string encriptpwd)
        {


            cmd = new SqlCommand("select count(muser_empno) as exist from HDNNippon.dbo.Musers WHERE  muser_empno=@muser_empno and muser_password=@muser_password", conhdn);
            conhdn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@muser_empno", Cobj.EmployeeId);
            cmd.Parameters.AddWithValue("@muser_password", encriptpwd);
            int exist = (int)cmd.ExecuteScalar();
            conhdn.Close();

            //string str = Cobj.Password;
            //char CurrentChar;
            //for (int i = 0; i <= str.Length; i++) // I started i = 0, vs. yours i =1
            //{
            //    if (i == 3)
            //    {
            //        CurrentChar = str.Substring(i, 3)[0];
            //        if (CurrentChar == '#')
            //        {
            //            exist = 201;

            //        }
            //    }
            //}
            Employeedetails _Empdetails = new Employeedetails();
            if (exist != 0)
            {

                cmd = new SqlCommand("select EmpNo,Name,Designation,EmployeeType,Location,BusinessUnit,Division,Department,Gender,Status from  employees where Status='Active' and EmpNo=@EmpNo", con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@EmpNo", Cobj.EmployeeId);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Employeedetails Cred = new Employeedetails();
                        Cobj.EmpNo = dr["EmpNo"].ToString();
                        Cobj.Name = dr["Name"].ToString();
                        Cobj.Designation = dr["Designation"].ToString();
                        Cobj.EmployeeType = dr["EmployeeType"].ToString();
                        Cobj.Location = dr["Location"].ToString();
                        Cobj.BusinessUnit = dr["BusinessUnit"].ToString();
                        Cobj.Division = dr["Division"].ToString();
                        Cobj.Department = dr["Department"].ToString();
                        Cobj.Gender = dr["Gender"].ToString();
                        Cobj.Status = dr["Status"].ToString();
                        Cobj.Password = "";                  // _Empdetails.Add(Cobj);
                    }
                }
                con.Close();
                return Cobj;

            }
            //else if (exist == 201)
            //{
            //    cmd = new SqlCommand("select EmpNo,Name,Designation,EmployeeType,Location,BusinessUnit,Division,Department,Gender,Status from  employees where Status='Active' and EmpNo=@EmpNo", con);
            //    con.Open();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.Parameters.AddWithValue("@EmpNo", Cobj.EmployeeId);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            Employeedetails Cred = new Employeedetails();
            //            Cred.EmpNo = dr["EmpNo"].ToString();
            //            Cred.Name = dr["Name"].ToString();
            //            Cred.Designation = dr["Designation"].ToString();
            //            Cred.EmployeeType = dr["EmployeeType"].ToString();
            //            Cred.Location = dr["Location"].ToString();
            //            Cred.BusinessUnit = dr["BusinessUnit"].ToString();
            //            Cred.Division = dr["Division"].ToString();
            //            Cred.Department = dr["Department"].ToString();
            //            Cred.Gender = dr["Gender"].ToString();
            //            Cred.Status = dr["Status"].ToString();
            //            _Empdetails.Add(Cred);
            //        }
            //    }
            //    con.Close();
            //    return _Empdetails;
            //}
            else
            {
                _Empdetails = null;

                return _Empdetails;
            }
        }


        public IEnumerable<Employeedetails> EmployeeList()
        {
          List< Employeedetails> _Empdetails = new List<Employeedetails>();
            cmd = new SqlCommand("select EmpNo,Name,Designation,EmployeeType,Location,BusinessUnit,Division,Department,Gender,Status from  employees where Status='Active'", con);
            con.Open();
            cmd.CommandType = CommandType.Text;           
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employeedetails Cobj = new Employeedetails();
                    Cobj.EmpNo = dr["EmpNo"].ToString();
                    Cobj.Name = dr["Name"].ToString();
                    Cobj.Designation = dr["Designation"].ToString();
                    Cobj.EmployeeType = dr["EmployeeType"].ToString();
                    Cobj.Location = dr["Location"].ToString();
                    Cobj.BusinessUnit = dr["BusinessUnit"].ToString();
                    Cobj.Division = dr["Division"].ToString();
                    Cobj.Department = dr["Department"].ToString();
                    Cobj.Gender = dr["Gender"].ToString();
                    Cobj.Status = dr["Status"].ToString();
                    Cobj.Password = "";
                    _Empdetails.Add(Cobj);

                }
            }
            return _Empdetails;

           
        }
    }
}