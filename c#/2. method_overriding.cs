/**
* method overriding is Run-time polymorphism 
*/ 
public class CellPhone
{
    // marking this method virtual. This will enable us to override the method in child class
    public virtual void Typing()
    {
        Console.WriteLine("Using keypad");
    }
    
    public void Normal()
    {
        Console.WriteLine("Normal method in parent");
    }
}
public class SmartPhone : CellPhone
{
    // method override         
    public override void Typing()
    {
        Console.WriteLine("Typing function from child class");
    }
    
    // calling the overrided method
    public void LocalMethod()
    {
        Typing();
    }
    
    // calling the original method from the base class
    public void ParentMethod()
    {
        base.Typing();
    }
    
    // calling a normal method in base class, which cannot be overrided in child class.
    public void NormalMethod()
    {
        Normal();
    }
}