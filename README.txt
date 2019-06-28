Toy Robot Simulator:

IDE: Visual Studio 2017. 
Language: C#
Framework: .net
Technology: Asp.net Core

There are two projects:
1)ToyRobot
2)ToyRobotTests 

ToyRobot is the main projetct, And ToyRobotTests has some unit tests. 

There is a console Iterface available, but with some assumptions that PLACE command is Entered in the format "PLACE x,y,direction".
PLACE X,Y,DIRECTION
MOVE
LEFT
RIGHT
REPORT.

Here are the Test Data for commands:
a)
PLACE 0,0,NORTH
MOVE
REPORT

b)
PLACE 0,0,NORTH
LEFT
REPORT

c)
PLACE 1,2,EAST
MOVE
MOVE
LEFT
MOVE
REPORT

To build the project in visual studio go to  menubar=>view=>SolutionExplorer=>rtClick=>Build.
To Run the Tests in Vusual Studio go to menubar=>Test>Run=>All Teasts.
To Run the given inteface in Visual Studio, on the top simply run it.
To run in command line cd to the path => ToyRobot\ToyRobot\bin\Debug\netcoreapp2.2
and use the command => dotnet ToyRobot.dll.

 
