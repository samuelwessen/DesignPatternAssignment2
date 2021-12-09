using StateCommandMemento.Command;
using StateCommandMemento.Memento;
using StateCommandMemento.State;
using System;

namespace StateCommandMemento
{
    class SCMMain
    {
        static void Main(string[] args)
        {
            var machine = new Machine();
            var commandManager = new CommandManager(machine);
            MachineMemento machineMemento = machine.CreateMemento();

            Console.WriteLine("State Command Memento");
            Console.WriteLine("----------------------");
            Console.WriteLine("A: Turning Machine On/Off");
            Console.WriteLine("B: Input command strings");
            Console.WriteLine("C: Reset and turn off");
            Console.WriteLine("X: Quit Program");

            while (true)
            {
                var userInput = Console.ReadKey().KeyChar;
                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine("");
                        machine.PowerSwith();
                        foreach (var command in machine.CommandList)
                        {
                            commandManager.Action(command.InputCommand);
                        }
                        machine.CommandList.Clear();
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("");
                        Console.WriteLine("Enter a command");
                        var inputCommand = Console.ReadLine();
                        commandManager.Action(inputCommand);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("");
                        Console.WriteLine("Reseting commands and turning off");
                        machineMemento.ResetMachine();
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("");
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Not a valid choice");
                        break;
                }
            }
        }
    }
}
