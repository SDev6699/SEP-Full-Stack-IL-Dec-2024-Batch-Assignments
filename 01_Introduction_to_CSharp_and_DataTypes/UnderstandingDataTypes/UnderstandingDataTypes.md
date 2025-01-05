# Understanding Data Types

## 1. Choosing Data Types for Given Scenarios

| Scenario | Data Type | Explanation |
|----------|-----------|-------------|
| A person’s telephone number | `string` | Telephone numbers may contain leading zeros and special characters like '+', '-', etc. |
| A person’s height | `float` or `double` | Height can have decimal values. |
| A person’s age | `int` | Age is a whole number. |
| A person’s gender | `enum` | Using an enumeration for predefined categories like Male, Female, Prefer Not To Answer. |
| A person’s salary | `decimal` | `decimal` is suitable for financial calculations to avoid floating-point precision errors. |
| A book’s ISBN | `string` | ISBNs contain hyphens and may start with zero. |
| A book’s price | `decimal` | Suitable for financial amounts. |
| A book’s shipping weight | `double` | Can have decimal values. |
| A country’s population | `long` | Large numbers require a type that can handle big integers. |
| The number of stars in the universe | `long` | Extremely large number, use `long` or even `BigInteger` if necessary. |
| The number of employees in SMBs in the UK | `int` | Since the maximum is 50,000, `int` is sufficient. |

## 2. Value Types vs Reference Types

- **Value Types:**
    - Stored on the stack.
    - Hold the actual data.
    - Examples: `int`, `float`, `struct`, `enum`.

- **Reference Types:**
    - Stored on the heap.
    - Hold a reference to the data.
    - Examples: `class`, `array`, `string`, `delegate`.

### **Boxing and Unboxing**

1. **Boxing:** Converting a value type to a reference type (`object`).

   **Example:**

    ```csharp
    int num = 123;
    object obj = num; // Boxing
    ```

2. **Unboxing:** Converting a reference type back to a value type.

   **Example:**

    ```csharp
    object obj = 123;
    int num = (int)obj; // Unboxing
    ```

3. **Managed vs Unmanaged Resources in .NET**

  - **Managed Resources**
    - Handled by the .NET runtime's garbage collector.
    - Examples include objects created from classes.

  - **Unmanaged Resources**
    - Not handled by the garbage collector.
    - Examples include file handles, database connections, and unmanaged memory.

4. **Purpose of Garbage Collector in .NET**

   The Garbage Collector (GC) automatically manages memory by:

  - **Allocating memory** for new objects.
  - **Reclaiming memory** occupied by objects that are no longer in use, preventing memory leaks.
  - **Managing the lifecycle** of objects to optimize memory usage.
