class Calculation 
{
    public void divide(int num1, int num2){
        int result = 0;
        try{
        result = num1 / num2;
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        finally {
            Console.WriteLine(result);
        }
    }

    public void divideAnother(){
        int num1, num2, result = 0;
        try{
        Console.Write("Enter num1: ");
        num1 = int.Parse(Console.ReadLine());  
        Console.Write("Enter num2: ");
        num2 = int.Parse(Console.ReadLine());  
        result = num1 / num2;
        }
        catch(DivideByZeroException ex){
            Console.WriteLine(ex.Message);
        }
        catch(FormatException ex){
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
        finally {
            Console.WriteLine(result);
        }
    }
}