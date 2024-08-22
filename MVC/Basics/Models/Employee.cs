namespace Basics.Models
{
  public class Employee{

    public int Id {get;set;}
    public String Firstname {get;set;}=String.Empty;
    public String LastName {get;set;}=String.Empty;
    public String FullName => $"{Firstname} {LastName.ToUpper()}";

   public int Age {get; set;}


  }

}