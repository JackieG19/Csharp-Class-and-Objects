# Classes
- Is a building blockof an application

**Real world example**
- presentation - PointView
- business logic/domain - Post
- date access/persistence - PostRepository

**Anatomy of a Class**
- Data (represented by field)
- Behaviour (represented by methods/functions)

**Naming Conventions**
- Pascal Case
  - Ex. NewObject;
- camel case
  - Ex. newObject;

**Declaring class**
```
public class Person
{
    public string Name;
    
    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name);
    }
}
```
**Object** 
- an instance of a class

**Creating Object**
```
Person person = new Person();

var person = new Person();
```

**Using Object**
```
var person = new Person();
person.Name = "Mosh";
person.Introduce();
```

**Class Members**
```
// Instance: accessible from an object.
var person = new Person();
person.Introduce();

// Static: accessible from an class.
Console.WriteLine();
```

**Declaring Static Members**
```
public class Person
{
    public static int PeopleCount = 0;
}
```
___

# Constructors
- A method that is called when an instance of a class is created
- Its to put an object in an early state

example:
```
public class Customer
{
    public string Name;
    
    public Customer(string Name)
    {
       this.Name = name;
    }
}
```

**Constructors Overloading**
```
public class Customer
{
    public string Name;
    
    public Customer(string Name)
    {
       this.Name = name;
    }
}
```
___
# Object Initializers
- a syntax for quickly initialising an object without the need to call one of its constructors.
- to avoid creating multiple constructors.

```
public class Person
{
  public int Id;
  
  public string FirstName;
  
  public string LastName;
  
  public DateTime Birthdate;
}
```
- creating construtors to initialize the fields
```
public class Person
{
  public Person(int id) {}
  
  public Person(int id, string firstName) {}
  
  public Person(int id, string firstName, string lastName) {}
  
  public Person(int id, DateTime Birthdate) {}
}
```
- initialize a person object
```
var person = new Person
             {
                FirstName = "Jackie";
                LastName = "Gut"
              };
```
