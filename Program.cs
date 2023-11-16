// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//one dimensional array
int[] age; //declare array
age = new int[5]; //allocate memory for array

//multi array
int[,] s = new int [3, 3];

//jagged array
int[][] myArray = new int[3][];
myArray[0] = new int[2] {1, 2};
myArray[1] = new int[3] {3, 4, 5};
myArray[2] = new int[1] {6};
