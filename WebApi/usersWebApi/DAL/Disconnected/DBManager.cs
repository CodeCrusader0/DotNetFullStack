namespace DAL.Disconnected;
using BOL;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


public class DBManager
{

    public static string conString = @"server=localhost;port=3306;user=root;
    password=root;database=dotnetdb";

    public static List<Users> GetUsers()
    {

        List<Users> list = new List<Users>();
        MySqlConnection conn = new MySqlConnection(conString);

        try
        {
            conn.Open();
            string query = "Select * from users";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                int id = int.Parse(row["id"].ToString());
                string name = row["name"].ToString();
                string addr = row["addr"].ToString();

                Users user = new Users(id, name, addr);
                list.Add(user);
            };



        }


        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return list;
    }

    public static List<Users> GetUser(int id1)
    {

        List<Users> list = new List<Users>();
        MySqlConnection conn = new MySqlConnection(conString);

        try
        {
            conn.Open();
            string query = "Select * from users where id=" + id1;
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                int id = int.Parse(row["id"].ToString());
                string name = row["name"].ToString();
                string addr = row["addr"].ToString();

                Users user = new Users(id, name, addr);
                list.Add(user);
            };



        }


        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return list;
    }

    public static List<Users> DeleteUser(int id1)
    {

        List<Users> list = new List<Users>();
        MySqlConnection conn = new MySqlConnection(conString);

        try
        {
            conn.Open();
            string query = "Delete from users where id=" + id1;
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                int id = int.Parse(row["id"].ToString());
                string name = row["name"].ToString();
                string addr = row["addr"].ToString();

                Users user = new Users(id, name, addr);
                list.Add(user);
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return list;
    }

     public static void InsertUser(Users user)
    {

        
        MySqlConnection conn = new MySqlConnection(conString);

        try
        {

            //
            conn.Open();
            string query = $"Insert into users (name,addr) values ('{user.Name}','{user.Addr}')";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(ds);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}