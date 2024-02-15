using System.Diagnostics;

namespace jmetertestingproj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //public void TestMethod1()
        //{

            static void Main(string[] args)
            {
                // Path to the JMeter executable
                string jmeterPath = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\ApacheJMeter.jar";

                // Path to the JMeter test plan file
                string jmxFile = @"C:\Users\shadan\Documents\jmeter\apache-jmeter-5.5\bin\TestPlan.jmx";

                // Start the JMeter process with the test plan file as an argument
                //var process = new Process
                //{
                //    StartInfo = new ProcessStartInfo
                //    {
                //        FileName = jmeterPath,
                //        Arguments = "-n -t " + jmxFile,
                //        UseShellExecute = false,
                //        RedirectStandardOutput = true,
                //        CreateNoWindow = true
                //    }
                //};

                //    process.Start();

                //    // Wait for the JMeter process to complete
                //    process.WaitForExit();
                //}


                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.RedirectStandardInput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = false;
                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    // Run the JMeter test plan
                    process.StandardInput.WriteLine(jmeterPath + " -n -t " + jmxFile);
                    process.StandardInput.Flush();
                    process.StandardInput.Close();
                    process.WaitForExit();
                }

                Console.WriteLine("JMeter test complete.");
                Console.ReadLine();
            }
        }
    }

