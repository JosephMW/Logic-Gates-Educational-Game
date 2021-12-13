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

## Wires
This is a GameObject which is always associated with a **Circuit** (Referred to as its parent circuit). The Wire GameObject holds a signal value, which is set by its parent circuit. A wire can be connected to an **Input Port** via dragging and dropping. If connected to an **Input Port** then a Wire will output its value to that port whenever its value changes or when the connection is first made.

The connection logic between Wire and **Input Port** is somewhat complex and will be discussed in its own section - see **Making Connections - Wires and Input Ports**.

## Input Ports
This is a GameObject which is always associated with a **Circuit** (Referred to as its parent circuit). The Input Port GameObject holds a signal value which it forwards on to its parent circuit. If a **Wire** has been connected to the input port then the Wire's value will be transmitted to the Input Port which will then forward the signal to its parent circuit.

The connection logic between **Wire** and Input Port is somewhat complex and will be discussed in its own section - see **Making Connections - Wires and Input Ports**.

## Making Connections - Wires and Input Ports
A wire is draggable, has a 2D Rigidbody, and has a 2D Box Collider. An input port is stationary and also has a 2D Box Collider. When a wire is dragged over an input port, the input port uses the *OnTriggerEnter2D* method to register this collision. The Input Port then registers the Wire and makes the Wire register the input port. If the Wire is then dropped (Still over the input port) then the full connection is made, the WireTip is made a child of the Input Port parent cicuit, and positioning is setup. If the wire is then dragged out of the input port box collider the strong connection is deleted and both input port and wire forget each other.

## Toolbar
The Toolbar exists in the SampleScene and consists of a UI Canvas with a series of GameObjects within it. Each child GameObejct including the buttons are rendered using a 'Canvas Renderer' which replaces the typically used 'Sprite Renderer' - this change is due to the Toolbar being a UI component.

Each button object uses the 'Spawn Circuit' script which spawns the desired circuit and sets its Drag-and-Drop field 'dragging' to True - this allows the user to then drag the newly spawned Circuit into position and drop it in place.