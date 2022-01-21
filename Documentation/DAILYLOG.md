# Daily Log

* Project Name: Logic Gates Educational Game
* Student Name: Joseph Weir
* Student GUID: 2365352w
* Supervisor Name: Chris McCaig

[Link back to README](../README.md)

## Guidance

* This file contains the time log for your project. It will be submitted along with your final dissertation.
* **YOU MUST KEEP THIS UP TO DATE AND UNDER VERSION CONTROL.**
* This timelog should be filled out honestly, regularly (daily) and accurately. It is for *your* benefit.
* Follow the structure provided, grouping time by weeks.  Quantise time to the half hour.

**NOTE:** *My 'Weeks' are recorded Monday to Monday. I will organise my sprints to last 1 week and also run Monday to Monday for ease of documentation. This decision was made on 14/10/21 after confusion as to when my weeks work on the project board should end.*

## Week 1

### 29 Sep 2021

* *0 hours* Received notice that I had been allowed to do my self-proposed project.
* *0.5 hours* Reached out to my supervisor (Chris McCaig) to make initial contact and thank him for accepting my proposed project.

### 01 Oct 2021

* *0.5 hours* First meeting with supervisor.
* *0.5 hours* Emailed supervisor a summary of the meeting after finishing.

## Week 2

### 04 Oct 2021

* *0.5 hours* Installed Unity.
* *1 hours* Setup dev tools: GitHub, VS Code, GitHub Desktop
* *0.2 hours* Created Base Unity Project
* *0.1 hours* Added .gitignore
* *0.2 hours* Started this log.

### 05 Oct 2021

* *0.5 hours* Added [MEETINGSSUMMARIES.md](MEETINGSSUMMARIES.md)
* *0.5 hours* Added links between documentation files and improved styling.

### 06 Oct 2021

* *0.6 hours* Read over moodle information page, and then amended this log file to mirror the proposed styling.
* *0.3 hours* Added 'Issue Tracking & Branching Strategy' information to my README
* *0.7 hours* Created Project Timeline and Added to README: Software I used was very annoying and forced a watermark which I removed.

### 07 Oct 2021

* *0.7 hours* Decided to replace old referencing system with Mendeley.
* *0.3 hours* Added exported .bib reference file and reordered file-system to be neater.
* *0.25 hours* Researched gamedev.
* *0.6 hours* Began creating Grid-area in first feature branch.

### 08 Oct 2021

* *0.5 hours* Project Meeting with Supervisor
* *0.5 hours* Writing up Project Meeting and recording details.

### 10 Oct 2021

* *0.4 hours* Recorded Project Board over last week in MeetingsSummaries, and prepared board for next week. 
* *0.7 hours* Worked on CustomGrid which is being tracked with [#9](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/9)

## Week 3

### 12 Oct 2021

* *1 hour* Replaced TextMesh with SpriteRenderer and square sprite to complete CustomGrid for now.
* *1 hour* Built foundations for circuit with drag-and-drop, added placeholder sprite.

### 13 Oct 2021

* *0.4 hours* Tidied [PR for CustomGrid](https://github.com/JosephMW/Logic-Gates-Educational-Game/pull/10), merged PR, and closed [Issue #9](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/9). Merge was delayed for lack of internet access.
* *0.2 hours* Created [PR template](.github/pull_request_template.md) to try and ensure consistent PRs.
* *1.5 hours* Worked on Drag-and-drop. Now working rudimentally, using OnMouseDown etc. 

### 14 Oct 2021

* *0.7 hours* Supervisor meeting. Emailed summary of meeting.
* *0.5 hours* Researched Unity - linking scripts, GameObjects etc.
* *2 hours* Completed Drag-and-Drop, prepared [Drag-and-Drop PR](https://github.com/JosephMW/Logic-Gates-Educational-Game/pull/16), merged and closed issues [#8](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/8), [#11](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/11).

### 16 Oct 2021

* *0.25 hours* Researched and planned wiring system.
* *2 hours* Began work on Wire System.

## Week 4

### 19 Oct 2021

* *0.7 hours* Created Wire prefab.

### 20 Oct 2021

* *0.4 hours* Supervisor Meeting.
* *2.5 hours* Created Circuit prefab and added draggable wires. 
* *0.2 hours* Emailed supervisor a meeting summary.
* *0.8 hours* Researched and implemented simple collisions with triggers so that dragging a wire over an input is sensed.

### 21 Oct 2021

* *0.4 hours* Updated MeetingsSummaries to recap on yesterdays meeting. Updated references.

## Week 5

### 26 Oct 2021

* *2 hours* Set up Wire logic connection. Created placeholder Switch and Light.
* *1 hour* Fully implemented Switch and Light. Now we can see signals passing through the circuit.

### 27 Oct 2021

* *0.5 hours* Supervisor Meeting.
* *0.25 hours* Emailed supervisor a meeting summary and recorded the meeting in MEETINGSSUMMARIES.md

## Week 6

### 02 Nov 2021
* *0.3 hours* Completed [#24 Wire System: Wires which are dragged to empty space should retract](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/24) and merged the matching PR.
* *0.5 hours* Completed [#18 Wire System: Disconnecting wires](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/18) and merged the matching PR.
* *0.7 hours* Completed [#19 Wire System: Have wire tips position correctly on their inputs](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/19) and merged the matching PR.
* *0.8 hours* Completed [#27 Create the And2 circuit](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/27) and merged the matching PR.
* *0.2 hours* Emailed supervisor outline for tomorrows meeting.

### 03 Nov 2021
* *0.5 hours* Supervisor meeting.
* *0.3 hours* Emailed supervisor a summary of todays meeting and updated MEETINGSSUMMARIES

### 07 Nov 2021
* *0.5 hours* Researched testing in Unity. Learned about EditMode and PlayMode testing, as well as the Test Runner.
* *1.5 hours* Completed [#28 Write a test](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/28) and merged the matching [PR](https://github.com/JosephMW/Logic-Gates-Educational-Game/pull/34).

## Week 7

### 08 Nov 2021
* *0.5 hours* Researched GitHub Actions and using the Unity Test Runner in GitHub Actions
* *2 hours* Tried to implement Unity Test Runner in GitHub Actions. GitHub Action still not working.

### 09 Nov 2021
* *3 hours* Completed [#33 Extract parent class from Circuit](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/33) and merged the matching PR.

### 10 Nov 2021
* *0.5 hours* Supervisor Meeting
* *0.3 hours* Emailed supervisor a summary of todays meeting, updated MEETINGSSUMMARIES, and updated the Project Board.

### 14 Nov 2021
* *3.5 hours* Completed [#20 Wire System: Have connected wires move with a Circuit/Light when moved](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/20) and merged the matching PR. Took more work than anticipated as a couple of refactorings were needed.

### 15 Nov 2021
* *1 hour* Completed [#31 Fix disconnecting wires onClick bug](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/31) and merged the matching PR.

### 16 Nov 2021
* *0.3 hours* Completed [#41 When a wire connection is made/destroyed we should immediately output the value signal](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/41) and merged the matching PR.
* *2.5 hours* Completed [#37 Toolbar: Create a toolbar which allows the spawning of Circuits](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/37) and merged the matching PR.
* *0.1 hours* Emailed supervisor notes for tomorrows meeting.

### 17 Nov 2021
* *0 hours* Cancelled todays supervisor meeting due to me being ill.

### 24 Nov 2021
* *0.5 hours* Supervisor Meeting
* *0.3 hours* Emailed supervisor a summary of todays meeting, updated MEETINGSSUMMARIES, and updated the Project Board.

### 12 Dec 2021
* *0.6 hours* Caught up with where I was. Investigated ongoing bug. Will correct bug tomorrow.

### 13 Dec 2021
* *2 hours* Completed [#44 Fix bug where inputPorts become unavailable](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/44) and merged the matching PR.
* *1 hour* Completed [#46 Write Documentation about main components of the project](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/46) and merged the matching PR.
* *0.3 hours* Did some general testing - built an And4 circuit. No bugs found.
* *0.3 hours* Emailed supervisor notes for tomorrows meeting.

### 14 Dec 2021
* *0.5 hours* Supervisor Meeting
* *0.3 hours* Emailed supervisor a summary of todays meeting, updated MEETINGSSUMMARIES, and updated the Project Board.

### 9 Jan 2021
* *1.5 hours* Read the Ethics checklist and wrote introductory and debreifing scripts for my Testing Session.
* *0.5 hours* Emailed supervisor to make sure he agreed my testing session followed the ethics guidelines.

### 10 Jan 2021
* *0.5 hours* Recieved confirmation from supervisor regarding ethics forms. Emailed Jose Cano Reyes asking if he would email the 2021 class of Computer Architecture to ask for students to volunteer for my testing session.

### 11 Jan 2021
* *1 hour* Researched Saving a Unity scene. Decided that before I delve into saving custom circuits for reuse, I should first learn to save the entire scene and likely build a menu system to operate that.
* *0.5 hours* Emailed Supervisor notes for tomorrows meeting.

### 12 Jan 2021
* *0.5 hours* Supervisor Meeting
* *0.5 hours* Emailed supervisor a summary of todays meeting, updated MEETINGSSUMMARIES, and updated the Project Board.
* *2.5 hours* Researched and built the majority of the Main Menu, and Options Menu (Which is available in-game)

### 13 Jan 2021
* *0.75 hours* Completed [#51 Create Basic Main Menu](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/51) and merged the matching PR.

### 15 Jan 2021
* *1.25 hours* Researched Saving and Loading things in Unity. Realised it will require more code and work than expected. I think my best solution is to write custom controllers for serializing and deserializing everything in the scene. Instantiating the circuits and connecting the wires will likely be complex.
* *1 hour* Spent a while wrestling with searching through the scene for GameObjects and wires. Now should be at a good place to start serializing and saving the objects.

### 16 Jan 2021
* *1 hour* Tried to implement Json Serialization method - proving more difficult and nuanced than anticipated.

### 18 Jan 2021
* *1.2 hours* Spent more time on Json Serialization, trying out using another custom class for serializing. The serialization is not acting recursively though. Found Json.NET which may work better. Otherwise May individually collect Json Serializations for each Circuit and each Wire then compile somehow.

### 21 Jan 2021
* *1.6 hours* Essentially finished serialization of my saved classes for later loading (reinstantiation).