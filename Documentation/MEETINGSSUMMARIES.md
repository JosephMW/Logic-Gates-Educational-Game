# Meetings Summaries

This file contains summaries of all the advisor meetings throughout the course of my project.

[Link back to README](../README.md)

## 01/10/21 - Weekly Supervisor Meeting
What we spoke about:
*	My idea of the project:
    +	Have a very user-friendly UI
    +	Use Drag-and-drop components
    +	Allow user to build components (As a means of abstraction)
    +	Allow user to manually draw wires (Like train-tracks)
    +	Stretch Goals for my project:
        -	Tutorial Overlay that guides a pupil to build something
        -	Use levels which accumulate to a student having a complex circuit
    +	Technologies I will use:
        -	Unity (C#)
        -	GitHub
        -	VS Code
*	What we want from the project:
    +	Have a relatively polished item that you can use when talking to school pupils about the university

Goals for next time:
*	Consolidate Technologies
*	Begin learning Unity
    +	Ideally get a start on the project – perhaps a grid with drag-and-drop items
*	Set up dev tools such as GitHub
*	Set up documentation and share it with Chris McCaig

<br><br>

## 08/10/21 - Weekly Supervisor Meeting
Progress I’ve made:
*	Created private GitHub which you now have access to
    +	https://github.com/JosephMW/Logic-Gates-Educational-Game
*	Created 2D Unity project
*	Written some very minor C# in Unity to make a start (Part of the grid-layout system)
*	Using Mendeley as a reference manager
*	Wrote Documentation that can be found on GitHub:
    +	Daily Logs
    +	Meeting Summaries
    +	Exported .bib references file from my private Mendeley.
    +	Issue Tracking & Branching Strategy
*	Did general research into Unity.

Project Board after the first week:
![Project Board after the first week.](ProjectBoardImages/EndOfWeek-4-10-21.png)
 
 
What we spoke about:
*	The progress I have made (found above)
*	Whether weekly/biweekly retrospectives could be beneficial
    +	Concluded yes
*	Whether User Testing could be beneficial, and worth the bother of ethics etc.
    +	Concluded yes. I would not be working with under 16s and it would be voluntary and non-dangerous so the ethics process would be simple. 
*	My goals for the next week (found below)
 
Goals for next time:
*	Complete my 2 ongoing issues
    +	Create a grid area for drag-and-drop purposes [#9](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/9)
    +	Implement drag-and-drop functionality on top of this grid area [#8](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/8)
*	Create a placeholder component for the drag-and-drop
*	Begin work on the wire system
    +	Get placeholder image for them
    +	Allow the placing of wires on the grid
    +	Allow wires to connect to each other
    +	Allow wires to connect to components?

Project Board for the next week:
![Project Board for the next week.](ProjectBoardImages/StartOfWeek-11-10-21.png)

## 14/10/21 - Weekly Supervisor Meeting
Progress I’ve made:
*	Completed my CustomGrid, which has the following functionality:
    +   Renders a 2D grid of partially separated squares.
    +   Takes 3 params: width, height, cellSize.
    +   Linear transformation takes the grid and ensures the center of the grid aligns with the game plane.
*   Made progress with Drag-and-Drop:
    +   I now have the functionality of being able to drag-and-drop a component on screen.
    +   I still need to have a dropped sprite snap into position on the CustomGrid which sits behind.
 
What we spoke about:
*	The progress I have made (found above)
*   The struggles I have had with development
    +   I don't have wifi in my flat yet which is slowing things.
    +   I need to learn the key Unity Architecture and styles of coding before continuing
        -   It has become clear there are styles of programming in Unity, you can instantiate components, or use AddComponent and give reference to other GameObjects. I need to learn the key details in these approaches and become consistent for the rest of the project. We both expect issues will arise if I try to combine different approaches. 
*	My goals for the next week (found below)
 
Goals for next time:
*   Learn about Unity Architecture, and using AddComponent etc to avoid directly instantiating classes via constructors.
*	Complete Drag-and-Drop
    +   Have sprites snap into position on the grid.
*   Complete other outstanding issues on the Project Board
    +   Wire System: Get Placeholder Image
    +   Wire System: Allow the placing of wires on the grid
    +   Wire System: Allow wires to connect to each other
    +   Wire System: Allow wires to connect to components

**KEY DECISION** *At this point in the project I felt confusion as to how I organised my work. I had decided to use week-long sprints at the beginning as I thought it would work well with weeekly meetings - however I failed to consider that weekly supervisor meetings may not always occur on the same day and same time. Therefore, I cannot ensure that a supervisor meeting always occurs at the end of a sprint. I now realise I need a concrete start and end to each sprint, and supervisor meetings will have to sometimes occur mid-sprint.*
*We now have three things which occur weekly: My sprints; My supervisor meetings; The university 'Weeks'. In order to save confusion over these three different things I have decided to organise my sprints to align with the university 'Weeks' - that being start on Monday and end on Sunday. My Supervisor meetings will just occur when my supervisor is available.*

## 20/10/21 - Weekly Supervisor Meeting
Progress I’ve made:
*	Completed Drag-and-Drop functionality:
    +   I now have the functionality of being able to drag-and-drop a component and have a dropped sprite snap into position on the CustomGrid which sits behind.
*	Began work on Wire System
    +   I have a prefab for a Wire.
    +   I have begun working on the logic for a wire
    +   I have decided to first build a simple version of the wires and later polish them.

What we spoke about:
*	The progress I have made (found above)
*	How important testing is in my project
    +   Should definitely do some, but doesn’t need to be huge.
    +   I will write C# tests for the logic.
*	My goals for the next week (found below)

Goals for next time:
*	Complete the rudimentary wire system. This involves:
    +   Use straight line wires
    +   Connect circuit to circuit visually
    +   Connect circuit to circuit logically (Allow data to be passed from one circuit to another after a wire has been set up)
*	Start writing some C# tests.
*	If I accomplish the above tasks then I will consider adding placeholder input and outputs for the circuits
    +   This could be a button you toggle to select 0 or 1 for the input.
    +   Output could be a light which is lit if it recieves a 1, or off if it recieves a 0.

