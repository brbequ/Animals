// Question: Outline any issues/concerns with the implemented code and explain why the block below does not emit “bow-wow”:
//
// The issues include:
// - The override keyword is required when implementing a virtual function
// - There Dog implementation uses short x, and there is no virtual function with a matching
// - The parameter x serves no purpose and has been removed.
//

Animal d = new Dog();
Console.WriteLine(d.speak());

internal class Animal
{
    public virtual string speak() { return "silence"; }
}

// Animals

class Cat : Animal
{
    public override string speak() { return "meow"; }
}

class Dog : Animal
{
    //
    public override string speak() { return "bow-wow"; }
}

