class EventExample
{
    public delegate void delegate_OddNumber();
    public event delegate_OddNumber? event_OddNumber;

    public int addition(){
        int num1 = 101, num2=200;
        int result = num1 + num2;
        Console.WriteLine(result);
        if(result %2 !=0 && event_OddNumber !=null){
            //raise event
            event_OddNumber();
        }
        return result;
    }
}