namespace Assignment2.NewClassLib;
public class Student
{
    public int id { get; init;}
    public string ?givenName { get; set;}
    public string ?surname { get; set;}

    public Status status {get{
        var now = DateTime.Now;
       // Nu er tidligere end start:
        if (now <= startDate){
            return Status.New;
        } else if(now > startDate && now < endDate){  // Nu er senere end start, og tidligere end end
            return Status.Active;
        } else if(now > endDate && endDate < graduationDate){   // Nu er senere end end, men end er tidligere end grad
            return Status.Dropout;
        } else return Status.Graduate;
    }}
    
    public DateTime startDate { get; set;}
    public DateTime endDate { get; set;}
    public DateTime graduationDate { get; set;}


    public override string ToString(){
        return $"ID: {id}, Given Name: {givenName}, Surname: {surname}, Status: {status}";
    }
}
    
public enum Status{
        New, Active, Dropout, Graduate
}
