using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class PracticeResult : System.Web.UI.Page
{
    DataTable dt = new DataTable();

    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

    String sub;

    protected void Page_Load(object sender, EventArgs e)
    {
       
        sub = Session["Subject"].ToString();
        Label61.Text = sub;

        SqlDataAdapter da = new SqlDataAdapter("SELECT Que,Que_Id,Opt_Selected,Ans FROM Answer", con);
        da.Fill(dt);
        Label1.Text = dt.Rows[0]["Que"].ToString();
        Label4.Text = dt.Rows[1]["Que"].ToString();
        Label7.Text = dt.Rows[2]["Que"].ToString();
        Label10.Text = dt.Rows[3]["Que"].ToString();
        Label13.Text = dt.Rows[4]["Que"].ToString();
        

        //To View Option Selected

        SqlDataAdapter da1 = new SqlDataAdapter("SELECT  Option" + dt.Rows[0]["Opt_Selected"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[0]["Que_Id"].ToString(), con);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        Label2.Text = dt1.Rows[0]["Option" + dt.Rows[0]["Opt_Selected"].ToString()].ToString();

        SqlDataAdapter da2 = new SqlDataAdapter("SELECT  Option" + dt.Rows[1]["Opt_Selected"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[1]["Que_Id"].ToString(), con);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);
        Label5.Text = dt2.Rows[0]["Option" + dt.Rows[1]["Opt_Selected"].ToString()].ToString();

        SqlDataAdapter da3 = new SqlDataAdapter("SELECT  Option" + dt.Rows[2]["Opt_Selected"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[2]["Que_Id"].ToString(), con);
        DataTable dt3 = new DataTable();
        da3.Fill(dt3);
        Label8.Text = dt3.Rows[0]["Option" + dt.Rows[2]["Opt_Selected"].ToString()].ToString();
        

        SqlDataAdapter da4 = new SqlDataAdapter("SELECT  Option" + dt.Rows[3]["Opt_Selected"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[3]["Que_Id"].ToString(), con);
        DataTable dt4 = new DataTable();
        da4.Fill(dt4);
        Label11.Text = dt4.Rows[0]["Option" + dt.Rows[3]["Opt_Selected"].ToString()].ToString();

        SqlDataAdapter da5 = new SqlDataAdapter("SELECT  Option" + dt.Rows[4]["Opt_Selected"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[4]["Que_Id"].ToString(), con);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);
        Label14.Text = dt5.Rows[0]["Option" + dt.Rows[4]["Opt_Selected"].ToString()].ToString();

        

        //To View Right Answer Of The Question

        SqlDataAdapter da6 = new SqlDataAdapter("SELECT  Option" + dt.Rows[0]["Ans"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[0]["Que_Id"].ToString(), con);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);
        Label3.Text = dt6.Rows[0]["Option" + dt.Rows[0]["Ans"].ToString()].ToString();

        SqlDataAdapter da7 = new SqlDataAdapter("SELECT  Option" + dt.Rows[1]["Ans"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[1]["Que_Id"].ToString(), con);
        DataTable dt7 = new DataTable();
        da7.Fill(dt7);
        Label6.Text = dt7.Rows[0]["Option" + dt.Rows[1]["Ans"].ToString()].ToString();
        
        SqlDataAdapter da8 = new SqlDataAdapter("SELECT  Option" + dt.Rows[2]["Ans"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[2]["Que_Id"].ToString(), con);
        DataTable dt8 = new DataTable();
        da8.Fill(dt8);
        Label9.Text = dt8.Rows[0]["Option" + dt.Rows[2]["Ans"].ToString()].ToString();

        SqlDataAdapter da9 = new SqlDataAdapter("SELECT  Option" + dt.Rows[3]["Ans"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[3]["Que_Id"].ToString(), con);
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);
        Label12.Text = dt9.Rows[0]["Option" + dt.Rows[3]["Ans"].ToString()].ToString();

        SqlDataAdapter da10 = new SqlDataAdapter("SELECT  Option" + dt.Rows[4]["Ans"].ToString() + " FROM " + sub + " WHERE Id=" + dt.Rows[4]["Que_Id"].ToString(), con);
        DataTable dt10 = new DataTable();
        da10.Fill(dt10);
        Label15.Text = dt10.Rows[0]["Option" + dt.Rows[4]["Ans"].ToString()].ToString();



    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("DELETE FROM Answer", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}

