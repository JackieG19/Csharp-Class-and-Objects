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
