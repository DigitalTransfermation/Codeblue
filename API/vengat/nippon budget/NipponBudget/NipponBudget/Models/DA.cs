using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NipponBudget.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace NipponBudget.Models
{
    public class DA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        public bool CreateBudget(Budgetcode Bcobj)
        {
            cmd = new SqlCommand("spInsertNewBudget", con);
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
            cmd.Parameters.AddWithValue("@CreatedBy ", Bcobj.CreatedBy);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count != 0)
            {

                return true;
            }
            else
            {
                return false;

            }
        }

        public IEnumerable<ProductDetails> bindShowProductDetails(ProductDetails Pdobj)
        {

            List<ProductDetails> Productslist = new List<ProductDetails>();
            cmd = new SqlCommand("sp_SelectProductDetails", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pdobj = new ProductDetails();
                    Pdobj.ProductSegmentDesc = dr["ProductSegmentDesc"].ToString();
                    Pdobj.ProductCategoryDesc = dr["ProductCategoryDesc"].ToString();
                    Pdobj.SalesDivisionDesc = dr["SalesDivisionDesc"].ToString();
                    Pdobj.Percentage = dr["Percentage"].ToString();
                    Productslist.Add(Pdobj);
                }

            }
            con.Close();
            return Productslist;


        }
    }
}