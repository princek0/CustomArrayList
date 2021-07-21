# CustomArrayList

An array list implementation made in C# with OOP.

- In computer science, a dynamic array, growable array, resizable array, dynamic table, mutable array, or array list is a random access, variable-size list data structure that allows elements to be added or removed. It is supplied with standard libraries in many modern mainstream programming languages. Dynamic arrays overcome a limit of static arrays, which have a fixed capacity that needs to be specified at allocation. 

  <sup>Source: Wikipedia.</sup>
- The array list uses a zero-based indexing system i.e the first item is at index 0. 
- There is an Examples.cs file and what is contained is fairly self-explanatory.

This is just meant to be a little project as I slowly learn C#.

Methods
--------
- .ToString() -> Outputs the array list.
- .Append(item) -> Adds an item to the end of the array list. 
- .Contains(item) -> Returns True or False if the array list contains a given item or not respectively. 
- .IndexOf(item) -> Uses linear seatch to return the index of a given item if it is present else it returns null.
- .Insert(item, index) -> Inserts a given item at a given index and returns True or False if the task was successful or not respectively. 
- .RemoveAt(index) -> Removes the item at a given index and returns True or False if the task was successful or not respectively. 
- .Remove(item) -> Removes a given item and returns True or False if the task was successful or not respectively.
- .Size() -> Returns the number of items in the array list. 
