using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_14
{
    class Program
    { //абстрактный класс животные
        abstract class Animal
        {
            private string name; //название животного
            public Animal(string name) //конструктор класса, для значения по умолчанию для названия
            {
                this.name = name;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public abstract string Say();//абстрактный метод, который выводит звук животного
            public virtual void ShowInfo()//метод выводит на консоль название и звук животного
            {
                Console.WriteLine("Название животного - {0}, звук - {1}", name, Say);
               
            }
        }

        class Cat : Animal
        {
            string type, voice;

            public Cat(string type, string voice)
                : base()
        }
        public override void Say()
        {
            base.Say();
            Console.WriteLine("Кошка говорит:{0}", voice);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;



            Console.ReadKey();

        }
    }