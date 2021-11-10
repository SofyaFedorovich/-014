using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_14_Задача

{
    abstract class Animal//абстрактный класс животные
    {
        abstract public string Name { get; set; } // конструктор, устанавливающий название животного по умолчанию
        public string Voice; // звук животного
        public void ShowInfo() //неабстрактный метод
        {
            Console.WriteLine("{0}", Name);
            Say();
        }
        public abstract void Say(); //абстрактный метод, который выводит звук животного
    }
    class Cat : Animal // класс кошка
    {
        string name;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override void Say()
        {
            Console.WriteLine("Животное {0} издает звук: ", Name); 
            Say();
            
        }
    }
    class Dog : Animal // класс собака
    {
        string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void Say()
        {
            Console.WriteLine("Животное {0} издает звук: ", Name);
            Say();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(); //экземпляр класса cat
            cat.Name = "Кошка";

            Dog dog = new Dog(); //экземпляр класса dog
            dog.Name = "Собака";
            Console.ReadLine();
            cat.Say();
            dog.Say();

            Console.ReadKey();
        }
    }
}
