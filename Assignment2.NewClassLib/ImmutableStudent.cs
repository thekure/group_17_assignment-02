namespace Assignment2.NewClassLib;
public record ImmutableStudent
{
    public int id { get; init;}
    public string ?givenName { get; init;}
    public string ?surname { get; init;}

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
    
    public DateTime startDate { get; init;}
    public DateTime endDate { get; init;}
    public DateTime graduationDate { get; init;}
}
