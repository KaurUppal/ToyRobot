using System;

namespace ToyRobot
{
    class Program
    {
        private static void PlaceConsole(CommandFunctions command,string placeDetails)
        {
            
            string[] placeArray = placeDetails.Split(" ");
            string[] otherValues = placeArray[1].Split(",");
            int x ,y;
            int.TryParse(otherValues[0], out x);
            int.TryParse(otherValues[1], out y);
            EnumFaces direction = (EnumFaces)Enum.Parse(typeof(EnumFaces), otherValues[2]);
            command.Place(x, y, direction);
        }
        private static void Commands(String command, CommandFunctions commandFunctions)
        {
            switch (command.ToUpper())
            {
                case "MOVE":
                    commandFunctions.Move();
                    break;
                case "LEFT":
                    commandFunctions.Turn(commandFunctions.CurrentFace, EnumTurn.LEFT);
                    break;
                case "RIGHT":
                    commandFunctions.Turn(commandFunctions.CurrentFace, EnumTurn.RIGHT);
                    break;
                case "REPORT":
                    commandFunctions.Report();
                    break;
                default:
                    PlaceConsole(commandFunctions, command);
                    break;
            }
        }

        static void Main(string[] args)
        {
            CommandFunctions command = new CommandFunctions();  
            Console.WriteLine("------------------------Wecome To Toy Robt!---------------------\n");
            Console.WriteLine("Please Place the Robot to Start.....The Commande Format is: PLACE X,Y,DIRECTION\n");
            Console.WriteLine("Conditions: X and Y value can be 0 to 4 and DIRECTION can be NORTH,WEST,SOUTH,EAST\n");
            Console.WriteLine("Please Enter the PLACE command with its correct format\n");
            Console.WriteLine("Please Place the Robot: ");
            while (true)
            {
                Console.WriteLine("Enter the command");
                var result = Console.ReadLine();
                Commands(result, command);
            }
            
        }
    }
}
