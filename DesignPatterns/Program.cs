// See https://aka.ms/new-console-template for more information
using CommanDesignPatterns;

Console.WriteLine("Hello, Command Design Pattern");

//Invoker Invoker = new Invoker();
Calculator cal = new Calculator();
List<ICommand> Commands = new List<ICommand>();

// command1
StartCommand com1 = new StartCommand(cal, 4);
//Commands.Add(com1);
com1.Execute();
Console.WriteLine("The current value of calculator is " + cal.GetValue());

//// command2
AddCommand com2 = new AddCommand(cal, 10);
Commands.Add(com2);
com2.Execute();
Console.WriteLine("The current value of calculator is " + cal.GetValue());

//// command3
SubtractCommand com3 = new SubtractCommand(cal, 12);
Commands.Add(com3);
com3.Execute();
Console.WriteLine("The current value of calculator is " + cal.GetValue());

foreach (ICommand command in Commands)
{
    command.UnExecute();
    Console.WriteLine("The current value of calculator is " + cal.GetValue());
}






