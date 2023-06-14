using System;

namespace LibraryManagementSystem;

public abstract class Person
{
    public string? Name { get; set; }
    private int ID;

    public Person(string name, int ID)
    {
        Name = name;
        SetID(ID);
    }

    private void SetID(int ID)
    {
        this.ID = ID;
    }

    public abstract void DoSomething();
}