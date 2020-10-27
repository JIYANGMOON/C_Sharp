using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Dog zzong = new Dog("mix", 3, "gray");
            Dog janggoon = new Dog("jindo", 2, "black");

            //////////////////////////////////////////////////////////////////

            Cat miro = new Cat("miro", "M", 2, "black");
            Cat navi = new Cat("navi", "F", 1, "yellow");

            miro.name = "som";
            miro.setColor("white");

            miro.cry();
            miro.play();

            Console.WriteLine(miro.name);
            Console.WriteLine(miro.getColor());
            Console.WriteLine(navi.sex);
            Console.ReadLine();
        }
    }
    class Cat
    {
        public string name;
        public string sex;
        private int age;
        private string color;
        public Cat(string cName, string cSex, int cAge, string cColor)
        {
            name = cName;
            sex = cSex;
            age = cAge;
            color = cColor;
        }
        public void setAge(int cAge) { age = cAge; }
        public int getAge() { return age; }
        public void setColor(string cColor) { color = cColor; }
        public string getColor() { return color; }

        public void cry()
        {
            Console.WriteLine("Cat Crying");
        }
        public void play()
        {
            Console.WriteLine("Cat Play");
        }
        
    }
    class Dog
        {
            public string race;
            public int old;
            public string furColor;
            public Dog(string sRace, int iOld, string sFur)
            {
                race = sRace;
                old = iOld;
                furColor = sFur;
            }

            public void setRace(string sRace)
            {
                race = sRace;
            }

            public string getRace()
            {
                return race;
            }
            ~Dog()
            {

            }
        }
}
