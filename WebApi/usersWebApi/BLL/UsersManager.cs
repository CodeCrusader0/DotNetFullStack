namespace BLL;
using BOL;
using DAL.Disconnected;
using System.Collections.Generic;

public class UsersManager
{

    public static List<Users> GetAllUsers()
    {

        List<Users> list = DBManager.GetUsers();
        return list;
    }

    public static List<Users> GetUser(int id)
    {

        List<Users> list = DBManager.GetUser(id);
        return list;
    }

     public static List<Users> DeleteUser(int id){
        
        List<Users> list =DBManager.DeleteUser(id);
        return list;
    }

    public static void InsertUser(string name,string addr){
        
        DBManager.InsertUser(name,addr);
    }
}
