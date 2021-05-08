/**
* Delegates are like function pointers. 
* It is a reference data type that holds the reference of a method. 
* We use delegates to write generic type-safe functions. 
* All delegates derive from System. Delegate.
* Delegates have a signature as well as return type. A function assigned to delegates must be fit with this signature.
* Delegates can point to instance methods or static.
* Delegate objects, once created, can dynamically invoke the methods it points to at runtime.
* Delegates can call methods synchronously and asynchronously.
*/

/**
* Single Delegate: Single Delegate can invoke a single method.
* Multicast Delegate: 
    - Multicast delegates can invoke multiple methods. 
    - The delegate method can do multicasting. 
    - We can add a method in the delegate instance using + operator, and we can remove a method using – operator. 
    - All the methods are invoked in sequence as they are assigned.
*/

class DelegateClass
{
    // declare delegate
    public delegate void Print(int value);
    
    static void Main(string[] args)
    {
        SingleDelegate();
        MulticastDelegate();
    }

    public static void SingleDelegate() 
    {
        // Print delegate points to PrintNumber
        Print printDel = PrintNumber;
        // or
        // Print printDel = new Print(PrintNumber);
        printDel(100000);
        printDel(200);

        // Print delegate points to PrintMoney
        printDel = PrintMoney;
        printDel(10000);
        printDel(200);
    }

    public static void MulticastDelegate()
    {
        Print printNumDel = PrintNumber;
        Print printMonDel = PrintMoney;
        // MultiCast Delegate
        Print multiPrintDel = printNumDel + printMonDel;
        multiPrintDel(100);        
        multiPrintDel = printNumDel - printMonDel;
        multiPrintDel(100);
    }

    public static void PrintNumber(int num)
    {
        Console.WriteLine("Number: {0,-12:N0}", num);
    }
    public static void PrintMoney(int money)
    {
        Console.WriteLine("Money: {0:C}", money);
    }
}