public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int value = MyProperty; // Accessing the property
        // ... some code
        MyProperty = value + 10; // Modifying the property
        // ... more code
        value = MyProperty; // Accessing the property again
    }
}