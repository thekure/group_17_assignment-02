using System;

namespace Assignment2.NewClassLib;
public class Student
{
    public int id { get; init;}
    public string ?givenName { get; set;}
    public string ?surname { get; set;}
    
    public DateTime startDate { get; set;}
    public DateTime endDate { get; set;}
    public DateTime graduationDate { get; set;}


    public override string ToString(){
        return $"ID: {id}, Given Name: {givenName}, Surname: {surname}, Status: ";
    }
    

   //  DateTime start, DateTime end, DateTime graduation
    public Status getStudentStatus(DateTime start, DateTime end, DateTime grad){
        Comparator c = datesCompared;
       
       // Nu er tidligere end start:
        if (c(start) < 0){
            return Status.New;
        }

        // Nu er senere end start, og tidligere end end
        if(c(start) >= 0 && c(end) < 0){
            return Status.Active;
        }

        // Nu er senere end end, men end er tidligere end grad
        if(c(end) > 0 && DateTime.Compare(end, grad) < 0){
            return Status.Dropout;
        }

        else return Status.Graduate;        
    }
    int datesCompared (DateTime toBeCompared) => DateTime.Compare(DateTime.Now, toBeCompared);
    delegate int Comparator (DateTime toBeCompared);


}
    


public enum Status{
        New, Active, Dropout, Graduate
}
