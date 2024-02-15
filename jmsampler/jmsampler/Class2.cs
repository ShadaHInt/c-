using System;
using System.Diagnostics;

namespace JMeterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the JMeter home directory
            var jmeterHome = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5";

            // Set the test plan file path
            var testPlanFile = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\Plantest2.jmx";

            // Set the log file path
            var logFile = @"D:\logjemter.txt" + DateTime.Now.ToString("ddMMyy HHmmss");

            // Set the result file path
            //var resultFile = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\test.jtl";

            // Set the number of threads
            var numThreads = 2;

            // Set the number of loops
            var numLoops = 1;

            // Set the URL of the server to test
            string serverUrl = "www.flipkart.com";

            // Set the HTTP method to use
            string httpMethod = "GET";
            // string reportFolder = @"D:\report1" + DateTime.Now.ToString("ddMMyy HHmmss");
            var reportFolder = @"D:\report1" + DateTime.Now.ToString("ddMMyy HHmmss");
            // Create the JMeter command line arguments
            var jmeterArgs = $"-n -t \"{testPlanFile}\" -l \"{logFile}\" -Jthreads={numThreads} -Jloops={numLoops} -JserverUrl=\"{serverUrl}\" -JhttpMethod={httpMethod} -e -o \"{reportFolder}\"";
            //var jmeterArgs = $@"-n -t ""{testPlanFile}"" -l ""{logFile}"" -e -o ""{reportFolder}"" -Jthreads={numThreads} -Jloops={numLoops}";

            var jmeterExecutable = Path.Combine(jmeterHome, "bin", "jmeter.bat");
            var process = new Process();
            var processStartInfo = new ProcessStartInfo(jmeterExecutable, jmeterArgs);
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
            Thread.Sleep(5000);
            Console.WriteLine("JMeter test completed.");
        }
    }

}


