Animal d = new Dog();
Console.WriteLine(d.speak());

internal class Animal
{
    public virtual string speak() { return "silence"; }
}

class Cat : Animal
{
    public override string speak() { return "meow"; }
}

class Dog : Animal
{
    public override string speak() { return "bow-wow"; }
}

