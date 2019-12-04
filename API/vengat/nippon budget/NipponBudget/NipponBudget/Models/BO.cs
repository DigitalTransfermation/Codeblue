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
        public string BudgetCode { get; set; }
        public string BudgetName { get; set; }
        public string Budgetdescription { get; set; }
        public DateTime BudgetStartDate { get; set; }
        public DateTime BudgetEndDate { get; set; }
        public DateTime SOStartDate { get; set; }
        public DateTime SOEndDate { get; set; }
        public DateTime ApproverStartDate { get; set; }
        public DateTime ApproverEndDate { get; set; }
        public string Active { get; set; }
        public string CreatedBy { get; set; }
        public List<ProductDetails> ProductValue { get; set; }
    }
    public class ProductDetails
    {
        public string SalesDivisionDesc { get; set; }
        public string ProductSegmentDesc { get; set; }
        public string ProductCategoryDesc { get; set; }
        public string Percentage { get; set; }

    }

}