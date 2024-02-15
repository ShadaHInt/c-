using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Process javaProcess = new Process();
        javaProcess.StartInfo.FileName = "C://Program Files//Java//jdk-21//bin//java"; // Path to the Java executable
        javaProcess.StartInfo.Arguments = "-jar C://Users//shadan//IntellijProjects//TestCsharp//src//main//java//org//example//MyCode.jar"; // Path to your JAR file

        javaProcess.StartInfo.UseShellExecute = false;
        javaProcess.StartInfo.RedirectStandardOutput = true;
        javaProcess.Start();

        string output = javaProcess.StandardOutput.ReadToEnd();
        javaProcess.WaitForExit();

        Console.WriteLine("Java Output: " + output);
    }
}