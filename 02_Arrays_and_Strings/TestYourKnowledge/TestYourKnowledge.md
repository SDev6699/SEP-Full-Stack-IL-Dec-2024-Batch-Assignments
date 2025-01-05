# C# Arrays and Strings FAQs

### 1. When to use `String` vs. `StringBuilder` in C#?
- Use **`String`** when:
    - You are working with a small number of string manipulations.
    - Performance is not a critical factor.
- Use **`StringBuilder`** when:
    - You need to perform numerous modifications (append, insert, replace, etc.) to a string.
    - You want to optimize memory usage and avoid creating multiple immutable string objects.

### 2. What is the base class for all arrays in C#?
- The base class for all arrays in C# is **`System.Array`**.

### 3. How do you sort an array in C#?
- You can use the **`Array.Sort()`** method to sort an array. For example:
  ```csharp
  int[] numbers = { 5, 2, 8, 3, 1 };
  Array.Sort(numbers);
  ```
  After this operation, the `numbers` array will be sorted in ascending order.

### 4. What property of an array object can be used to get the total number of elements in an array?
- Use the **`Length`** property of an array to get the total number of elements. For example:
  ```csharp
  int[] numbers = { 1, 2, 3, 4, 5 };
  Console.WriteLine(numbers.Length); // Outputs: 5
  ```

### 5. Can you store multiple data types in `System.Array`?
- No, a **`System.Array`** is strongly typed and can store only elements of a single data type. If you need to store multiple data types, consider using a collection like **`ArrayList`** or **`List<object>`**.

### 6. What’s the difference between the `System.Array.CopyTo()` and `System.Array.Clone()`?
- **`CopyTo()`**:
    - Copies the elements of the array to an existing array starting at a specified index.
    - Example:
      ```csharp
      int[] sourceArray = { 1, 2, 3 };
      int[] destinationArray = new int[5];
      sourceArray.CopyTo(destinationArray, 2);
      ```
      Here, `destinationArray` becomes `{ 0, 0, 1, 2, 3 }`.
- **`Clone()`**:
    - Creates a shallow copy of the array and returns a new array instance.
    - Example:
      ```csharp
      int[] sourceArray = { 1, 2, 3 };
      int[] clonedArray = (int[])sourceArray.Clone();
      ```
      Here, `clonedArray` is a new array with the same elements as `sourceArray`.
