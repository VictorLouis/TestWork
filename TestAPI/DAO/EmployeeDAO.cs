using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using TestAPI.DTO;

namespace TestAPI.DAO
{
   
    public class EmployeeDAO
    {
        private string address;

        public EmployeeDAO() {
            this.address = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        }

        public string getEmployees()
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public List<EmployeeDTO> getEmployeeList()
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.

           
            var l = JsonConvert.DeserializeObject<List<EmployeeDTO>>(responseFromServer);

            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
            return l;

        }

    }
}