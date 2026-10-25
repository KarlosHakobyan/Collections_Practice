# C# Collections & Core Fundamentals Practice

A comprehensive C# practice repository demonstrating the implementation and usage of core .NET fundamentals, generic collections, standard interfaces (`IEnumerable`, `IComparable`, `ICloneable`), custom dictionary structures, and linear collections (`Queue` and `Stack`).

## 📂 Project Structure & Architecture

The project is structured into logical namespaces inside the `Collections` solution:

### 1. Enumerable, Clonable & Comparable (`Collections.Generics.EnumerableClonableComparable`)
* **`Player`**: Represents a player entity implementing:
  * `IComparable<Player>` — handles custom sorting logic by score (descending order).
  * `ICloneable` — provides an exact deep/shallow copy mechanism (`Clone`).
  * Overridden `ToString()` method for clear, formatted object output.
* **`Team`**: A custom collection class wrapping an internal `List<Player>` and implementing **`IEnumerable<Player>`** using `yield return`, allowing direct iteration via `foreach`.
* **`CodeLauncher`**: Entry point orchestrating the simulation of player creation, sorting, iteration, and cloning verification.

### 2. Dictionaries (`Collections.Generics.Dictionaries`)
* **`PhoneBook`**: Manages nested dictionaries (`Dictionary<string, Dictionary<string, List<string>>>`) to group contacts by categories, names, and multiple phone numbers. Includes insertion, lookup, and display logic.
* **`PhoneBookSorted`**: Uses `SortedDictionary` counterparts to maintain automatically sorted keys by groups and names.
* **`DictionaryTesterCode`**: Tests standard and sorted phonebook implementations.

### 3. Generics (`Collections.Generics`)
* **`Box<T>`**: A generic container class implementing `IEnumerable<T>` to store items of any type dynamically, featuring helper methods to input, retrieve, and display container states.
* **`GenericsTesterCode`**: Exercises the generic `Box` class using different types (`string` and `int`), handling console input parsing and verification.

### 4. Queue & Stack (`Collections.Generics.QueueStack`)
* **`QueueStack`**: Implements printer workflow simulations:
  * **`Queue<string>`**: Manages documents waiting to be printed in FIFO (First-In, First-Out) order.
  * **`Stack<string>`**: Tracks printing history using LIFO (Last-In, First-Out) semantics.

---

