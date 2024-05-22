namespace PacktLibraryNetStandard2;
using Packt.Shared;
using System.Collections.Generic;

internal class JaroClassTest
{
    Person Jaro = new Person();
    Person Jaro2 = new();

    List<Person> Jars = new(); 
    public List<int> myints = new List<int>();

    
    void Calc()
    {
        myints.Clear();
        Jars.Add(Jaro);
    }

    private static void StaticCalc() //like <Main>$ method!
    {
        Person person1 = new Person();
        Person person2 = new Person();

        List<Person> people = new List<Person>();
        people.Add(person1);

    }



}
