using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace employeevote.assets
{
    public partial class vote : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectionnipponpaintstars"].ToString());
        SqlCommand cmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (HttpContext.Current.Session["Name"] != null)
                {
                    lblempname.Text = Session["Name"].ToString();
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    Employeelist_DECO();
                    Employeelist_IU();
                    Employeelist_CO();
                    Employeelist_AR();

                    //if (lblvoted.Text == "4")
                    //{

                    //    Extravote();
                    //}
                }
                else
                {
                    Response.Redirect("Index");


                }

            }
        }



        protected string Voted(string empno)
        {
            con.Close();
            cmd = new SqlCommand("select count(Emp_No) as emp_no from Vote_Box where Emp_No=@Emp_No ", con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Emp_No", empno);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count.ToString();

        }

        public void Employeelist_DECO()
        {
            SqlCommand cmddeco = new SqlCommand("select * from Emp_voter_list  where division='DECO'", con);

            con.Open();
            DataTable dtdeco = new DataTable();
            SqlDataAdapter dadeco = new SqlDataAdapter(cmddeco);
            dadeco.Fill(dtdeco);
            rpt_deco.DataSource = dtdeco;
            rpt_deco.DataBind();
            con.Close();

            SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
            con.Open();
            cmdextravote.CommandType = CommandType.StoredProcedure;
            string empno = Session["Empno"].ToString();
            cmdextravote.Parameters.AddWithValue("@emp_no", empno);
            SqlDataReader drextra = cmdextravote.ExecuteReader();
            if (drextra.HasRows)
            {
                while (drextra.Read())
                {
                    _IUcount = drextra["IUcount"].ToString();
                    _DECOcount = drextra["DECOcount"].ToString();
                    _ARcount = drextra["ARcount"].ToString();
                    _COcount = drextra["COcount"].ToString();
                }

            }

            con.Close();
            if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
            {
                foreach (RepeaterItem item in rpt_deco.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");
                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }

                }
                foreach (RepeaterItem item in RP_CO.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_IU.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_AR.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }

            }
            else
            {

                if ((checkvote(Session["Empno"].ToString(), "DECO") > 0) && (checkvote(Session["Empno"].ToString(), "DECO") != 2))
                {
                    foreach (RepeaterItem item in rpt_deco.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                        if (checktotalvote(Session["Empno"].ToString()) == 4)
                        {
                            btnvoteagain.Visible = true;
                            btnvote.Visible = false;
                        }
                    }
                }
                else if ((checkvote(Session["Empno"].ToString(), "DECO") > 0) && (checkvote(Session["Empno"].ToString(), "DECO") == 2))
                {
                    foreach (RepeaterItem item in rpt_deco.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                }
                else
                {
                    foreach (RepeaterItem item in rpt_deco.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnvote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = true;
                        btnvoteagain.Visible = false;
                    }


                }
            }
            lblvoted.Text = Voted(Session["Empno"].ToString());
            int _pending = 5 - int.Parse(lblvoted.Text);
            lblpending.Text = _pending.ToString();

        }

        public void Employeelist_IU()
        {

            SqlCommand cmd1 = new SqlCommand("select * from Emp_voter_list  where division='IU'", con);
            con.Close();
            con.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            RP_IU.DataSource = dt1;
            RP_IU.DataBind();
            con.Close();
            //if (checkvote(Session["Empno"].ToString(), "IU") > 0)
            //{
            //    foreach (RepeaterItem item in RP_IU.Items)
            //    {
            //        Button btnvote = (Button)item.FindControl("btnvote");

            //        btnvote.Visible = false;
            //    }
            //}
            //else
            //{
            //    foreach (RepeaterItem item in RP_IU.Items)
            //    {
            //        Button btnvote = (Button)item.FindControl("btnvote");

            //        btnvote.Visible = true;
            //    }


            //}
            //lblvoted.Text = Voted(Session["Empno"].ToString());
            //int _pending = 5 - int.Parse(lblvoted.Text);
            //lblpending.Text = _pending.ToString();

            SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
            con.Open();
            cmdextravote.CommandType = CommandType.StoredProcedure;
            string empno = Session["Empno"].ToString();
            cmdextravote.Parameters.AddWithValue("@emp_no", empno);
            SqlDataReader drextra = cmdextravote.ExecuteReader();
            if (drextra.HasRows)
            {
                while (drextra.Read())
                {
                    _IUcount = drextra["IUcount"].ToString();
                    _DECOcount = drextra["DECOcount"].ToString();
                    _ARcount = drextra["ARcount"].ToString();
                    _COcount = drextra["COcount"].ToString();
                }

            }

            con.Close();
            if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
            {
                foreach (RepeaterItem item in rpt_deco.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }

                }
                foreach (RepeaterItem item in RP_CO.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_IU.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_AR.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }

            }
            else
            {

                if ((checkvote(Session["Empno"].ToString(), "IU") > 0) && (checkvote(Session["Empno"].ToString(), "IU") != 2))
                {
                    foreach (RepeaterItem item in RP_IU.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                        if (checktotalvote(Session["Empno"].ToString()) == 4)
                        {
                            btnvoteagain.Visible = true;
                            btnvote.Visible = false;
                        }
                    }
                }
                else if ((checkvote(Session["Empno"].ToString(), "IU") > 0) && (checkvote(Session["Empno"].ToString(), "IU") == 2))
                {
                    foreach (RepeaterItem item in RP_IU.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                }
                else
                {
                    foreach (RepeaterItem item in RP_IU.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnvote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = true;
                        btnvoteagain.Visible = false;
                    }


                }
            }
            lblvoted.Text = Voted(Session["Empno"].ToString());
            int _pending = 5 - int.Parse(lblvoted.Text);
            lblpending.Text = _pending.ToString();

        }

        public void Employeelist_CO()
        {

            SqlCommand cmdCO = new SqlCommand("select * from Emp_voter_list  where division='CO'", con);
            con.Close();
            con.Open();
            DataTable dtCO = new DataTable();
            SqlDataAdapter daCO = new SqlDataAdapter(cmdCO);
            daCO.Fill(dtCO);
            RP_CO.DataSource = dtCO;
            RP_CO.DataBind();
            con.Close();
            //if (checkvote(Session["Empno"].ToString(), "CO") > 0)
            //{
            //    foreach (RepeaterItem item in RP_CO.Items)
            //    {
            //        Button btnvote = (Button)item.FindControl("btnvote");

            //        btnvote.Visible = false;
            //    }
            //}
            //else
            //{
            //    foreach (RepeaterItem item in RP_CO.Items)
            //    {
            //        Button btnvote = (Button)item.FindControl("btnvote");

            //        btnvote.Visible = true;
            //    }


            //}
            //lblvoted.Text = Voted(Session["Empno"].ToString());
            //int _pending = 5 - int.Parse(lblvoted.Text);
            //lblpending.Text = _pending.ToString();


            SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
            con.Open();
            cmdextravote.CommandType = CommandType.StoredProcedure;
            string empno = Session["Empno"].ToString();
            cmdextravote.Parameters.AddWithValue("@emp_no", empno);
            SqlDataReader drextra = cmdextravote.ExecuteReader();
            if (drextra.HasRows)
            {
                while (drextra.Read())
                {
                    _IUcount = drextra["IUcount"].ToString();
                    _DECOcount = drextra["DECOcount"].ToString();
                    _ARcount = drextra["ARcount"].ToString();
                    _COcount = drextra["COcount"].ToString();
                }

            }

            con.Close();
            if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
            {
                foreach (RepeaterItem item in rpt_deco.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }

                }
                foreach (RepeaterItem item in RP_CO.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_IU.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_AR.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }

            }
            else
            {

                if ((checkvote(Session["Empno"].ToString(), "CO") > 0) && (checkvote(Session["Empno"].ToString(), "CO") != 2))
                {
                    foreach (RepeaterItem item in RP_CO.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                        if (checktotalvote(Session["Empno"].ToString()) == 4)
                        {
                            btnvoteagain.Visible = true;
                            btnvote.Visible = false;
                        }
                    }
                }
                else if ((checkvote(Session["Empno"].ToString(), "CO") > 0) && (checkvote(Session["Empno"].ToString(), "CO") == 2))
                {
                    foreach (RepeaterItem item in RP_CO.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                }
                else
                {
                    foreach (RepeaterItem item in RP_CO.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnvote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = true;
                        btnvoteagain.Visible = false;
                    }


                }
            }
            lblvoted.Text = Voted(Session["Empno"].ToString());
            int _pending = 5 - int.Parse(lblvoted.Text);
            lblpending.Text = _pending.ToString();

        }

        public void Employeelist_AR()
        {

            SqlCommand cmdAR = new SqlCommand("select * from Emp_voter_list  where division='AR'", con);
            con.Close();
            con.Open();
            DataTable dtAR = new DataTable();
            SqlDataAdapter daAR = new SqlDataAdapter(cmdAR);
            daAR.Fill(dtAR);
            RP_AR.DataSource = dtAR;
            RP_AR.DataBind();
            con.Close();
            //if (checkvote(Session["Empno"].ToString(), "AR") > 0)
            //{
            //    foreach (RepeaterItem item in RP_AR.Items)
            //    {
            //        Button btnvote = (Button)item.FindControl("btnvote");

            //        btnvote.Visible = false;
            //    }
            //}
            //else
            //{
            //    foreach (RepeaterItem item in RP_AR.Items)
            //    {
            //        Button btnvote = (Button)item.FindControl("btnvote");

            //        btnvote.Visible = true;
            //    }


            //}
            //lblvoted.Text = Voted(Session["Empno"].ToString());
            //int _pending = 5 - int.Parse(lblvoted.Text);
            //lblpending.Text = _pending.ToString();

            SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
            con.Open();
            cmdextravote.CommandType = CommandType.StoredProcedure;
            string empno = Session["Empno"].ToString();
            cmdextravote.Parameters.AddWithValue("@emp_no", empno);
            SqlDataReader drextra = cmdextravote.ExecuteReader();
            if (drextra.HasRows)
            {
                while (drextra.Read())
                {
                    _IUcount = drextra["IUcount"].ToString();
                    _DECOcount = drextra["DECOcount"].ToString();
                    _ARcount = drextra["ARcount"].ToString();
                    _COcount = drextra["COcount"].ToString();
                }

            }

            con.Close();
            if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
            {
                foreach (RepeaterItem item in rpt_deco.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }

                }
                foreach (RepeaterItem item in RP_CO.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_IU.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }
                foreach (RepeaterItem item in RP_AR.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");
                    Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                    Label lblcode = (Label)item.FindControl("lblcode");
                    string _votecode = lblcode.Text;
                    if (checksinglevote(Session["Empno"].ToString(), _votecode.ToString()) != 0)
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                    else
                    {

                        btnvote.Visible = false;
                        btnvoteagain.Visible = true;
                    }
                }

            }
            else
            {

                if ((checkvote(Session["Empno"].ToString(), "AR") > 0) && (checkvote(Session["Empno"].ToString(), "AR") != 2))
                {
                    foreach (RepeaterItem item in RP_AR.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                        if (checktotalvote(Session["Empno"].ToString()) == 4)
                        {
                            btnvoteagain.Visible = true;
                            btnvote.Visible = false;
                        }
                    }
                }
                else if ((checkvote(Session["Empno"].ToString(), "AR") > 0) && (checkvote(Session["Empno"].ToString(), "AR") == 2))
                {
                    foreach (RepeaterItem item in RP_AR.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnVote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = false;
                        btnvoteagain.Visible = false;
                    }
                }
                else
                {
                    foreach (RepeaterItem item in RP_AR.Items)
                    {
                        Button btnvote = (Button)item.FindControl("btnvote");
                        Button btnvoteagain = (Button)item.FindControl("btnvoteagain");

                        btnvote.Visible = true;
                        btnvoteagain.Visible = false;
                    }


                }
            }
            lblvoted.Text = Voted(Session["Empno"].ToString());
            int _pending = 5 - int.Parse(lblvoted.Text);
            lblpending.Text = _pending.ToString();

        }

        protected int checkvote(string empno, string VoteDivision)
        {
            cmd = new SqlCommand("select count(Emp_No) as emp_no from Vote_Box where Emp_No=@Emp_No and VoteDivision=@VoteDivision", con);
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Emp_No", empno);
            cmd.Parameters.AddWithValue("@VoteDivision", VoteDivision);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }
        protected int checktotalvote(string empno)
        {
            cmd = new SqlCommand("select count(Emp_No) as emp_no from Vote_Box where Emp_No=@Emp_No", con);
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Emp_No", empno);

            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }
        protected int checksinglevote(string empno, string votecode)
        {
            cmd = new SqlCommand("select count(Emp_No) as emp_no from Vote_Box where Emp_No=@Emp_No and Voteid=@Voteid", con);
            con.Close();
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Emp_No", empno);
            cmd.Parameters.AddWithValue("@Voteid", votecode);

            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;

        }
        protected bool putvote(string empno, int voteid, string VoteDivision, string votename)
        {
            con.Close();
            cmd = new SqlCommand("sp_HR_Vote_Box", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Emp_No", empno);
            cmd.Parameters.AddWithValue("@Voteid", voteid);
            cmd.Parameters.AddWithValue("@VoteDivision", VoteDivision);
            cmd.Parameters.AddWithValue("@Empdivision", Session["division"]);
            cmd.Parameters.AddWithValue("@Empdepartment", Session["department"]);
            cmd.Parameters.AddWithValue("@EmpBusinessUnit", Session["BusinessUnit"]);
            cmd.Parameters.AddWithValue("@emplocation", Session["location"]);
            cmd.Parameters.AddWithValue("@empname", Session["name"]);
            cmd.Parameters.AddWithValue("@votename", votename);
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


        protected void rpt_deco_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Vote")
            {

                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");
                if (putvote(Session["Empno"].ToString(), Convert.ToInt32(lblcode.Text), lbldivision.Text, lblvotename.Text) ? true : false)
                {


                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);

                }

            }
            if (e.CommandName == "VoteAgain")
            {
                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");

                SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
                con.Open();
                cmdextravote.CommandType = CommandType.StoredProcedure;
                string empno = Session["Empno"].ToString();
                cmdextravote.Parameters.AddWithValue("@emp_no", empno);
                SqlDataReader drextra = cmdextravote.ExecuteReader();
                if (drextra.HasRows)
                {
                    while (drextra.Read())
                    {
                        _IUcount = drextra["IUcount"].ToString();
                        _DECOcount = drextra["DECOcount"].ToString();
                        _ARcount = drextra["ARcount"].ToString();
                        _COcount = drextra["COcount"].ToString();
                    }

                }

                con.Close();
                if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
                {
                    cmd = new SqlCommand("insert into Vote_Box (Emp_No,voteid,VoteDivision,empdivision,empdepartment,empBusinessUnit,emplocation,empname,votename) values  (@Emp_No, @voteid, @VoteDivision, @Empdivision, @empdepartment, @emplocation, @emplocation, @empname, @votename)", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Emp_No", empno);
                    cmd.Parameters.AddWithValue("@Voteid", Convert.ToInt32(lblcode.Text));
                    cmd.Parameters.AddWithValue("@VoteDivision", lbldivision.Text);
                    cmd.Parameters.AddWithValue("@Empdivision", Session["division"]);
                    cmd.Parameters.AddWithValue("@Empdepartment", Session["department"]);
                    cmd.Parameters.AddWithValue("@EmpBusinessUnit", Session["BusinessUnit"]);
                    cmd.Parameters.AddWithValue("@emplocation", Session["location"]);
                    cmd.Parameters.AddWithValue("@empname", Session["name"]);
                    cmd.Parameters.AddWithValue("@votename", lblvotename.Text);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }

            Employeelist_DECO();
            Employeelist_IU();
            Employeelist_CO();
            Employeelist_AR();
        }

        protected void RP_IU_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Vote")
            {

                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");
                if (putvote(Session["Empno"].ToString(), Convert.ToInt32(lblcode.Text), lbldivision.Text, lblvotename.Text) ? true : false)
                {
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }
            if (e.CommandName == "VoteAgain")
            {
                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");

                SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
                con.Open();
                cmdextravote.CommandType = CommandType.StoredProcedure;
                string empno = Session["Empno"].ToString();
                cmdextravote.Parameters.AddWithValue("@emp_no", empno);
                SqlDataReader drextra = cmdextravote.ExecuteReader();
                if (drextra.HasRows)
                {
                    while (drextra.Read())
                    {
                        _IUcount = drextra["IUcount"].ToString();
                        _DECOcount = drextra["DECOcount"].ToString();
                        _ARcount = drextra["ARcount"].ToString();
                        _COcount = drextra["COcount"].ToString();
                    }

                }

                con.Close();
                if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
                {
                    cmd = new SqlCommand("insert into Vote_Box (Emp_No,voteid,VoteDivision,empdivision,empdepartment,empBusinessUnit,emplocation,empname,votename) values  (@Emp_No, @voteid, @VoteDivision, @Empdivision, @empdepartment, @emplocation, @emplocation, @empname, @votename)", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Emp_No", empno);
                    cmd.Parameters.AddWithValue("@Voteid", Convert.ToInt32(lblcode.Text));
                    cmd.Parameters.AddWithValue("@VoteDivision", lbldivision.Text);
                    cmd.Parameters.AddWithValue("@Empdivision", Session["division"]);
                    cmd.Parameters.AddWithValue("@Empdepartment", Session["department"]);
                    cmd.Parameters.AddWithValue("@EmpBusinessUnit", Session["BusinessUnit"]);
                    cmd.Parameters.AddWithValue("@emplocation", Session["location"]);
                    cmd.Parameters.AddWithValue("@empname", Session["name"]);
                    cmd.Parameters.AddWithValue("@votename", lblvotename.Text);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }

            Employeelist_DECO();
            Employeelist_IU();
            Employeelist_CO();
            Employeelist_AR();
        }

        protected void RP_CO_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Vote")
            {

                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");
                if (putvote(Session["Empno"].ToString(), Convert.ToInt32(lblcode.Text), lbldivision.Text, lblvotename.Text) ? true : false)
                {
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }
            if (e.CommandName == "VoteAgain")
            {
                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");

                SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
                con.Open();
                cmdextravote.CommandType = CommandType.StoredProcedure;
                string empno = Session["Empno"].ToString();
                cmdextravote.Parameters.AddWithValue("@emp_no", empno);
                SqlDataReader drextra = cmdextravote.ExecuteReader();
                if (drextra.HasRows)
                {
                    while (drextra.Read())
                    {
                        _IUcount = drextra["IUcount"].ToString();
                        _DECOcount = drextra["DECOcount"].ToString();
                        _ARcount = drextra["ARcount"].ToString();
                        _COcount = drextra["COcount"].ToString();
                    }

                }

                con.Close();
                if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
                {
                    cmd = new SqlCommand("insert into Vote_Box (Emp_No,voteid,VoteDivision,empdivision,empdepartment,empBusinessUnit,emplocation,empname,votename) values  (@Emp_No, @voteid, @VoteDivision, @Empdivision, @empdepartment, @emplocation, @emplocation, @empname, @votename)", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Emp_No", empno);
                    cmd.Parameters.AddWithValue("@Voteid", Convert.ToInt32(lblcode.Text));
                    cmd.Parameters.AddWithValue("@VoteDivision", lbldivision.Text);
                    cmd.Parameters.AddWithValue("@Empdivision", Session["division"]);
                    cmd.Parameters.AddWithValue("@Empdepartment", Session["department"]);
                    cmd.Parameters.AddWithValue("@EmpBusinessUnit", Session["BusinessUnit"]);
                    cmd.Parameters.AddWithValue("@emplocation", Session["location"]);
                    cmd.Parameters.AddWithValue("@empname", Session["name"]);
                    cmd.Parameters.AddWithValue("@votename", lblvotename.Text);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }

            Employeelist_DECO();
            Employeelist_IU();
            Employeelist_CO();
            Employeelist_AR();
        }

        protected void RP_AR_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Vote")
            {

                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");
                if (putvote(Session["Empno"].ToString(), Convert.ToInt32(lblcode.Text), lbldivision.Text, lblvotename.Text) ? true : false)
                {
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }
            if (e.CommandName == "VoteAgain")
            {
                Label lblcode = (Label)e.Item.FindControl("lblcode");
                Label lbldivision = (Label)e.Item.FindControl("lbldivision");
                Label lblvotename = (Label)e.Item.FindControl("lblvotename");
                Label lblabout = (Label)e.Item.FindControl("lblabout");

                SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
                con.Open();
                cmdextravote.CommandType = CommandType.StoredProcedure;
                string empno = Session["Empno"].ToString();
                cmdextravote.Parameters.AddWithValue("@emp_no", empno);
                SqlDataReader drextra = cmdextravote.ExecuteReader();
                if (drextra.HasRows)
                {
                    while (drextra.Read())
                    {
                        _IUcount = drextra["IUcount"].ToString();
                        _DECOcount = drextra["DECOcount"].ToString();
                        _ARcount = drextra["ARcount"].ToString();
                        _COcount = drextra["COcount"].ToString();
                    }

                }

                con.Close();
                if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
                {
                    cmd = new SqlCommand("insert into Vote_Box (Emp_No,voteid,VoteDivision,empdivision,empdepartment,empBusinessUnit,emplocation,empname,votename) values  (@Emp_No, @voteid, @VoteDivision, @Empdivision, @empdepartment, @emplocation, @emplocation, @empname, @votename)", con);
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Emp_No", empno);
                    cmd.Parameters.AddWithValue("@Voteid", Convert.ToInt32(lblcode.Text));
                    cmd.Parameters.AddWithValue("@VoteDivision", lbldivision.Text);
                    cmd.Parameters.AddWithValue("@Empdivision", Session["division"]);
                    cmd.Parameters.AddWithValue("@Empdepartment", Session["department"]);
                    cmd.Parameters.AddWithValue("@EmpBusinessUnit", Session["BusinessUnit"]);
                    cmd.Parameters.AddWithValue("@emplocation", Session["location"]);
                    cmd.Parameters.AddWithValue("@empname", Session["name"]);
                    cmd.Parameters.AddWithValue("@votename", lblvotename.Text);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();
                    lblvoted.Text = Voted(Session["Empno"].ToString());
                    int _pending = 5 - int.Parse(lblvoted.Text);
                    lblpending.Text = _pending.ToString();
                    string message = "Thanks for voting to " + lblvotename.Text + " <br/> You still have " + lblpending.Text + " votes remaining to vote.";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "Success", "<script>showpop5('" + message + "')</script>", false);
                }

            }

            Employeelist_DECO();
            Employeelist_IU();
            Employeelist_CO();
            Employeelist_AR();
        }


        public string _IUcount { set; get; }
        public string _DECOcount { set; get; }
        public string _ARcount { set; get; }
        public string _COcount { set; get; }

        private void Extravote()
        {
            SqlCommand cmdextravote = new SqlCommand("sp_Extravote", con);
            con.Open();
            cmdextravote.CommandType = CommandType.StoredProcedure;
            string empno = Session["Empno"].ToString();
            cmdextravote.Parameters.AddWithValue("@emp_no", empno);
            SqlDataReader drextra = cmdextravote.ExecuteReader();
            if (drextra.HasRows)
            {
                while (drextra.Read())
                {
                    _IUcount = drextra["IUcount"].ToString();
                    _DECOcount = drextra["DECOcount"].ToString();
                    _ARcount = drextra["ARcount"].ToString();
                    _COcount = drextra["COcount"].ToString();
                }

            }

            con.Close();
            if ((_IUcount == "1") && (_DECOcount == "1") && (_ARcount == "1") && (_COcount == "1"))
            {
                foreach (RepeaterItem item in rpt_deco.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");

                    btnvote.Visible = true;
                }
                foreach (RepeaterItem item in RP_CO.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");

                    btnvote.Visible = true;
                }
                foreach (RepeaterItem item in RP_IU.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");

                    btnvote.Visible = true;
                }
                foreach (RepeaterItem item in RP_AR.Items)
                {
                    Button btnvote = (Button)item.FindControl("btnvote");

                    btnvote.Visible = true;
                }

            }
        }
    }
}