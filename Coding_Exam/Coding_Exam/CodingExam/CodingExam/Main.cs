using System;
using System.Net;
using CodingExam;

public class CodingExamMain
{

    static public void Main()

    {   //Problem #1
        //Fibonacci
        Console.WriteLine("Problem 1:");
        //first n Fibonacci numbers
        int n = 10;
        Fibonacci.FibonacciSequence(n);


        //Problem #2
        //Word Count
        Console.WriteLine("\n\nProblem 2:");
        string inputFile = "inputFile.txt";
        //Constraint - Don't read the whole file into memory
        //The number of lines to read
        int numberOfLines = 20;
        //To download the input file, it's already in \Coding_Exam\CodingExam\CodingExam\bin\Debug\net6.0
        //WebClient client = new();
        //File.WriteAllText(inputFile, client.DownloadString("https://www.gutenberg.org/files/1/1-0.txt"));
        WordCount.WordOccurrence(inputFile, numberOfLines);


        //Problem #3
        //Balanced Parentheses
        Console.WriteLine("\n\nProblem 3:");

        string[] test = {"({[({[[({[]})]]})]})",
                        "oXK(Xl[1m{}2]HJSZNm)",
                        "(((([[fVmz2qmz}WJfVp",
                        "UjuTO2z2qtBn82qpFYS9",
                        "2R(Tf{{{Gb]]FlwX)m7g",
                        "(G{M[L{z(w)N}d]x}m)l",
                        "MWfv2JZFVHINWO8uTcyd",
                        "yhj{{{{{}}}}}Wz[]x()",
                        "[[[[[[[[[[[[[[[[[[[[",
                        "l0SOvapJmIrjel4qMh96",
                        "(a(b(c))[)df[]]f)" };
        foreach (var x in test)
        {
            BalancedParentheses.BalanceCheck(x);
        }
        
    }
    
}