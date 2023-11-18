using System.Globalization;
using System.Net;

delegate int CalculateDelegate(int num);
class DelegateExample
{
    static int number = 100;
    public static int addition(int num)
    {
        number =  number + num;
        return number;
    }
    public static int multiplication(int num)
    {
        number =  number * num;
        return number;
    }
    public static int getNumber()
    {
        return number;
    }
}