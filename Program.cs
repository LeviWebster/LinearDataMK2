using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;


/* one of the situations that you could uses a linked list in is use it to reprisent and plolynominal,-
* this is because each peice of data in the list corrisponds to a second, and so on and so forth,-
* making it ideal to hold long polynominals, this also makes it easy to store and manipulate the data- 
* of the polynominal.
*/

// the difference between a stack and a queue is that a stack uses the LIFO(Last In First Out) while-
//the queue uses FIFO(First In First Out),  this refers to the order in which the data is stored 
//and accessed

/*  you would use a stack when you want to acces the last peice of data you entered into the data- 
 first, such as a situation in which you entered the most important data last.
*/

//you would use a array instead of a list if you didnt need to incease the size of the list after it-
//was made, or if your operating system only had very limited resourses.

//this function will reverse the imput numbers
Stack<int> st = new Stack<int>();
Console.WriteLine("enter your numbers, when done enter zero");
int stackadd = 1;
//getting imput
while (stackadd != 0)
{
    stackadd = Convert.ToInt32(Console.ReadLine());
    st.Push(stackadd);
}
//writing the list
Console.WriteLine("current stack reversed");
foreach (int i in st)
{
    Console.WriteLine(i + " ");
}
Console.WriteLine(st.ToString());



//creating the array
int[] numarray = { 0, 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 6, 9, 4, 3, 1, 2 };
int[] count = new int[10];

//Loop through 0-9 and count the occurances
for (int x = 0; x < 10; x++)
{
    for (int y = 0; y < numarray.Length; y++)
    {
        if (numarray[y] == x)
            count[x]++;
    }
}

//writing the numbers           
for (int x = 0; x < 10; x++)
    Console.WriteLine("Number " + x + " appears " + count[x] + " times");

//function that runs though numbers and functions
static void Main()
{
    //creating variables and queue
    int N = 2;
    Queue<int> queuenum = new Queue<int>();
    queuenum.Enqueue(N);
    int index = 0;
    Console.WriteLine("S =");
    //looping through the queue
    while (queuenum.Count > 0)
    {
        index++;
        int current = queuenum.Dequeue();
        Console.WriteLine(" " + current);
        //closing the function
        if (index == 79)
       {
          Console.WriteLine();
          Console.WriteLine("Index = " + index);
           return;
       }
    //creating more varables and adding them to the queue
    queuenum.Enqueue(current + 1);
    queuenum.Enqueue(2 * current + 1);
    queuenum.Enqueue(current + 2);
    }
} 

Main();


