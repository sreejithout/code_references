/**
* method overloading is Compile-time polymorphism 
*/ 
public class cellphone
{
        //function with the same name but different parameters.
        public void Typing()
        {
            Console.WriteLine("Using keypad");
        }
        public void Typing(bool isSmartPhone)
        {
            Console.WriteLine("Using qwerty keyboard");
        }
}