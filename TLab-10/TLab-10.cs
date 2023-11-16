using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TLab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Упражнение 10.1\nВведите текст, который нужно зашифровать: ");
            string text = Console.ReadLine();
            ACipher acipher_text = new ACipher(text);
            BCipher bcipher_text = new BCipher(text);
            Console.WriteLine($"\nШифр A" +
                $"\nЗашифрованный текст: {acipher_text.Encode()}" +
                $"\nРасшифрованный текст: {acipher_text.Decode()}" +
                $"\nШифр B" +
                $"\nЗашифрованный текст: {bcipher_text.Encode()}" +
                $"\nРасшифрованный текст: {bcipher_text.Decode()}");

            Console.WriteLine("\nДомашнее задание 10.1");
            Coord coord = new Coord();
            coord.X = 0;
            coord.Y = 0;
            Point point = new Point(Color.Red, State.Visible, coord);
            point.Print();
            point.MoveVert(1);
            point.MoveHor(4);
            point.Print();
            int radius = 8;
            Circle circle = new Circle(Color.Yellow, State.Invisible, coord, radius);
            circle.Print();
            double width = 8;
            double height = 8;
            Rectangle rectangle = new Rectangle(Color.Green, State.Visible, coord, width, height);
            rectangle.Print();
            Console.ReadKey();
        }
    }
}