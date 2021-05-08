/**
* A string is an immutable object. When we have to do some actions to change a string or append a new string, it clears out the old value of the string object, and it creates a new instance in memory to hold the new value in a string object
* StringBuilder is a mutable object. It uses the old object only for any of the operations done to the string and thus increases the performance.
*/
class StringClass
{
    public static void Main(String[] args) {
        StringBuilder val = new StringBuilder("Hello");
        val.Append("World");
        Console.WriteLine(val);
    }
}