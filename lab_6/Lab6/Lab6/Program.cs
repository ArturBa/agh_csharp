using System;
using System.Collections.Generic;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merry xmas!");
            ChristmasTree xmasTree = new ChristmasTree();
            xmasTree.Add(Color.blue, Shape.ball);
            Console.WriteLine("Bauble color: {0}", xmasTree[0]);
            Console.WriteLine("Baubles in color ({0}): {1}", Color.blue, xmasTree[Color.blue]);
            xmasTree[0] = Color.yellow.ToString();
            Console.WriteLine("Color changed");
            Console.WriteLine("Bauble color: {0}", xmasTree[0]);

            ChristmasTreeA xmasTreeA = new ChristmasTreeA();
            xmasTreeA.Add(Color.blue, Shape.ball);
            Console.WriteLine("ChristmasTreeA");
            Console.WriteLine("Bauble shape: {0}", xmasTreeA[0]);
            Console.WriteLine("Bauble shape: {0}", ((ChristmasTree) xmasTreeA)[0]);

            ChristmasTreeB xmasTreeB = new ChristmasTreeB();
            xmasTreeB.Add(Color.blue, Shape.ball);
            Console.WriteLine("ChristmasTreeB");
            Console.WriteLine("Bauble: {0}", xmasTreeB[0]);
            Console.WriteLine("Bauble: {0}", ((ChristmasTreeA) xmasTreeB)[0]);
        }
    }

    class Tree
    {
        string name;
        int age;
    }
    class Fir : Tree
    {
        protected class Bauble
        {
            public Color color { get; set; }
            public Shape shape { get; protected set; }
            
            public Bauble(Color c, Shape s)
            {
                color = c;
                shape = s;
            }
        }

    }
    enum Color
    {
        blue,
        green,
        yellow
    }
    enum Shape
    {
        star,
        ball
    }

    class ChristmasTree  : Fir
    {
        protected List<Bauble> baubles;
        
        public ChristmasTree()
        {
            baubles = new List<Bauble>();
        }

        public void Add(Color color, Shape shape)
        {
            Bauble bauble = new Bauble(color, shape);
            baubles.Add(bauble);
        }
        public void Remove(int index)
        {
            baubles.RemoveAt(index);
        }

        public virtual string this[int index] {
            get => baubles[index].color.ToString();
            set => baubles[index].color = (Color) Enum.Parse(typeof(Color), value, true);
        }
        public virtual int this[Color color] {
            get => baubles.FindAll(bouble => bouble.color == color).Count;
        }
    }

    class ChristmasTreeA: ChristmasTree
    {
        public override string this[int index]
        {
            get => baubles[index].shape.ToString();
        }

        public string BaubleColor(int index)
        {
            return base[index];
        }
    }

    class ChristmasTreeB : ChristmasTreeA {
        public new string this[int index]
        {
            get
            {
                Bauble b = baubles[index];
                return b.color.ToString() + "_" + b.shape.ToString();
            }
        }
    }

    sealed class ChristmasTreeC: ChristmasTreeB
    {

    }

    abstract class Home
    {
         protected abstract int Price();
    }
}
