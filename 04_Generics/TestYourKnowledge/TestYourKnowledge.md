Q1: Describe the problem generics address. 
Answer:
Generics address the need for type-safe collections and methods that can work with any data type
without the overhead of boxing/unboxing. They help catch type errors at compile-time rather than
runtime and promote code reuse by avoiding the need to write multiple versions of the same class
or method for different data types.

Q2: How would you create a list of strings, using the generic List class?
Answer:
List<string> myStrings = new List<string>();

Q3: How many generic type parameters does the Dictionary class have?
Answer:
The Dictionary class has two generic type parameters: Dictionary<TKey, TValue>.

Q4: True/False. When a generic class has multiple type parameters, they must all match.
Answer:
False. Each type parameter can be a different type.

Q5: What method is used to add items to a List object?
Answer:
Use the Add method:
myList.Add(item);

Q6: Name two methods that cause items to be removed from a List.
Answer:
- Remove(item)
- RemoveAt(index)

Q7: How do you indicate that a class has a generic type parameter?
Answer:
You use angle brackets (< >) after the class name. For example:
public class MyClass<T>
{
// ...
}

Q8: True/False. Generic classes can only have one generic type parameter.
Answer:
False. Generic classes can have multiple type parameters, for example MyClass<T1, T2>.

Q9: True/False. Generic type constraints limit what can be used for the generic type.
Answer:
True. For example:
public class MyClass<T> where T : IComparable
{
// ...
}
This constraint requires T to implement IComparable.

Q10: True/False. Constraints let you use the methods of the thing you are constraining to.
Answer:
True. If you constrain T to a particular base class or interface, you can safely call its
members on T.