public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int value = MyProperty; // Accessing the property
        // ... some code
        int newValue = value + 10; // Modify a local variable 
        MyProperty = newValue; // Modifying the property
        // ... more code
        value = MyProperty; // Accessing the property again (now reflects the change)
    }
}