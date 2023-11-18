using System.Security.Cryptography;

class User {
    private string name;
    private string companyName = "Checkred";
    private int age;
    private string City {get;set;}
    public string Name {
        get {return name;}
        set {name = value;}
    }
    public string CompanyName{
        get { return companyName;}
    }
    public int Age {
        get { return Age;}
        set {
            if(value < 18)
                throw new ArithmeticException("Invalid Age");
            else age = value;
        }
    }
}