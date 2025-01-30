# Uninitialized Property Access in C#

This example showcases a potential issue in C# when accessing properties that haven't been assigned a value before use.  Uninitialized properties will have their default values (0 for integers, null for reference types, etc.).  This can lead to unexpected behavior in your program if you're not careful.

**Problem:** The `MyProperty` is used in `MyMethod()` without first being given an explicit value.  This results in the default value (0) being printed.

**Solution:** Initialize the `MyProperty` within the constructor, or explicitly assign a value before accessing it in `MyMethod()`.