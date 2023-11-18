using System.Net;
using Microsoft.VisualBasic.FileIO;

public delegate void PrintMessage(string message);
class AnonymousMethodExample {
    public static void InvokeMethod(){
        PrintMessage printMessage = delegate(string message)
        {
            Console.WriteLine("Message: "+ message);
        };
        printMessage("Hello world");
    }
}