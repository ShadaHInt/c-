using System;
using System.IO;
using System.Diagnostics;

namespace JMeterSeleniumIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            string jmeterHome = "C:\\Users\\shadan\\Documents\\jmeter\\apache-jmeter-5.5"; // Update with your JMeter home directory
            string testPlanFile = "C:\\Users\\shadan\\Documents\\jmeter\\apache-jmeter-5.5\\bin\\mytest.jmx"; // Update with your JMeter test plan file path
            string resultsFile = "D:\\Results.jtl"; // Update with your JMeter results file path
            string seleniumJarFile = "C:\\selenium-server-standalone-3.141.59.jar"; // Update with your Selenium Jar file path
            string seleniumDriverFile = "C:\\chromedriver.exe"; // Update with your Selenium driver file path

            // Launch JMeter
            Process jmeterProcess = new Process();
            jmeterProcess.StartInfo.FileName = jmeterHome + "\\bin\\jmeter.bat";
            jmeterProcess.StartInfo.Arguments = "-n -t " + testPlanFile + " -l " + resultsFile;
            jmeterProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            jmeterProcess.Start();

            // Wait for JMeter to finish
            jmeterProcess.WaitForExit();

            // Launch Selenium
            Process seleniumProcess = new Process();
            seleniumProcess.StartInfo.FileName = "java";
            seleniumProcess.StartInfo.Arguments = "-jar " + seleniumJarFile;
            seleniumProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            seleniumProcess.StartInfo.RedirectStandardInput = true;
            seleniumProcess.StartInfo.RedirectStandardOutput = true;
            seleniumProcess.Start();

            // Send Selenium commands to the console
            StreamWriter inputWriter = seleniumProcess.StandardInput;
            inputWriter.WriteLine("System.setProperty(\"webdriver.chrome.driver\", \"" + seleniumDriverFile + "\");");
            inputWriter.WriteLine("WebDriver driver = new ChromeDriver();");
            inputWriter.WriteLine("driver.get(\"file://" + resultsFile + "\");");
            inputWriter.WriteLine("Thread.sleep(5000);");
            inputWriter.WriteLine("driver.quit();");
            inputWriter.Close();

            // Read Selenium output
            StreamReader outputReader = seleniumProcess.StandardOutput;
            string output = outputReader.ReadToEnd();
            outputReader.Close();

            // Display Selenium output
            Console.WriteLine(output);
        }
    }
}

