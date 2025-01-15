# C# Programming Questions and Answers

## 1. What are the six combinations of access modifier keywords and what do they do?
- **public**: Accessible from anywhere in the application.
- **private**: Accessible only within the containing class.
- **protected**: Accessible within the containing class and by derived classes.
- **internal**: Accessible within the same assembly.
- **protected internal**: Accessible within the same assembly or by derived classes.
- **private protected**: Accessible within the containing class or derived classes in the same assembly.

---

## 2. What is the difference between the `static`, `const`, and `readonly` keywords when applied to a type member?
- **static**: Shared across all instances of the class. It belongs to the type, not any instance.
- **const**: Represents a compile-time constant and cannot be modified after declaration.
- **readonly**: Allows the value to be assigned only during declaration or in the constructor. It can be modified only once per instance.

---

## 3. What does a constructor do?
A constructor initializes an object of a class, setting up initial state or default values.

---

## 4. Why is the `partial` keyword useful?
The `partial` keyword allows a class, struct, or interface to be split across multiple files, improving code organization and collaboration.

---

## 5. What is a tuple?
A tuple is a data structure that groups multiple values into a single object. Each value can have a distinct type. Example: `(int, string) myTuple = (1, "example");`.

---

## 6. What does the C# `record` keyword do?
The `record` keyword defines a reference type primarily used for immutable data. It automatically generates equality members and value-based comparison.

---

## 7. What do overloading and overriding mean?
- **Overloading**: Defining multiple methods with the same name but different parameter lists.
- **Overriding**: Providing a new implementation for a method in a derived class that has the same signature as in the base class.

---

## 8. What is the difference between a field and a property?
- **Field**: A variable directly declared in a class.
- **Property**: Provides controlled access to a class field using `get` and/or `set` accessors.

---

## 9. How do you make a method parameter optional?
By assigning a default value to the parameter. Example: `void MyMethod(int x = 0) { ... }`.

---

## 10. What is an interface and how is it different from an abstract class?
- **Interface**: Defines a contract with only method/property/event declarations. Cannot have implementation.
- **Abstract Class**: Can have method implementations and define default behavior. Can also include fields.

---

## 11. What accessibility level are members of an interface?
All members of an interface are implicitly `public`.

---

## 12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
**True**

---

## 13. True/False. The `override` keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
**True**

---

## 14. True/False. The `new` keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
**True** (but it hides the base class implementation rather than overriding it).

---

## 15. True/False. Abstract methods can be used in a normal (non-abstract) class.
**False**

---

## 16. True/False. Normal (non-abstract) methods can be used in an abstract class.
**True**

---

## 17. True/False. Derived classes can override methods that were `virtual` in the base class.
**True**

---

## 18. True/False. Derived classes can override methods that were `abstract` in the base class.
**True**

---

## 19. True/False. In a derived class, you can override a method that was neither `virtual` nor `abstract` in the base class.
**False**

---

## 20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.
**False**

---

## 21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.
**True**

---

## 22. True/False. A class can have more than one base class.
**False**

---

## 23. True/False. A class can implement more than one interface.
**True**
