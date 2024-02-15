using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var jmeterHome = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5";
        var testFile = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\Plantest.jmx";
        var logFile = @"D:\logjemter.txt" + DateTime.Now.ToString("ddMMyy HHmmss");
        var reportFolder = @"D:\report1"+DateTime.Now.ToString("ddMMyy HHmmss");
        var threads = "5";
        var loops = "3";
        //var propertiesFile = @"path/to/my/properties/file.properties";

        var jmeterExecutable = Path.Combine(jmeterHome, "bin", "jmeter.bat");

        var arguments = $@"-n -t ""{testFile}"" -l ""{logFile}"" -e -o ""{reportFolder}"" -Jthreads={threads} -Jloops={loops}";

        var process = new Process();
        var processStartInfo = new ProcessStartInfo(jmeterExecutable, arguments);
        processStartInfo.UseShellExecute = false;
        processStartInfo.RedirectStandardOutput = true;
        processStartInfo.RedirectStandardError = true;
        process.StartInfo = processStartInfo;

        process.OutputDataReceived += (sender, eventArgs) =>
        {
            Console.WriteLine(eventArgs.Data);
        };

        process.ErrorDataReceived += (sender, eventArgs) =>
        {
            Console.WriteLine(eventArgs.Data);
        };

        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();
        process.WaitForExit();
        Console.WriteLine("JMeter test completed.");
    }
}
//${__P(threads)}
//${__P(loops)}