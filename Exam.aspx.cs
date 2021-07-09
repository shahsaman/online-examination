using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class Exam : System.Web.UI.Page
{
   SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

    private static int counter = 0;
    DataTable dt = new DataTable();
    private int id;
    private String ans;
    int right_ans = 0;
    private static int count = 0;
    private static int confirmCount = 0;
    String sub;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        sub = Session["Subject"].ToString();
        Label2.Text = sub;
        //string name = Session["Name"].ToString();
        //Session["Name"] = name;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Button7.Enabled = false;
        Button6.Enabled = true;
        counter++;
        if (counter > 5)
        {
            con.Open();
            //SqlCommand cmd2 = new SqlCommand("DELETE FROM Que_temp", con);
            //cmd2.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT Opt_Selected,Ans FROM Answer", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int i = 0;
            foreach (DataRow dr in dt1.Rows)
            {
                if (dt1.Rows[i]["Opt_Selected"].ToString() == dt1.Rows[i]["Ans"].ToString())
                {
                    right_ans++;
                }
                i++;
            }
            Session["Right_Answer"] = right_ans;
            counter = 0;
            right_ans = 0;
            //SqlCommand cmd3 = new SqlCommand("DELETE FROM Answer", con);
            //cmd3.ExecuteNonQuery();
            con.Close();
            Session["Subject"] = sub;
            Response.Redirect("Result.aspx");
        }

        RadioButtonList1.Items.Clear();
        SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 5 * FROM " + sub + " WHERE Id NOT IN(SELECT que_id FROM Que_temp) ORDER BY newid()", con);
        da.Fill(dt);
        Label1.Text = dt.Rows[0]["Question"].ToString();
        this.id = Convert.ToInt32(dt.Rows[0]["Id"]);
        this.ans = dt.Rows[0]["Answer"].ToString();
        RadioButtonList1.Items.Add(new ListItem(dt.Rows[0]["Option1"].ToString(), dt.Rows[0]["Option1"].ToString()));
        RadioButtonList1.Items.Add(new ListItem(dt.Rows[0]["Option2"].ToString(), dt.Rows[0]["Option2"].ToString()));
        RadioButtonList1.Items.Add(new ListItem(dt.Rows[0]["Option3"].ToString(), dt.Rows[0]["Option3"].ToString()));
        RadioButtonList1.Items.Add(new ListItem(dt.Rows[0]["Option4"].ToString(), dt.Rows[0]["Option4"].ToString()));

        con.Open();
        SqlCommand cmd = new SqlCommand("INSERT INTO Que_temp VALUES(" + this.id + ")", con);
        cmd.ExecuteNonQuery();
        SqlCommand cmd1 = new SqlCommand("INSERT INTO ANSWER(Que_Id,Que,Opt_Selected,Ans) VALUES(" + this.id + ",'" + Label1.Text + "','0','" + this.ans + "')", con);
        cmd1.ExecuteNonQuery();
        con.Close();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex <= -1)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please Select an Option!!!')", true);
        }
        else
        {
            if (confirmCount == 0)
            {
                Button6.Enabled = false;
                SqlCommand cmd = new SqlCommand("UPDATE Answer SET Opt_Selected=" + (RadioButtonList1.SelectedIndex + 1) + " WHERE Que='" + Label1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Button7.Enabled = true;
                count++;
                switch (count)
                {
                    case 1: Button1.BackColor = Color.Green;
                        break;
                    case 2: Button2.BackColor = Color.Green;
                        break;
                    case 3: Button3.BackColor = Color.Green;
                        break;
                    case 4: Button4.BackColor = Color.Green;
                        break;
                    case 5: Button5.BackColor = Color.Green;
           
                        break;
                    count = 0;
                    default:
                        break;
                }
            }
            else
            {
                Button6.Enabled = false;
                SqlCommand cmd = new SqlCommand("UPDATE Answer SET Opt_Selected=" + (RadioButtonList1.SelectedIndex + 1) + " WHERE Que='" + Label1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Button7.Enabled = true;
                confirmCount = 0;
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        confirmCount = 1;
        display(1);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        confirmCount = 1;
        display(2);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        confirmCount = 1;
        display(3);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        confirmCount = 1;
        display(4);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        confirmCount = 1;
        display(5);
    }


    public void display(int id)
    {
        Button6.Enabled = true;
        SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 * FROM (SELECT TOP " + id + " * FROM Answer ORDER BY Id ASC) T ORDER BY Id DESC", con);
        DataTable dt1 = new DataTable();
        da.Fill(dt1);
        int que_id = Convert.ToInt32(dt1.Rows[0]["Que_Id"].ToString());
        SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM " + sub + " WHERE Id=" + que_id, con);
        DataTable dt2 = new DataTable();
        da1.Fill(dt2);
        RadioButtonList1.Items.Clear();
        Label1.Text = dt2.Rows[0]["Question"].ToString();
        RadioButtonList1.Items.Add(new ListItem(dt2.Rows[0]["Option1"].ToString(), dt2.Rows[0]["Option1"].ToString()));
        RadioButtonList1.Items.Add(new ListItem(dt2.Rows[0]["Option2"].ToString(), dt2.Rows[0]["Option2"].ToString()));
        RadioButtonList1.Items.Add(new ListItem(dt2.Rows[0]["Option3"].ToString(), dt2.Rows[0]["Option3"].ToString()));
        RadioButtonList1.Items.Add(new ListItem(dt2.Rows[0]["Option4"].ToString(), dt2.Rows[0]["Option4"].ToString()));

        if (dt1.Rows[0]["Ans"].ToString() != "0")
        {
            RadioButtonList1.SelectedIndex = Convert.ToInt32(dt1.Rows[0]["Opt_Selected"].ToString()) - 1;
        }
    }
}