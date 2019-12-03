using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace employeevote.assets
{
    public partial class adminreport : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectionnipponpaintstars"].ToString());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                string query2 = "select * from Vote_Box  order by Vote_Box_id asc";
                cmd = new SqlCommand(query2, con);
                con.Open();
                da = new SqlDataAdapter(cmd);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                gvfullsummery.DataSource = dt2;
                gvfullsummery.DataBind();
                con.Close();

                cmd = new SqlCommand("select count(B.voteid) as votes,G.Name,G.Division from Vote_Box as B left join Emp_voter_list as G  on B.voteid=G.voteid group by G.Name,G.Division", con);
                con.Open();
                da = new SqlDataAdapter(cmd);
                DataTable dtreport = new DataTable();
                da.Fill(dtreport);
                con.Close();
                gvdetailview.DataSource = dtreport;
                gvdetailview.DataBind();
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //required to avoid the run time error "  
            //Control 'GridView1' of type 'Grid View' must be placed inside a form tag with runat=server."  
        }

        protected void btnfullsummery_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Vote summery Report" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);

            gvfullsummery.GridLines = GridLines.Both;
            gvfullsummery.HeaderStyle.Font.Bold = true;
            gvfullsummery.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();
        }

        protected void btncountsummery_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "Votes for each video Report" + DateTime.Now + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);

            gvdetailview.GridLines = GridLines.Both;
            gvdetailview.HeaderStyle.Font.Bold = true;
            gvdetailview.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();
        }
    }
}