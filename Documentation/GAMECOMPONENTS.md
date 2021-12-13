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

## Input Ports

## Toolbar