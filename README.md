# OneStream Assessment
### Animals

Given the following:

```
class Animal
{
  public virtual string speak(int x) { return "silence"; }
}

class Cat : Animal
{
  public string speak(int x) { return "meow"; }
}

class Dog : Animal
{
  public string speak(short x) { return "bow-wow"; }
}
```
Question: Outline any issues/concerns with the implemented code and explain why the block below does not emit “bow-wow”:

```
Animal d = new Dog();
Console.Write(d.speak(0));
```

### Answer
1. The ```Animal``` class specifies parameter ```x```, which is not used and should be removed.
2. The ```Cat``` class derives from ```Animal```, but it does not implement the virtual function. The solution is to add the ```override``` keyword to the function implementation.
3. The ```Dog``` class derives from ```Animal```, but it does not implement the virtual function. The solution is to add the ```override``` keyword to the function implementation.
4. The ```Dog``` class uses a parameter of type ```short``` which does not match the type used in ```Animal```. The solution is to remove the parameter from all three classes (see #1).
5. Remove the parameter passed in ```Console.Write(d.speak(0))```.

