// See https://aka.ms/new-console-template for more information
using System.Text;

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

//array manipulation
int[] marks = new int[5] {1,2,3,4,5};
foreach(int mark in marks){
    Console.WriteLine(mark);
}

int[,] multi = new int[3,4] {{1,2,3,4}, {1,2,3,4}, {1,2,3,4}};
for(int i=0; i<3; i++){
    for(int j=0; j<4; j++){
        Console.Write(multi[i, j] + " ");
    }
    Console.Write("\n");
}

string s1 = "Hello";
String s2 = "Hello";

Console.WriteLine(s1);
Console.WriteLine(s1.Length);
Console.WriteLine(string.Concat(s1, s2));
Console.WriteLine(s1.Equals(s2));


//immutable string
string s3 = "hee";
string s4 = "lala";

//mutable String
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Hii");
stringBuilder.Append("Holo");

