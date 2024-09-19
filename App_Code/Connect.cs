using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Connect
/// </summary>
public class Connect
{
    //פעולה שמחזירה את הנתב של מסד הנתונים 
    public string GetConnectionString()
    {
        //נתיב יחסי
        string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        return str;
    }

    public DataSet GetData(string strsql, string tablename)
    {
        //יצירת DATASET
        DataSet ds = new DataSet();
        //מחרוזת התחברות 
        string myConnection = GetConnectionString();
        //התבחרות
        SqlConnection con = new SqlConnection(myConnection);
        //אוביקט ביצוע 
        SqlCommand cmd = new SqlCommand(strsql,con);
        //יצירת מתאם 
        SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
        //ADAPTER ממלא את הDATASET
        adapter.Fill(ds, tablename);
        return ds;
    }


    public int InsertUpdateDelete(string strsql)
    {

        //מחרוזת התחברות 
        string myConnection = GetConnectionString();
        //התבחרות
        SqlConnection con = new SqlConnection(myConnection);
        //אוביקט ביצוע 
        SqlCommand cmd = new SqlCommand(strsql, con);

        con.Open();
        int restult = cmd.ExecuteNonQuery();
        con.Close();
        return restult;



    }


    public object GetObject(string strsql)
    {
        //מחרוזת התחברות 
        string myConnection = GetConnectionString();
        //התבחרות
        SqlConnection con = new SqlConnection(myConnection);
        //אוביקט ביצוע 
        SqlCommand cmd = new SqlCommand(strsql, con);
        
        //פתיחת החיבור למסד הנתונים 
        con.Open();

        //פעולה שמבצעת שאילתא מתמטית שמחזירה את התוצאה של השאילתה 
        object obj = cmd.ExecuteScalar();
        //סגירת החיבור למסד הנתונים
        con.Close();
        //מחזיר את האוביקט
        return obj;

    }
}