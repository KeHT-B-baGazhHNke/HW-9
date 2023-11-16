using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLab_10
{  
    enum State
    {
        Visible,
        Invisible
    }
    enum Color
    {
        Red,
        Yellow,
        Green
    }
    internal interface ChangeColor
    {
        Color ClrChng(Color color);
    }
    struct Coord
    {
        private int x;
        private int y;
        public int X
        {
            get{return x;}
            set{x = value;}
        }
        public int Y
        {
            get{return y;}
            set{y = value;}
        }
    }
    internal interface Move
    {
        Coord MoveVert(int distance);
        Coord MoveHor(int distance);
    }
    internal interface ChangeState
    {
        State SttChng(State state);
    }
    internal abstract class Figure : Move, ChangeColor, ChangeState
    {
        protected Color color; 
        public Color Color
        { 
            get {return color;} 
        }
        protected State state;
        public State State
        { 
            get{return state;} 
        }
        public Figure(Color color, State state)
        {
            this.color = color;
            this.state = state;
        }

        public abstract Coord MoveVert(int distance);
        public abstract Coord MoveHor(int distance);
        public Color ClrChng(Color new_color)
        {
            color = new_color;
            return color;
        }
        public State SttChng(State new_state)
        {
            state = new_state;
            return state;
        }
        public virtual void Print()
        {
            Console.WriteLine($"\nЦвет фигуры: {color}\nСостояние фигуры: {state}");
        }
    }
    internal class Point : Figure
    {
        protected Coord coordinates;
        public Coord Coord 
        { 
            get {return coordinates;} 
        }
        public Point(Color color, State state, Coord coordinates) : base(color, state)
        {
            this.coordinates = coordinates;
        }
        public override Coord MoveVert(int distance)
        {
            coordinates.Y += distance;
            return coordinates;
        }
        public override Coord MoveHor(int distance)
        {
            coordinates.X += distance;
            return coordinates;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Координаты фигуры: ({coordinates.X}, {coordinates.Y})");
        }

    }internal class Circle : Point
    {
        private double radius;
        public double Radius
        {
            get{return radius;}
        }
        public Circle(Color color, State state, Coord coordinates, double radius) : base(color, state, coordinates)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {radius}\nПлощадь: {Area()}");
        }
    }
    internal class Rectangle : Point
    {
        private double width, height;
        public double Width
        {
            get{return width;}
        }
        public double Height
        {
            get{return height;}
        }
        public Rectangle(Color color, State state, Coord coordinates, double width, double height) : base(color, state, coordinates)
        {
            this.width = width;
            this.height = height;
        }
        public double Area()
        {
            return width * height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Длина: {width}\nВысота: {height}\nПлощадь: {Area()}");
        }

    }
}