using System;
using System.Text;
using System.Collections.Generic;

namespace HelloWorld
{
    interface function
    {
        public void info();
        public void assess();
    }
    abstract class Human : function
    {
        protected string name;
        protected int old;
        protected float height, weight;
        static int count = 0;
        public Human(string n, int o, int h, int w)
        {
            name = n;
            old = o;
            height = h;
            weight = w;
            count++;
        }
        public abstract void info();
        public void assess()
        {
            if (old < 25 || old > 18)
                Console.WriteLine("Luot");
            else
                Console.WriteLine("Khong ngon lam");
        }

        public static int GetCount()
        {
            return count;
        }

    }
    class Nomal : Human
    {
        public Nomal(string n, int o, int h, int w) : base(n, o, h, w) { }
        public override void info()
        {
            Console.WriteLine("Nomal-> Name: {0} Old: {1} Height: {2} Weight: {3}", name, old, height, weight);
        }

    }
    class Model : Human
    {
        private string[] achievements;
        public Model(string n, int o, int h, int w, string[] a) : base(n, o, h, w) { achievements = a; }
        public override void info()
        {
            Console.WriteLine("Model-> Name: {0} Old: {1} Height: {2} Weight: {3}", name, old, height, weight);
            foreach (var item in achievements)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human[] nguoi = new Human[2];
            string[] achivements = { "Xinh nhat lop", "Gioi thu hai lop" };
            nguoi[0] = new Model("Trang", 19, 165, 52, achivements);
            nguoi[1] = new Nomal("Bac", 19, 165, 60);
            foreach (var item in nguoi)
            {
                item.info();
                item.assess();
            }
            Console.WriteLine(Human.GetCount());
        }
    }

}