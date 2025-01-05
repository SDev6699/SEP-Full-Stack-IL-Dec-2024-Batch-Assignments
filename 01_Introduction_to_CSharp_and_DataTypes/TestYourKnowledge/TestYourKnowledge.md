# Controlling Flow and Converting Types

## Test Your Knowledge

### 1. What happens when you divide an int variable by 0?
- Dividing an `int` variable by 0 causes a runtime exception: `ArithmeticException` with the message "/ by zero."

### 2. What happens when you divide a double variable by 0?
- Dividing a `double` variable by 0 does not throw an exception. Instead, it results in:
    - `Infinity` if the numerator is positive.
    - `-Infinity` if the numerator is negative.
    - `NaN` (Not a Number) if the numerator is 0.

### 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
- If an `int` variable overflows, it wraps around to the minimum or maximum value of the `int` type. This is called integer overflow.
    - Example: `Integer.MAX_VALUE + 1` results in `Integer.MIN_VALUE`.

### 4. What is the difference between `x = y++;` and `x = ++y;`?
- `x = y++;`
    - Post-increment: The current value of `y` is assigned to `x`, and then `y` is incremented by 1.
- `x = ++y;`
    - Pre-increment: `y` is incremented by 1 first, and then the updated value of `y` is assigned to `x`.

### 5. What is the difference between `break`, `continue`, and `return` when used inside a loop statement?
- `break`
    - Exits the loop entirely, skipping all remaining iterations.
- `continue`
    - Skips the current iteration and proceeds to the next iteration.
- `return`
    - Exits the loop and the method in which the loop is contained, returning a value (if specified).

### 6. What are the three parts of a `for` statement and which of them are required?
- Three parts of a `for` statement:
    1. Initialization (optional)
    2. Condition (required)
    3. Increment/Update (optional)
- Only the condition is required for the loop to execute. The others can be omitted.

### 7. What is the difference between the `=` and `==` operators?
- `=`
    - Assignment operator: Assigns the value on the right-hand side to the variable on the left-hand side.
- `==`
    - Equality operator: Compares two values for equality and returns a boolean result.

### 8. Does the following statement compile? `for ( ; true; ) ;`
- Yes, it compiles. This creates an infinite loop because the condition `true` is always satisfied, and there are no statements in the loop body.

### 9. What does the underscore `_` represent in a switch expression?
- The underscore `_` acts as the default case in a switch expression, matching any value that hasn’t been matched by earlier cases.

### 10. What interface must an object implement to be enumerated over by using the `foreach` statement?
- An object must implement the `IEnumerable` interface (or `IEnumerable<T>` for generic collections) to be enumerated using the `foreach` statement.
