# Game Components

This file contains documentation on how the major game components work in my project.

[Link back to README](../README.md)

## Custom Grid
This is the GameObject which spawns the background grid. It creates the grid of squares on Awake, when the game starts. 
The Custom Grid is used for placing Circuits in a uniform fashion. It works by keeping an int matrix which you specify the number of rows and columns. The int matrix is then iterated over and each index is converted to a position on the 2D plane. At each of these calculated positions a Square sprite is spawned.

Custom Grid also has public methods *placeElementInGrid* and *clearSquare* which are used by the Drag-and-drop script to allow positional placing of Circuits.

## Drag-and-Drop
This is a script which is used on all 'draggable' Circuits. It allows you to click, hold, and drag a component around the UI. When the mouse is originally clicked we make use of the *clearSquare* method extended by **Custom Grid** to remove the object from its position in Custom Grid. When the mouse is dropped we pass the position of the cursor
to the *placeElementInGrid* method extended by **Custom Grid** - this calculates the position of the center of the nearest grid square and returns it, this is then used to set the position of the Circuit.

## Circuits
All Circuits inherit from *CircuitParent* - an abstract class which defines all generic behaviour for Circuits. *CircuitParent* defines how circuits should update and output values. Individual circuits inherit *CircuitParent* and override the definition for *calculateOutputs* which defines the logic of the circuit.

Circuits have a number of **Input Ports** which allow inflow of signals.

Circuits have a number of **Wires** which allow outflow of signals.

Circuits also have a unique ID which is set when they are instantiated - all IDs are managed in the GlobalVariables class.

## Wires
This is a GameObject which is always associated with a **Circuit** (Referred to as its parent circuit). The Wire GameObject holds a signal value, which is set by its parent circuit. A wire can be connected to an **Input Port** via dragging and dropping. If connected to an **Input Port** then a Wire will output its value to that port whenever its value changes or when the connection is first made.

The connection logic between Wire and **Input Port** is somewhat complex and will be discussed in its own section - see **Making Connections - Wires and Input Ports**.

Wires also have a unique ID which is set when they are instantiated - all IDs are managed in the GlobalVariables class.

## Input Ports
This is a GameObject which is always associated with a **Circuit** (Referred to as its parent circuit). The Input Port GameObject holds a signal value which it forwards on to its parent circuit. If a **Wire** has been connected to the input port then the Wire's value will be transmitted to the Input Port which will then forward the signal to its parent circuit.

The connection logic between **Wire** and Input Port is somewhat complex and will be discussed in its own section - see **Making Connections - Wires and Input Ports**.

Input Ports also have a unique ID which is set when they are instantiated - all IDs are managed in the GlobalVariables class.

## Making Connections - Wires and Input Ports
A wire is draggable, has a 2D Rigidbody, and has a 2D Box Collider. An input port is stationary and also has a 2D Box Collider. When a wire is dragged over an input port, the input port uses the *OnTriggerEnter2D* method to register this collision. The Input Port then registers the Wire and makes the Wire register the input port. If the Wire is then dropped (Still over the input port) then the full connection is made, the WireTip is made a child of the Input Port parent cicuit, and positioning is setup. If the wire is then dragged out of the input port box collider the strong connection is deleted and both input port and wire forget each other.

## Toolbar
The Toolbar exists in the SampleScene and consists of a UI Canvas with a series of GameObjects within it. Each child GameObject including the buttons are rendered using a 'Canvas Renderer' which replaces the typically used 'Sprite Renderer' - this change is due to the Toolbar being a UI component.

Each button object uses the 'SpawnCircuitButton' script which spawns the desired circuit and sets its Drag-and-Drop field 'dragging' to True - this allows the user to then drag the newly spawned Circuit into position and drop it in place.
Every button is created on awake via the 'SpawnCircuitButtonListController' reading the file system for circuits and generating buttons to instantiate these circuits.

The toolbar object also contains the OptionsMenu Cog wheel and the options menu itself. These are both UI elements using TextMeshPro for all text elements. The OptionsMenu Cog works by setting the 'active' state of the menu to true - returning to the game doe the opposite.

## Main Menu
The main menu is comprised by a series of UI elements. I make use of the TextMeshPro package for nicer text. 

The 'New Game' button selects a scene to load from the build settings - it loads the 'NewGame' scene. 

The 'Load Game' button sets the active state of the main menu to false and the active state of the 'LoadGameMenu' to true. Thus allowing navigation to the LoadGameMenu.

The 'Quit Game' button makes use of Application.Quit() to close the game.

## Saving Games
In order to save a game, the SaveController is used. The SaveController exposes the public method SaveScene(string saveName). This SaveScene method takes a string saveName parameter which is used to name the savefile. The method works by grabbing all the CircuitParent components in the scene and examining the GameObjects they are attached to. From each CircuitParent using GameObject, we store its ID, its location, its type (e.g. And2, Or2, Not, etc) as a string. We also store information about its inputPorts, and information about its wires. The inputPort information we store is the inputPorts ID. The wire information we store is the wires ID and its coupled ports ID (If it is not coupled to an inputPort this ID is set to 9999).

We take all the information described above about the scene and instantiate a series of serializable local classes. Once we have a fully assembled model of the scene, we use the JsonUtility.ToJson method to serialize the collected data. This data is then written to the SaveFiles/ directory for later loading.

## Loading Games
To load a game we make use of the LoadController. When a gamesave is chosen to be loaded from the LoadGame menu we set a global variable named 'toLoad' to the string value of the gameSave name. Then we change the active scene to "NewGame", and on Awake this scene calls to the LoadController to load in the gamesave. The LoadController reads the Json Serialization from the SaveFiles folder and iteratively spawns the circuits in the scene. It numbers each circuit with the IDs given in the gamesave - this is important as the IDs must be unique and are crucial to the save/load process. In order to link wires we find the wires and inputPorts in the scene and match them up using their IDs.