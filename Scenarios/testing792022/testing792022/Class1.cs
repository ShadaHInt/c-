using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace testing792022
{
    
        class Program
        {
             static void main (string[] args)
            {
                List<Person> source = new List<Person>();

                using (StreamReader r = new StreamReader("data.json"))
                {
                    string json = r.ReadToEnd();
                    source = JsonSerializer.Deserialize<List<Person>>(json);
                }

                List<DataReadyPerson> destination = source.Select(d => new DataReadyPerson
                {
                    CityOfResidence = d.City,
                    fname = d.Firstname,
                    lname = d.Lastname,
                    DataReadPersonId = d.Id
                }).ToList();


                string jsonString = JsonSerializer.Serialize(destination, new JsonSerializerOptions() { WriteIndented = true });
                using (StreamWriter outputFile = new StreamWriter("dataReady.json"))
                {
                    outputFile.WriteLine(jsonString);
                }
            }
        }

        public class Person
        {
            public int Id { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string City { get; set; }
        }
        public class DataReadyPerson
        {
            public int DataReadPersonId { get; set; }
            public string fname { get; set; }
            public string lname { get; set; }
            public string CityOfResidence { get; set; }
        }
    }


