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

### 9 Jan 2022
* *1.5 hours* Read the Ethics checklist and wrote introductory and debreifing scripts for my Testing Session.
* *0.5 hours* Emailed supervisor to make sure he agreed my testing session followed the ethics guidelines.

### 10 Jan 2022
* *0.5 hours* Recieved confirmation from supervisor regarding ethics forms. Emailed Jose Cano Reyes asking if he would email the 2022 class of Computer Architecture to ask for students to volunteer for my testing session.

### 11 Jan 2022
* *1 hour* Researched Saving a Unity scene. Decided that before I delve into saving custom circuits for reuse, I should first learn to save the entire scene and likely build a menu system to operate that.
* *0.5 hours* Emailed Supervisor notes for tomorrows meeting.

### 12 Jan 2022
* *0.5 hours* Supervisor Meeting
* *0.5 hours* Emailed supervisor a summary of todays meeting, updated MEETINGSSUMMARIES, and updated the Project Board.
* *2.5 hours* Researched and built the majority of the Main Menu, and Options Menu (Which is available in-game)

### 13 Jan 2022
* *0.75 hours* Completed [#51 Create Basic Main Menu](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/51) and merged the matching PR.

### 15 Jan 2022
* *1.25 hours* Researched Saving and Loading things in Unity. Realised it will require more code and work than expected. I think my best solution is to write custom controllers for serializing and deserializing everything in the scene. Instantiating the circuits and connecting the wires will likely be complex.
* *1 hour* Spent a while wrestling with searching through the scene for GameObjects and wires. Now should be at a good place to start serializing and saving the objects.

### 16 Jan 2022
* *1 hour* Tried to implement Json Serialization method - proving more difficult and nuanced than anticipated.

### 18 Jan 2022
* *1.2 hours* Spent more time on Json Serialization, trying out using another custom class for serializing. The serialization is not acting recursively though. Found Json.NET which may work better. Otherwise May individually collect Json Serializations for each Circuit and each Wire then compile somehow.
* *0.2 hours* Emailed Supervisor notes for tomorrows meeting.

### 19 Jan 2022
* *0.5 hours* Supervisor Meeting, and emailed supervisor summary of meeting.
* *0.2 hours* Updated MEETINGSUMMARIES and the project board.

### 21 Jan 2022
* *1.6 hours* Essentially finished serialization of my saved classes for later loading (reinstantiation).

### 23 Jan 2022
* *2.2 hours* Began reinstantiation/loading of circuit from my json. Having lots of trouble with storing the types for reinstantiation. Circuits are being created before the new scene has been loaded. Very annoying.

### 25 Jan 2022
* *0.2 hours* Messaged Computer Architecture Teams chat asking for students to participate in my Testing Session.
* *0.8 hours* Setup Overleaf with a basic layout of my Dissertation. Appended Bibtex bibliography - not all references showing for some reason.
* *1.4 hours* Trying to reinstantiate circuit from json. Was having problem with async loading of new scene. Now using a global var to hold a save file to be loaded. The "NewGame" scene then loads any toLoad savefiles on startup. Currently reinstantiating all circuits as "PassThroughCircuit"s for simplicity. Wires still to be paired. SaveFile names still to be specified. Workflow is laid out now though.
* *0.2 hours* Emailed Supervisor notes for tomorrows meeting.

### 26 Jan 2022
* *0.5 hours* Supervisor Meeting 

### 28 Jan 2022
* *0.2 hours* Completed [#57 Create Re-instantiating from Json files method](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/57) and merged the matching PR.
* *0.3 hours* Emailed supervisor summary of meeting and updated MEETINGSSUMMARIES and project board.
* *1.2 hours* Completed [#62 Extend Json Serialization to all circuit types](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/62) and merged the matching PR.
* *0.3 hours* Began work on extending the Json reinstantiation for Wires. 

### 31 Jan 2022
* *1.5 hours* Completed [#66 Extend json to wires](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/66) and merged the matching PR.
* *0.5 hours* Completed [#65 Refactor Switch to implement CircuitParent class](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/65) and merged the matching PR. Noted that no means of saving the switch value - this is circuit state which I haven't had to tackle yet; For now circuit state will not be saved.

### 1 Feb 2022
* *2.4 hours* Added naming of game saves, also configured LoadGame menu to have scroll bar and be populated with appropriate loadGame buttons. Very successful session! This and last 2 sessions have gone very well. Overcame the Assembly references hurdle too!
* *0.2 hours* Emailed supervisor notes for tomorrows meeting.

### 2 Feb 2022
* *0.5 hours* Supervisor Meeting
* *0.3 hours* Completed [#60 Add naming of game saves](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/60) and merged the matching PR.
* *0.2 hours* Completed [#56 Configure 'Load Game' menu](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/56) and merged the matching PR.
* *0.6 hours* Emailed supervisor summary of meeting and updated MEETINGSSUMMARIES and project board.
* *1 hour* Began building the scrollable toolbar. Have a scrollable toolbar now (Still needs automatic filling & setting-up). Fixed other positioning problems but somehow broke the attaching to customGrid. I think it thinks I'm trying to place circuits in a different place than I am. Investigate asap.

### 3 Feb 2022
* *1.8 hours* Completed [#72 Refactor toolbar scrollable](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/72) and merged the matching PR.
* *1.3 hours* Completed [#74 Add more base logic gates](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/74) and merged the matching PR.

### 5 Feb 2022
* *2 hours* Did most of 'Alter customgrid so it fits better'.
* *0.1 hours* Completed [#75 Alter CustomGrid background to fit frame more nicely](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/75) and merged the matching PR.

### 6 Feb 2022
* *0.4 hours* Completed [#71 Add Documentation on Load/Save process](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/71) and merged the matching PR.

### 7 Feb 2022
* *0.3 hours* Added intro, aims & motivations to dissertation.
* *0.2 hours* Added a 2D Sprite Background. Colours need reworking and made consistent.

### 8 Feb 2022
* *2 hours* Completed [#73 Improve the Main Menu design](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/73) and merged the matching PR.
* *1 hour* Spent time on color-scheme and trying to make things consistent.
* *0.2 hours* Emailed supervisor notes for tomorrows meeting. 

### 9 Feb 2022
* *0.5 hours* Supervisor meeting.
* *1.2 hours* Played around with color schemes, created custom model for HideSpawnerButton, added haze to options menu and tried to disable interactibility behind the filter.
* *0.2 hours* Updated documentation. Completed [#83 Add consistent colour scheme](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/83) and merged the matching PR.
* *0.4 hours* Emailed supervisor summary of meeting and updated MEETINGSSUMMARIES and project board.

### 15 Feb 2022
* *0.8 hours* Completed [#89 Add splitter Gates](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/89) and merged the matching PR.
* *0.4 hours* Completed [#88 Make first square in customGrid unassignable](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/88) and merged the matching PR.

### 16 Feb 2022
* *2.5 hours* Completed [#93 Fix filesystem for built versions of the game](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/93) and merged the matching PR.
* *0.5 hours* Completed [#69 Prepare for Student Testing Session](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/69).
* *1.5 hours* Essentially finished [#92 Fix Resolution/aspect ratio to fit more devices](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/92) but never merged the matching PR.

### 17 Feb 2022
* *0.5 hours* Carried out student testing session with Participant X.

### 22 Feb 2022
* *0.5 hours* Wrote up participant X student testing session, and updated documentation.
* *0.3 hours* Completed [#92 Fix Resolution/aspect ratio to fit more devices](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/92) and merged the matching PR.
* *0.3 hours* Completed [#95 Write-up for Student testing session with Participant X](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/95) and merged the matching PR.
* *1 hour* Completed [#98 Add the ability to delete individual circuits](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/98) and merged the matching PR.
* *0.5 hours* Tried to make wires less fiddly - didn't make much progress. Overlapping Box Colliders is causing the issue.
* *0.3 hours* Emailed supervisor notes for tomorrows meeting.

### 23 Feb 2022
* *0.3 hours* Supervisor Meeting
* *0.4 hours* Emailed supervisor meeting summary and updated documentation after todays meeting.
* *0.3 hours* Found old issues on my GitHub which I had never closed/have become obsolete - commented and closed each of these.

### 2 Mar 2022
* *0.0 hours* Supervisor Meeting Cancelled due to me having other imminent courseworks due.

### 7 Mar 2022
* *3 hours* Wrote Dissertation Background section

### 8 Mar 2022
* *0.3 hours* Emailed supervisor notes for tomorrows meeting.

### 9 Mar 2022
* *0.0 hours* Supervisor Meeting Cancelled due to Supervisor being ill.

### 11 Mar 2022
* *0.0 hours* Had my booster vaccine today.

### 12 Mar 2022
* *0.0 hours* Very ill from booster - unable to work.

### 13 Mar 2022
* *0.0 hours* Very ill from booster - unable to work.

### 15 Mar 2022
* *0.3 hours* Emailed supervisor notes for tomorrows meeting.

### 16 Mar 2022
* *0.3 hours* Supervisor Meeting
* *1 hours* Emailed supervisor summary of meeting and updated MEETINGSSUMMARIES and project board.

### 17 Mar 2022
* *1.1 hours* Wrote Requirements intro and majority of 'What options exist in the current market?' section for dissertation. Having troubles with internet connection.
* *0.4 hours* Completed 'What options exist in the current market?' section for dissertation.
* *0.8 hours* Completed 'What do I want to do uniquely?' section for dissertation.
* *0.6 hours* Roughly completed 'What is attractive to students?' section for dissertation.
* *0.9 hours* Struggled with bibliography. Wrote script to fix the issue.

### 18 Mar 2022
* *1 hour* Adjusted bibliography script for consistency. Replaced some references with proper citations.
* *1.5 hours* Mapped out Design section. Added Contents page. Further tweaking.
* *1 hour* Wrote sections 5.1 and 5.2 of dissertation.
* *0.3 hours* Updated lazy referencing, cleaned some of dissertation.

### 19 Mar 2022
* *0.75 hours* Wrestled with moving diss to l4proj template. Things acting very differently now. Referencing is off, captions gone.
* *0.5 hours* Created Figma wireframe for original design and added it to diss.
* *0.5 hours* Refactored how figures & tables work in diss. Consistent with advice now but causing issues with where figures appear.
* *0.5 hours* Wrote Design vs Implementation section of diss. Had to stop due to a mouse entering my room.

### 20 Mar 2022
* *0.5 hours* Worked on dissertation - made minimal progress.

### 22 Mar 2022
* *0.5 hours* Wrote general descriptions for 5.2 and 5.3 intros. Wrote 5.3.2 Daily Log.
* *0.5 hours* Wrote 5.3.1 'Weekly Reviews' dissertation section.

### 23 Mar 2022
* *0.45 hours* Added to 5.3.1 'Weekly Reviews' dissertation section.
* *1 hour* Added to 5.3.3 'GitHub as a Planning Resource' and 5.3.4 'GitHub as Change Control'.
* *0.7 hours* Almost completed 5.3.3 'GitHub as a Planning Resource' dissertation section.
* *1.3 hours* Essentially completed 5.3.4 'GitHub as Change Control' dissertation section.

### 24 Mar 2022
* *1.5 hours* Updated references, tried to learn about natbib and how to correct my references.
* *1.2 hours* Updated Testing for Circuits.

### 25 Mar 2022
* *1.7 hours* Wrote section 5.2.1 'Pipe and Filter Design Pattern' in dissertation.
* *0.5 hours* Wrote section 5.2.2 'Inheritance' in dissertation.
* *0.25 hours* Wrote section 5.2.3 'Generating from Filesystem' in dissertation.
* *0.25 hours* Completed [#106 Update Circuit Testing in Unity Test Runner](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/106) and merged the matching PR.
* *0.55 hours* Completed [#107 Develop full adder circuit](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/107) and merged the matching PR.
* *0.5 hours* Wrote section 5.2.4 'Behaviour Driven Development' in dissertation.
* *0.1 hours* Emailed supervisor updated dissertation draft for review.

### 26 Mar 2022
* *0.3 hours* Updated References
* *0.75 hours* Added in Chapter 6 'Testing' to diss. Began writing user testing section.

### 27 Mar 2022
* *1 hour* Tried to fix references/understand why they are failing. Failed to find a reason - seems entirely random.
* *0.6 hours* Almost completed 6.1 'User Testing' - still need to discuss what makes a good testing session generally, and add REFERENCES.
* *0.35 hours* Wrote 6.2 'Automated Testing & Continuous Integration'.
* *0.25 hours* Updated 3.4 'My Requirements' to use MoSCoW method.
* *0.55 hours* Wrote 7.1 'Revisiting my Requirements' section in dissertation.

### 28 Mar 2022
* *0.5 hours* Supervisor Meeting.
* *1.3 hours* Analysed references and again looked for reasons as to why they are failing. Discovered that the urls I have in my references are not being handled correctly - latex prints them as any other character so special characters are being misinterpreted. Removing all URLs from references fixes this but clearly isn't a proper solution. Also noticed some references look silly. Example for Unity we have 'Technologies (2099)' or whichever year. 
* *1 hour* Wrote half of 7.2 'How does my solution compare to the Market options?' in dissertation.

### 29 Mar 2022
* *0.8 hours* Updated References for previous couple of days work.
* *0.5 hours* Completed 7.2 'How does my solution compare to the Market options?'
* *0.25 hours* Completed 8.1 'Summary'
* *0.35 hours* Wrote most of 8.2 'Future Goals'
* *0.25 hours* Submitted Good Cause for 5 day extension on my dissertation.

### 30 Mar 2022
* *0.55 hours* Gave reasons for choosing Unit, discussed 'Will not have' section of MoSCoW.
* *0.25 hours* Clarified details in dissertation.
* *0.7 hours* Wrote section on saving/loading circuits - appears in '5.1 Design vs Implementation'.
* *0.7 hours* Updated references, removed redundant comments on dissertation, corrected minor details.

### 31 Mar 2022
* *0.25 hours* Extracted questions from debreif script. Checked Intro & Debreif scripts were correct.
* *0.5 hours* Began planning presentation. Created a powerpoint. listed main sections. Read marking scheme. Checked time-limit.
* *0.5 hours* Created Powerpoint template with correct colours etc to match project.
* *0.9 hours* Added structure to powerpoint. Wrote some slides. 

### 1 Apr 2022
* *1 hour* Added to Powerpoint.
* *0.2 hours* Completed [#110 Standardise naming to use circuit instead of game. e.g. 'New Game' -> 'New Circuit'](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/110) and merged the matching PR.
* *0.7 hours* Recorded Demonstration of product.
* *0.25 hours* Completed [#99 Make Wires less fiddly](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/99) and merged the matching PR.
* *0.25 hours* Completed [#105 Disallow a wire to connect to a port of the same logic-gate](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/105) and merged the matching PR.
* *1 hour* Worked on presentation. Created saving/loading flows. Fleshed out P&F slide.

### 2 Apr 2022
* *1 hour* Added to Powerpoint.
* *0.6 hours* Completed [#117 Have Switch/Light list first in the Toolbar and be presented in another colour](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/117) and merged the matching PR.
* *0.3 hours* Added to Powerpoint.
* *1 hour* Recorded presentation test. Not sure if my presentation is too long/covers stuff i dont need to/doesnt cover stuff I need to cover.

### 3 Apr 2022
* *3 hours* Researched and downloaded a video editing software and video compression software. Completed [#116 Record Powerpoint Presentation](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/116).Completed [#115 Record Demonstration of Product](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/115). Edited the clips together. Exported and compressed. Now have complete presentation video!
* *1 hour* Completed [#120 Ensure 16:9 aspect ratio is enforced](https://github.com/JosephMW/Logic-Gates-Educational-Game/issues/120) and merged the matching PR.
* *0.5 hours* Investigated referencing issues further. made progress. Using \url and replaicng special characters helps.

### 4 Apr 2022
* *2 hours* Tested compressing source code and game etc. Source code too large.