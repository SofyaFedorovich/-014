﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_14

    {
    abstract class Animal
{
    public string Name;
    public string Type;

    public void ShowInfo()
    {
        Console.WriteLine("{0}. {1}", Type, Name);
    }
}
    class PetShop
    {
    List<Animal> pets = new List<Animal>();

    public void AddPet(Animal animal)
    {
        pets.Add(animal);
    }

    public void Say()
    {
        foreach (var p in pets)
            p.ShowInfo();
    }
    }
    class Dog : Animal
    {
    public Dog(string name, string type)
        : base()
        {
        Name = name;
        Type = type;
        }
    }
    class Cat : Animal
    {
    public Cat(string name, string type)
        : base()
    {
        Name = name;
        Type = type;
    }
    }
    class Program
    {
    static void Main(string[] args)
    {
        PetShop petshop = new PetShop();
        petshop.AddPet(new Dog("Звук-Гав", "Животное собака"));
        petshop.AddPet(new Cat("Звук-Мяу", "Животное кошка"));
        petshop.Say();
        Console.ReadLine();
    }
    }
}

