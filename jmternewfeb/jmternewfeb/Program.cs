using System;
using System.Diagnostics;

namespace JMeterStarter
{
    
    class Program
    {
        static void Main(string[] args)
        {
          
            string jmeterPath = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\jmeter.bat";
            string jmxFile = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\Plantest.jmx";
            string result = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\Plantest_result.jtl";
            // Start the JMeter process with the test plan file as an argument
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.RedirectStandardInput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = false;

            // Start the process
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                // Run the JMeter test plan
                process.StandardInput.WriteLine(jmeterPath + " -n -t " + jmxFile+" -l "+result);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
            }

            Console.WriteLine("JMeter test complete.");
            Console.ReadLine();
        }
    }
}
    

