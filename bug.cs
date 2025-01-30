public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that might not be initialized yet
        Console.WriteLine(MyProperty); 
    }
}