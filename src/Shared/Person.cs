using System;

namespace LibrarySystem;

public abstract class Person
{
    public string? Name { get; set; }
    private int _ID;

    public Person(string name, int ID)
    {
        Name = name;
        SetID(_ID);
    }

    private void SetID(int ID)
    {
        this._ID = ID;
    }

    public abstract void DoSomething();
}

