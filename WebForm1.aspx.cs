using System;
using System.Data;
using System.Data.SqlClient;

namespace temp2
{
    //connected data architecture
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TANMAY\source\repos\temp2\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select * from stud", con);
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into stud values("+ Convert.ToInt32(TextBox1.Text) +",'"+ TextBox2.Text +"','"+ TextBox3.Text +"')",con);
            SqlCommand cmd1 = new SqlCommand("select * from stud", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Inserted succesfully!!!";
            SqlDataReader dr = cmd1.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from stud where roll=("+ Convert.ToInt32(TextBox1.Text)+")", con);
            SqlCommand cmd1 = new SqlCommand("select * from stud", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Deleted succesfully!!!";
            SqlDataReader dr = cmd1.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            con.Close();
        }
    }
}