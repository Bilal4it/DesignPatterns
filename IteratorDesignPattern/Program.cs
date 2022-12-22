// See https://aka.ms/new-console-template for more information
using IteratorDesignPattern;

Console.WriteLine("Hello, World!");

Collection collOfProdcut = new Collection();

for (int i = 0; i < 100; i++)
{ 
    collOfProdcut[i] = new Product() { Id = i, Name = "Product" + i };
}

var itr = collOfProdcut.CreateIterator();

//Console.WriteLine(itr.First());

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(itr.Next());
}

Console.WriteLine(itr.Next());

Console.WriteLine(itr.CurrentProduct);