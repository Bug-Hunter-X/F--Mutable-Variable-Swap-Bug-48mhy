# F# Mutable Variable Swap Bug

This repository demonstrates a common bug in F# involving the incorrect swapping of mutable variables.

## Bug Description
The `swap` function attempts to swap the values of two mutable variables, `x` and `y`. However, due to a misunderstanding of how mutable variables work in F#, the swap function does not modify the original variables.  This results in the values of `x` and `y` remaining unchanged after calling the `swap` function. 

## Bug Reproduction
1. Clone this repository.
2. Open `bug.fs` in a F# editor or IDE.
3. Run the code. Observe that the output shows the original values of `x` and `y`, not the swapped values.

## Solution
The solution involves understanding that mutable variables in F# are passed by reference.  Therefore, changes made to `x` and `y` within the `swap` function directly modify the original variables outside the function's scope. The solution is to directly modify the values inside the `swap` function without assigning to temporary variables, or returning the swapped variables. 

## How to fix the bug
The solution is provided in `bugSolution.fs`. It demonstrates how to modify the `swap` function to correctly swap the mutable variables.