using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_14_Задача

{
    abstract class Animal//абстрактный класс животные
    {
        public Animal (string name, string voice)
        {
            Name = name;
            Voice = voice;            
        }
        
        abstract public string Name { get; set; } // конструктор, устанавливающий название животного по умолчанию
        public string Voice; // звук животного
        public void ShowInfo() //неабстрактный метод
        {
            Console.WriteLine("{0}.{1}", Name, Voice);
        }
        public abstract void Say(); //абстрактный метод, который выводит звук животного
    }
    class Cat : Animal // класс кошка
    {
        string name;      
        public Cat(string name, string voice)
            : base(name,voice)
        {
            this.Name = name;
            this.Voice = voice;
        }
        public override string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public override void Say()
        {
            Console.WriteLine("Животное {0} издает звук: {1}", Name, Voice);
        }
    }
    class Dog : Animal // класс собака
    {
        string name;
        public Dog(string name, string voice)
          : base(name,voice)
        {
             this.Name = name;
            this.Voice = voice;
        }
        public override string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public override void Say()
        {
            Console.WriteLine("Животное {0} издает звук: {1}", Name, Voice);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка", "Мяу"); //экземпляр класса cat
            Dog dog = new Dog("Собака", "Гав"); //экземпляр класса dog
            Console.ReadLine();
            cat.Say();
            dog.Say();
            
            Console.ReadKey();
        }
    }
}
