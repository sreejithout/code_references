/**
* destructor clears up the memory to free up resources
* It is managed automatically by the garbage collector.
* System.GC.collect() is called internally for this purpose. 
* However, if required, it can be done explicitly using a destructor.
*/
public class Purchase
{         
    //Syntax to write a destructor.         
    ~Purchase()         
    {             
    //code here to release resources.
    }
}