// See https://aka.ms/new-console-template for more information
using AdapterDesignPattern.Internal;

Console.WriteLine("Hello, World!");

Rectangle rec = new Rectangle();
rec.X1 = 1;
rec.Y1 = 2;
rec.X2 = 10;
rec.Y2 = 5;

Console.WriteLine(rec.Area());