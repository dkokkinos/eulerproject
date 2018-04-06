# Euler Project Solutions

## Overall structure of the project
This project consists of:
* EulerConsole, which is the console interface and the 'composition root' of the application 
* Interfaces that contain an ISolvable interface, which should be implemented by the corresponding classes, so that the console application addresses them uniformly
* Problems. Here are all the solutions to every problem. Each solution has a root class that implements the ISolvable interface

 It seemed more appropriate to me to isolate some aspects of the problem and let them independently vary from the rest of the application. This is why many of the problems are addressed in a design patterns approach.The problems below are examples of this approach. 

#### problem 11: Largest product in a grid

In this problem we have to calculate the maximum product of 4 adjacent numbers in a matrix 20x20. By adjacent we mean that the numbers should be continuous in various directions, eg. diagonal, horizontal or vertical. 
To make this problem a bit more challenging, I added a degree of freedom to these aspects:
* the matrix should not have predefined dimensions, the dimensions should be calculated at runtime.
* the matrix should be provided in plain text with space separated values (so that it's easy to import such a matrix from a text file)
* the number of adjacent numbers should be a variable. The problem states 4 adjacent numbers,  but we will treat it as a variable.
* the type of adjacent numbers we are going to calculate (are they going to be diagonal, vertical or horizontal?) This enables us to extend the application to support any type of adjacent numbers (for example a cross) without many modifications.
* the type of calculation (the result here is a product, but I think it would be wise to isolate that calculation from the template algorithm)

Just to make clear what a horizontal, vertical and diagonal adjacent numbers are, I've colored 4 adjacent "modes" in the matrix bellow.
* vertical -> red
* horizontal -> yellow
* diagonal 45 degrees -> green
* diagonal 135 degrees -> purple

![matrix](https://raw.githubusercontent.com/codedayafternoon/eulerproject/master/Problems_0_50/P11_LargestProductInaGrid/images/problem11table.jpg)

To add a degree of freedom as to which adjacent modes (horizonal, vertical, diagonal) are going to be calculated, I made an abstract NumberParserStrategy which has two abstract functions. These functions will be implemented by all the following derived classes:
* Diagonal135DegreesNumberParser
* Diagonal45DegreesNumberParser
* HorizontalNumberParser
* VerticalNumberParser

and any other future mode.

The class diagram bellow shows the mentioned configuration. 

![class diagram](https://raw.githubusercontent.com/codedayafternoon/eulerproject/master/Problems_0_50/P11_LargestProductInaGrid/images/euler_problem11.jpg)

The main idea is that the LargestProductGridSolution class has the main algorithm which is the double iteration over the matrix. For each iteration it will call each of the strategies with the current point (x,y) of the matrix and the strategy will return the corresponding numbers.

With 4 strategies in play the output will be:

```sh
$ λ EulerConsole.exe
$ for Diagonal45DegreesNumberParser the result is 279496 for numbers 8,49,31,23
$ for HorizontalNumberParser the result is 1651104 for numbers 8,49,81,52
$ for Diagonal45DegreesNumberParser the result is 2904000 for numbers 22,40,55,60
$ for HorizontalNumberParser the result is 6414210 for numbers 22,99,31,95
$ for HorizontalNumberParser the result is 6514520 for numbers 97,40,73,23
$ for Diagonal45DegreesNumberParser the result is 11587200 for numbers 40,60,71,68
$ for Diagonal135DegreesNumberParser the result is 34826064 for numbers 78,98,67,68
$ for Diagonal135DegreesNumberParser the result is 41076896 for numbers 98,67,68,92
$ for HorizontalNumberParser the result is 51267216 for numbers 66,91,88,97
$ for Diagonal135DegreesNumberParser the result is 70600674 for numbers 89,94,97,87
```




