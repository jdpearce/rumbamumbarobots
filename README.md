Rumba Mumba Robots
===

This repository contains some simple code (and tests) to solve the following problem. I may revisit this at some point, but this represents a few hours work. My current windows dev machine is a clunky Windows XP VM running on my Macbook Pro and for internet I'm leeching from the local coffee shop, so it may not be *soon*.

The Problem
===

Rumba Mumba Robots is a company that creates cleaning robots. We create the software for the robots and we buy the hardware. We have a contract with the hardware provider that is an interface, and a Hardware Fake class for testing.
 
Our robots always work in rectangular rooms, without obstacles. Always start in the top left corner (coordinates x=0, y=0), pointing to the east (FaceTo = 0). Our robot has a sensor to detect if it has a wall in front of it (IsObstacle()=true).
 
You have this pseudo code algorithm to clean the room:
1) Rotate left.
2) If there isn’t an obstacle and the robot was never there, walk.
3) If not, rotate right.
4) If there isn’t an obstacle and the robot was never there, walk.
3) If not, rotate right.
4) If there isn’t an obstacle and the robot was never there, walk.
3) If not, the room is cleaned.
 
After cleaning the room, you need to return to the top left corner as fast as you can.
 
At the end, you need to print the path that you use to clean the room (all the cells used, in the order that has been cleaned) and the total number of movements the robot has used (printing the property TotalMovements)
 
 
REQUIREMENTS
1)      Implement the cleaning algorithm.

2)      Implement the return algorithm.

3)      Both algorithms need to be easily interchangeable.

4)      The software mustn’t be coupled with the hardware, and this hardware needs to be easily interchangeable.

5)      After cleaning the room, we need to know the path used and the total movements.

 
CLARIFICATIONS
1)      You must use the class Hardware provided. You must not implement the interface or your own hardware class.

2)      As the Hardware class is a fake class, it needs the size of the room (i.e. 4x5) in the constructor. You need to pass this information to the constructor, but you mustn’t use this information in your class.

3)      Use TDD only if you’re comfortable using it. Focus on the design and the implementation.

4)      Clean code and good naming are positives.

5)      The robot doesn’t remember the path.  

6)      Don’t worry about the GUI. You can use a Console Application, Test Classes or whatever you need. 
