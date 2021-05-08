/**
 * We use the "static" keyword to create a static class, a static method, or static properties.
 * When we create a static class, then there can be only static data members and static methods in that class.
 * Static means that we cannot create the instance of that class. That class can be used directly like ClassName.methodName.
 * When there is a need for special functions, which are typical for all the instances of other classes, then we use static class.
 * we can't use "this" in static class
 */

 public static class Setting
{
    public static int fetchDefault()
    {
        int maxAmount = 0;
        //code to fetch and set the value from config or some file.
        return maxAmount;
    }
 }

public class Sales
{
      //not required to create an instance.
      int maxAmount = Setting.fetchDefault();
}