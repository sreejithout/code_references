/**
* An interface is another form of an abstract class that has only abstract public methods. There for the methods don't specify the access modifier.
* and these methods only have the declaration and not the definition.
* 
* A class implementing the interface must have the implementation of all the methods of the interface.
*/

interface IPencil
{
    void Write(string text);
    void Sharpen(string text);
}

interface IPencil2
{
    void Sharpen();
}

class Pencil : IPencil, IPencil2
{
    public void Write(string text)
    {
        //some code here
    }

    // since method named "Sharpen" is in both interfaces,
    // we have to explicitly provide the name of the interface to implement the body of the method.
    public void IPencil.Sharpen(string text)
    {
        //some code here
    }

    public void IPencil2.Sharpen(string text)
    {
        //some code here
    }
}