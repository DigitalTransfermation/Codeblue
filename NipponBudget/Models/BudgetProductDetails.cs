using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Web;
//using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace NipponBudget.Models
{
    public static class BudgetProductDetails
    {
        public static DataTable ToDataTable<T>(this IList<T> objList)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable objDataTable = new DataTable();
            foreach (PropertyDescriptor property in properties)
                objDataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            if (objList != null)
            {
                foreach (T item in objList)
                {
                    DataRow row = objDataTable.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    objDataTable.Rows.Add(row);
                }
            }
            return objDataTable;
        }
    }
}