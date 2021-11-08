using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_14
{
    //абстрактный класс животные
    abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo();//метод выводит на консоль название и звук животного
        
    }
    class Cat : Animal
    {
        public string Voice { get; set; }
        public Cat(string name, string voice)
            :base(name)
        {
            Voice = voice;
        }
        public override void Say()
        {
            return Voice;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Животное { Name} издает звук: {Say}");

        }

    }
    class Dog : Animal
    {
        public string Voice { get; set; }
        public Dog(string name, string voice)
            : base(name)
        {
            Voice = voice;
        }
        public override void Say()
        public override void ShowInfo()
        {
            Console.WriteLine($"Животное { Name} издает звук: { Voice}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка", "Мяу");//экземпляр класса Cat
            Dog dog = new Dog("Собака", "Гав");//экземпляр класса 
            Console.WriteLine(cat.ShowInfo());
            Console.WriteLine(dog.ShowInfo());

            Console.ReadKey();
        }
    }
}

/*public string Name { get; set; }//название животного

 public abstract void Say();//абстрактный метод, который выводит звук животного
 public void ShowInfo()//метод выводит на консоль название и звук животного
 {
     Console.WriteLine("Название животного - {0}, звук - {1}", Name);
     Console.WriteLine("Звук животного - {0}", Say);
 }
}
class Cat : Animal
{
 string name;
 string voice;
 public override void Say (string voice)
 {
     return voice;
 }
 public override void ShowInfo()
 {
     Console.WriteLine("Название животного - {0}" , Name);
 }


public string name;  // название животного
public Animal(string name) //конструктор класса, для значения по умолчанию для названия
{
    this.name = Name;
}
public string Name
{
    get { return name; }
    set { name = value; }
}
public abstract void Say();//абстрактный метод, который выводит звук животного
public void ShowInfo()//метод выводит на консоль название и звук животного
{
    Console.WriteLine("Название животного - {0}", name);
}
}

class Cat : Animal
{
string voice;

public Cat(string voice)
    : base(name);

}
public override void Say()
{
base.Say();
Console.WriteLine("Кошка говорит:{0}", voice);
}*/

