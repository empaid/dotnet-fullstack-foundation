partial class Employee
{
    public Employee(){
        EmpId = 1;
        EmpName = "N/A";
    }
    public partial void DisplayDetails(){
        Console.WriteLine("Id: " + EmpId + " Name: " + EmpName);
    }
}