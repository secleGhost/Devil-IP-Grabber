using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
public partial class _Default : System.Web.UI.Page
{
    public string Ip;
    public string User;
    public string Agent;
    public string[] Use;
    public string language;
    protected void Page_Load(object sender, EventArgs e)
    {
        Ip = Request.UserHostAddress;
        User = Request.Browser.ToString();
        Agent = Request.UserAgent;
        Use = Request.UserLanguages;
        foreach(string a in Use)
        {
            language = a;
        }
        SqlConnection sql;
        string conexion;
        //change your connection method for yours example @"Data Source=www.yoursql.com;Initial Catalog=db_database_yourdatabase;User Id=db_your_user_admin;Password=YOUR_PASSWORD"
        conexion = @"Data Source=www.yoursql.com;Initial Catalog=db_database_yourdatabase;User Id=db_your_user_admin;Password=YOUR_PASSWORD";
        sql = new SqlConnection(conexion);
        sql.Open();
        //add the name of your columns add the name of your columns from your database
        SqlCommand sqlCommand = new SqlCommand("INSERT INTO [base](ip,browser,agent,language) values(@IP,@BROWSER,@AGENT,@LANGUAGE)", sql);//here
        sqlCommand.Parameters.AddWithValue("@IP", Ip);
        sqlCommand.Parameters.AddWithValue("@BROWSER", User);
        sqlCommand.Parameters.AddWithValue("@AGENT", Agent);
        sqlCommand.Parameters.AddWithValue("@LANGUAGE", language);
        sqlCommand.ExecuteNonQuery();
        sql.Close();


    }
}