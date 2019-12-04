using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NipponBudget.Models
{
    public class BO
    {
    }
    public class Budgetcode
    {
        //public string BudgetCode { get; set; }
        public string BudgetName { get; set; }
        //public string Budgetdescription { get; set; }
        public DateTime BudgetStartDate { get; set; }
        public DateTime BudgetEndDate { get; set; }
        public DateTime SOStartDate { get; set; }
        public DateTime SOEndDate { get; set; }
        public DateTime ApproverStartDate { get; set; }
        public DateTime ApproverEndDate { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        //public List<BudgetProductDetail> UDTBudget { get; set; }
    }
    public class ProductDetails
    {
        public string SalesDivisionDesc { get; set; }
        public string ProductSegmentDesc { get; set; }
        public string ProductCategoryDesc { get; set; } 
        public string Percentage { get; set; }

    }
    public class BudgetProductDetail
    {
        //public string BudgetCode { get; set; }
        //public string BudgetName { get; set; }
        public string SalesDivisionDesc { get; set; }
        public string ProductSegmentDesc { get; set; }
        public string ProductCategoryDesc { get; set; }
        public string Percentage { get; set; }
    }
    public class BudgetDetails
    {
        public string ID { get; set; }
        public string BudgetCode { get; set; }
        public string BudgetName { get; set; }
        public string BudgetStartDate { get; set; }
        public string BudgetEndDate { get; set; }
        public string SOStartDate { get; set; }
        public string SOEndDate { get; set; }
        public string ApproverStartDate { get; set; }
        public string ApproverEndDate { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }

    }

    public class budget
    {

        public string BudgetCode { get; set; }
    }
    public class budgettransaction
    {

        public string ID { get; set; }
        public string BudgetCode { get; set; }
        public string BudgetName { get; set; }
        public string SalesDivisionDesc { get; set; }
        public string ProductSegmentDesc { get; set; }
        public string ProductCategoryDesc { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string Percentage { get; set; }


    }

    public class SelectDealerValue
    {
        public string DealerName { get; set; }
        public string Amount { get; set; }
        public string Projectedamount { get; set;}
        public string salesgroup { get; set; }
        

    }
    public class SelectNewDealerValue
    {
        public string DealerName   { get; set; }
        public string Amount { get; set; }
        public string Projectedamount { get; set; }
        


    }
    public class user
    {
        public string userid { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string usertype { get; set; }
        public string salesgroup { get; set; }
        public string territory { get; set; }
        public string businesstype { get; set; }   
        public string status { get; set; }
        public string SOPassword { get; set; }
    }

    public class budgetupdate
    {

        public string BudgetCode { get; set; }
        public string BudgetName { get; set; }
        public string Budgetdescription { get; set; }
        public string BudgetStartDate { get; set; }
        public string BudgetEndDate { get; set; }
        public string SOStartDate { get; set; }
        public string SOEndDate { get; set; }
        public string ApproverStartDate { get; set; }
        public string ApproverEndDate { get; set; }
        public string Active { get; set; }
     

    }

}