namespace BOL;

public class Users{
    public int Id{get;set;}
    public string Name{get;set;}
    
    public string Addr{get;set;}
    
    public Users(int id,string name,string addr){
        Id=id;
        Name=name;
        Addr=addr;
    }

    public override string ToString()
    {
        return this.Id+" "+this.Name+" "+this.Addr;
    }
} 