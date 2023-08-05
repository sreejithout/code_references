/**
* The class derived from the abstract class must have an implementation of it's abstract methods.
* We can never instantiate an object from an abstract class
* Abstract class can have the following in them (not necessary)
    * constructors or destructors
    * virtual methods
    * abstract methods
    * abstract properties
    * normal methods and properties with any access modifiers
*/


// Abstract class
abstract class Animal
{
  // Abstract method (does not have a definition / body)
  public abstract void animalSound();

  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}