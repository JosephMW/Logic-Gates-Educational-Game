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

## 27/10/21 - Weekly Supervisor Meeting
Progress I’ve made:
*	Created Circuit prefab
*	Created Switch prefab (This is used as input to the circuit)
*	Created Light prefab (This is used as output for the circuit)
*	Created Wire system which works visually and logically – we can now join components using wires and pass signals through the circuit.

What we spoke about:
*	The progress I have made (found above)
*	It may be worthwhile keeping consistent notes of how elements work as I write them – perhaps a short readme on each component?
*	Could be worth reading some academic literature on relevant projects.
*	The difficulties in which keeping state could introduce
    +   If we give the user the ability to create custom reusable circuits, how do we do this?
        -   Purely combinational circuits could be easily stored as a look-up-table
        -   If we allow state (flip flops) then a look-up-table wouldn’t work.
*	My goals for the next week (found below)

Goals for next time:
1.	Complete final details surrounding Wire System:
    +   Ability to disconnect a previously connected wire.
    +   Have a wire retract to its start point if when dragged you do not connect it to anything.
2.	Start writing tests:
    +   Ideally run these in GitHub Actions (Or a similar system) to test each branch before merging.
    +   These tests will cover the C# logic I am writing
3.	Create multiple input circuits:
    +   Create a real functioning And2 circuit.
    +   Create other circuits if I have time, perhaps: Or2, Xor2, Inv, etc.

![Project Board status on 27/10/21](ProjectBoardImages/EndOfWeek-25-10-21.png)

## 03/11/21 - Weekly Supervisor Meeting
Progress I’ve made:
1.	Wires which are not connected to input ports now retract to where they started
2.	You can now disconnect wires
3.	Wires position correctly when connected to input ports now
4.	I have created the And2 circuit
    +   This circuit takes 2 inputs
    +   Has 1 output
    +   Output is equal to (input1 && input2)

What we spoke about:
*	The progress I have made (found above)
*	Reading the marking scheme carefully could benefit me – so I know I am working well.
*	We discussed the workload of a joint-honours student on this project.
*	My goals for the next week (found below)

Goals for next time:
*	Make it so when dragging a circuit with connected wires, those wires move appropriately.
*	Add CI/CD Pipeline and some tests.
*	Refactor some code.
    +   Extract parent class for Circuit, And2Circuit, DisplayLight. 
*	If I complete the above in time then work on adding a toolbar which allows the user to spawn premade components.

![Project Board status on 03/11/21](ProjectBoardImages/projectBoard-03-11-21.png)

**KEY DECISION** *As visibile in the above screenshot, I decided to add a fifth column to my project board. This column is 'Outside of Sprint' and will be used to hold issues which are not currently being worked on but are future work.*

## 10/11/21 - Weekly Supervisor Meeting
Progress I’ve made:
*	I have set up the Unity Test Runner which allows me to test my Unity components in live scenes – allowing testing which is closer to playing the game.
*	I have written a set of tests for my And2Circuit which run in a live scene.
*	I have refactored Circuit, And2Circuit, and DisplayLight to using a parent class which defines almost all behaviour for these classes.
    +   This proved more complex than previously anticipated as I decided to refactor a good chunk of the code. My new version is now much more extensible and should allow me to create almost any circuit I would like easily – up to holding state.
    +   Creating new combinational circuits such as Or-gates, larger and-gates, mux, demux, inv, etc should now be trivial.
*	I have made progress on a CI/CD pipeline however it is proving difficult
    +   I have a GitHub action set up (This is just a script which runs on every push to a branch and every pull request)
    +   I have the Unity Test Runner GitHub Action mostly setup but it fails before the tests can execute. 
        -   The technology I am using for this is relatively new so there are few forums about it/there isnt much documentation. This is why it is proving difficult.

What we spoke about:
*	The progress I have made (found above)
*	We discussed how we would store a custom circuit which a user has designed
    +   We could generate a truth table from it
        -   Seems very reasonable 
        -   Stores the circuit in a compact way
        -   Does not allow circuits to have state (Flip flops)
    +   We could try to save the entire circuit and somehow give it input and recieve its output
        -   Unsure as to how this would be implemented – needs research.
        -   Stores the circuit in a less compact way
        -   Allows circuits to have state (Flip flops) – this is a big positive.
*	My goals for the next week (found below)

Goals for next time:
*	Finish CI/CD pipeline
*	Make dragging a circuit adjust the position of any connected wires.
*	Fix the small bug surrounding disconnecting wires.
*	Start work on the overlay/toolbar which allows the user to spawn new components.

![Project Board status on 10/11/21](ProjectBoardImages/projectBoard-10-11-21.png)

## 24/11/21 - Weekly Supervisor Meeting
Progress I have made:
*	I have added that when circuits are dragged which have connected wires, those connected wires move appropriately to stay connected
    +   This involved some useful refactorings I had been meaning to do anyways.
*	I fixed the bug I had previously mentioned about difficulty when disconnecting wires
    +   This was due to overlapping colliders, so when you clicked it didn’t know which you were referring to
*	I fixed 2 more minor bugs I found
    +   When we disconnected an ‘ON’ wire, we were previously failing to reset the state to ‘OFF’
    +   When we connected a new wire we were failing to immediately send the value signal in some cases
*	I created the Toolbar which allows you to spawn GameObjects into the world. I added the 4 objects I have made so far to this toolbar

What we spoke about:
*	The progress I have made (found above)
*	We discussed the 3 main future avenues of work:
    +   Improve UI 
        -   I will definitely do this
        -   It is not imminent and may suit being completed near the end of my development phase
    +   User Created Circuits
        -   May cause complications if I also implement ‘Circuits which can hold state’
    +   Circuits which can hold State
        -   May cause complications if I also implement ‘User Created Circuits’
*	My goals for the next week (found below)

Goals for next time:
*	Investigate and Fix bug we discovered where inputPorts do not accept wire connections in certain cases.
*	Finish CI/CD pipeline
*	Research and decide on which of the following two issues I should prioritise for future work.
    +   User Created Circuits
    +   Circuits which can hold state

![Project Board status on 24/11/21](ProjectBoardImages/projectBoard-24-11-21.png)

## 14/12/21 - Weekly Supervisor Meeting
Progress I have made:
*	I have fixed the bug we found together in our last meeting
    +   The problem was due to the wire overlapping multiple input ports causing difficulties
    +   It was a problem as I developed the wire-inputPort code when only considering single wire and input ports, then when I added new circuits with multiple input ports it could not properly handle things.
    +   This lead me to rethinking some of how wire-inputPort connections are made, it is all fixed and safe now.
*	I have added a new markdown documentation page to my GitHub. It outlines the logic behind the main components in my game. I decided to do this as it took me a little time to read and remember how wire connections are made, I also figure it will help when writing my thesis.
*	I have also given more thought to where my future work should be placed and I think custom circuits should be my priority over the xmas break. If I can find a way to save full circuits instead of saving a condensed version I may be able to save circuits which have state – and this would be the optimal solution.

What we spoke about:
*	The progress I have made (found above)
*	The Christmas break and our first meeting back (12 Jan 9:30am)
*	That the project progress report is brief and due Friday.
*	That I will be emailing to try and get some students for testing next semester
*	That I will submit the ethics paperwork soon
*	My goals for the next week (found below)

Goals for next time:
*	Start work on building and saving custom circuits
*	Finish CI/CD pipeline

![Project Board status on 14/12/21](ProjectBoardImages/projectBoard-14-12-21.png)

## 12/01/22 - Weekly Supervisor Meeting
Progress I have made:
*	I have written introductory and debriefing scripts for my Testing Session week which will be in week 4 of this semester.
*	I have asked Jose Cano Reyes to email the class of Computer Architecture to ask for some students to help me.
*	I have researched more into saving and loading in Unity.
    +   The main goal I had that we discussed last term was to be able to save and load custom circuits for reuse.
    +   I have decided that a good intermediate goal is to learn how to save and load whole scenes in Unity. This will allow me to save the scene where the student is playing and reload it. I believe this will be less complicated than diving directly into trying to do the circuit builder stuff.

What we spoke about:
*	The progress I have made (found above)
*	That an early very rough draft of a dissertation is valuable.
*	What my motivations for the project were (How I aimed to do things better than my competition)
    +   Nicer UI – more attractive for students
    +   Being able to build and reuse custom circuits
*	My goals for the next week (found below)

Goals for next time:
*	Learn and implement saving and loading whole scenes in Unity.
*	Build a main menu which allows the user to reload scenes, or start new ones.
*	Still have finish CI/CD pipeline as an ongoing issue

![Project Board status on 12/01/22](ProjectBoardImages/projectBoard-12-01-22.png)

## 12/01/22 - Weekly Supervisor Meeting
Progress I have made:
*	I have created a basic main menu for the game
*	I have created a basic options menu for use in-game
*	I have the rough layout for a ‘Load Game’ menu
*	I have also begun work on the ‘Load Game’ functionality however it is proving more difficult than anticipated.
    +   I have discovered there is a lack of an easy saving system in Unity. Instead I need to serialize all the objects I wish to save, and then save their Json representation.
    +   I have begun work on the Json serialization. 
    +   I have also begun reading about a Json.NET package which may be more useful for my case.
*	I have also recieved a reply from Jose Cano Reyes recommending I message the Computer Architecture class through Teams instead of him emailing
    +   I will do this this week.

What we spoke about:
*	The progress I have made (found above)
*	Starting a basic rough draft of dissertation and slowly adding to it is valuable
    +   I will start it this week
*	Packages which are just minor help and don’t replace your project are fine
    +   I am considering using the Json.NET package – although likely wont use it
*	We spoke about my Json Serialization ongoing task and how it may follow on to saving individual reusable circuits
    +   I think my serialization will hold all the required information for saving reusable circuits
    +   I would likely need to create custom classes which mirror all my circuits and then join these up
*	My goals for the next week (found below)

Goals for next time:
*	Complete my Json Serialization Save method
*	Build a method for re-instantiating my saved Json files
*	Add the above method to a more refined ‘Load Game’ menu
*	Begin a very very rough draft of my dissertation
*	Message Computer Architecture students through Teams about Student Testing Session

![Project Board status on 19/01/22](ProjectBoardImages/projectBoard-19-01-22.png)

## 26/01/22 - Weekly Supervisor Meeting
Progress I have made:
*	I have sent a message to the Computer Architecture Teams asking for volunteers for my Testing session.
*	I have created a Latex Overleaf file for my dissertation and created a very rough outline of my dissertation. I have added my Bibtex bibliography to this too.
*	I have completed my method for creating Json serializations which have all necessary info for reinstantiation. I am also now saving these Json serializations correctly.
*	I have added a text input box for naming your save slots – this has not been connected up yet.
*	I have a crude method for reinstantiation of circuits now.
    +   It reinstantiates all circuits as “PassThrough” Circuits at the moment – this was done for simplicity while I wrote the rest of the code.
    +   It doesn’t join wires yet.
    +   This took me a while to figure out as I had a tricky problem with Unity asynchronously loading the next scene and not having an easy way to await this change. This meant my reinstantiated circuits were not appearing etc.

What we spoke about:
*	The progress I have made (found above)
*	The dissertation outline I created
    +   It looks good for now
    +   Add section on Educational Games
*	My goals for the next week (found below)

Goals for next time:
*	Extend my Json reinstantiation method to work with all circuit types.
*	Extend my Json reinstantiation method to link all wires.
*	Extend my saving system so you can provide custom save names – allowing multiple save slots.
*	If I have time, begin work on saving reusable circuits.

![Project Board status on 26/01/22](ProjectBoardImages/projectBoard-26-01-22.png)

## 02/02/22 - Weekly Supervisor Meeting
Progress I have made:
*	I have recruited 2 students for my testing session (I can ask friends to help as well if nobody else volunteers)
*	I have extended my Json serialization to allow loading of all circuit types
*	I have extended my Json loading system to uniquely renumber all wires and ports and then perform all linking of these wires.
*	I have refactored my switch class for consistency and to allow it to be loaded easily
*	I have added custom naming of game saves
*	I have added a scrollable game save menu which automatically populates
    +   This means I can load any game save which exists now.

What we spoke about:
*	The progress I have made (found above)
*	How I should plan how I’ll anonymize student testing session data
    +   Likely via an encrypted excel document in my Office 365 student account
*	How I should focus on making the game very usable and ironing out bugs etc before the testing session
    +   This means starting work on reusable custom circuits will be delayed
*	My goals for the next week (found below)

Goals for next time:
*	Prepare for Student Testing sessions which will be in week beginning 7th Feb
    +   Plan how I’ll run the sessions
    +   Plan how I’ll anonymize data
*	Add to dissertation draft
*	Add Documentation on the whole Load/Save process
*	Make Game more usable
    +   Alter the background grid to sit more nicely in frame
    +   Make menus clearer/simpler
    +   Add more logic gates so the students can make the circuits they want to
*	Plan/Think about reusable circuits if I have time.

**KEY DECISION** *At this point in the project I realised that the issues which sat in the 'Outside of Sprint' column of my project board had been left untouched for months. I realised that the goals of my project and the design of it had changed enough to mean that these issues were no longer useful. I decided to archive these issues unclosed and delete the 'Outside of Sprint' column. My work typically follows on from the previous sprint very nicely and so this column was of no use.*

![Project Board status on 02/02/22](ProjectBoardImages/projectBoard-02-02-22.png)

## 08/02/22 - Weekly Supervisor Meeting
Progress I have made:
*	Added Documentation on the whole Load/Save process
*	Added a little bit more to the dissertation
*	Delayed my Student Testing Sessions to next week (Due to me testing positive for covid last week)
*	Worked on the UI in preparation for the Student Testing Sessions
    +   Refactored the toolbar spawner as a scrollable list that’s automatically populated from files.
    +   Added more base logic gates
    +   Reshaped the grid to fit the screen properly
    +   Improved Main Menu design (Still a work in progress)

What we spoke about:
*	The progress I have made (found above)
*	I explained that my Student Testing Sessions are delayed a week due to me getting covid.
*	Gave brief feedback on the small additions to my dissertation
*	Discussed increasing work on dissertation since the final hand-in is 25th March
*	My goals for the next week (found below)

Goals for next time:
*	Prepare for Student Testing sessions which will be in the week beginning 14th Feb
*	Keep adding to dissertation draft
*	Finish tidying the UI before Student Testing Sessions
*	Carry out the Student Testing Sessions
*	Write up the Student Testing Sessions in an anonymised way
*	Start work on saving reusable custom circuits

![Project Board status on 09/02/22](ProjectBoardImages/projectBoard-09-02-22.png)

## 23/02/22 - Weekly Supervisor Meeting
Progress I have made:
*	Further Improved the UI colours and general feel
*	Added ‘Splitter Gates’ which I realised would be crucial for the student testing session.
*	Fixed a bug where you could drop a circuit in the top left where the options cog is.
*	Fixed a major bug I found where the filesystem completely failed once built
    +   Unity reorders the filesystem when building so I had to refactor all my code which interacted with the filesystem to account for this.
*	Fixed a major bug where the Aspect Ratio wasn’t fixed after being built
    +   This led to numerous bugs when run on a non 16:9 monitor. I have since fixed the aspect ratio to be 16:9 no matter the monitor.
*	I ran 1 student testing session which was very successful
    +   The student navigated the game with ease but gave many pointers as to things they thought were missing/were hard to use.
    +   I have since written this up and linked it into my markdown pages available on my GitHub. This is fully anonymised and I have a securely kept file for linking participant names with their aliases in case they want to back out and have their data removed.
    +   I will be taking pointers from this write up to make new issues to work on
*	One major feedback point from the testing session was the lack of ability to delete circuits. I have added this with a bin in the upper-right hand corner of the screen.
*	I have failed to find the time to work on my dissertation so this will be becoming a main priority over the next few weeks.

What we spoke about:
-	The progress I have made (found above)
-	We discussed how focus should be on the dissertation from now on – with the option of doing some more dev work in the last couple of weeks.
-	My goals for the next week (found below)

Goals for next time:
*	Focus on dissertation draft
*	Run 1 more student testing session (If it seems useful)
*	Not this week but in the future:
    +   Start work on saving reusable custom circuits

![Project Board status on 23/02/22](ProjectBoardImages/projectBoard-23-02-22.png)

## 16/03/22 - Weekly Supervisor Meeting
Progress I have made:
*	I have written the Requirements section for my Dissertation

What we spoke about:
-	The progress I have made (found above)
-   We discussed the dissertation section I have written
    +   Tone was appropriate
    +   Reference the general topic - Unity, Logic gates Wikipedia
    +   Discuss references by mentioning the surname of the writer.
    +   More educational games examples would be nice. Examples of Logic Gate games ideal. Which are being used, and where are they used?
    +   Give reasons for choosing Unity
-	My goals for the next week (found below)

Goals for next time:
*	Due to next weeks strikes my goal for 'next time' is for our final meeting before the handin, on the 28th March.
*   Complete dissertation sections Requirements, Design, Implementation, Outline(Which is just a contents page) by Sunday 20th morning to email to supervisor.
*   Complete dissertation Evaluation and Conclusion by Sunday 27th to email to supervisor.
*   Ensure Code is ready for submission.

![Project Board status on 16/03/22](ProjectBoardImages/projectBoard-16-03-22.png)

