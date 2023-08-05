// Conversion of value type datatype to reference type (object) datatype is called boxing.

// Unboxing is the conversion of reference type datatype to value type.

class Conversion
{
    public void DoBox()
    {
        int i = 10;
        object o = i; // BOXING
    }
    public void DoUnbox()
    {
        object o = 222;
        int i = (int)o; // UNBOXING
    }
}
    