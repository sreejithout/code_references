/**
* Constant variables have to be assigned a value at the time of declaration only, and we cannot further change it's value.
* We can assign the value to the read-only variable at the time of declaration or in a constructor of the same class
*/
class DemoClass
{
    // Constant fields 
    public const int myvar = 101;
    
    // readonly variables 
    public readonly int myvar1;

    public DemoClass(int x){
        myvar1 = x;
    }

    // Main method 
    static public void Main()
    {
        // Display the value of Constant fields 
        Console.WriteLine("The value of myvar: {0}", myvar);
        Console.WriteLine("The value of myvar1: {0}", myvar1);
    }
}