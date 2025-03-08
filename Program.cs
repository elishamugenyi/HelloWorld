// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//set up a simple program that prints a hello world
 using System;

 class Program {
    static void Main(string[] args) {
        //decalre string variable
        string name = "";

        Console.WriteLine("Enter Your Full Name:"); //ask input from user.

        name = Console.ReadLine();//captures input from user.

        Console.WriteLine($"Hi {name}, welcome our Hello World!");
    }
 }