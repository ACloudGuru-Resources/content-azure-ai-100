using Azure;
using System;
using System.Globalization;
using Azure.AI.TextAnalytics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxAcademy.Azure.AI.LanguageRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri endpoint = new Uri(""); // insert your endpoint
            string key = ""; // insert your key
            var credentials = new AzureKeyCredential(key);
            var client = new TextAnalyticsClient(endpoint, credentials);

            DetectedLanguage lang1 = client.DetectLanguage("This is a document written in English.");
            Console.WriteLine($"Language: {lang1.Name}");

            DetectedLanguage lang2 = client.DetectLanguage("Parlez Vous Francais?");
            Console.WriteLine($"Language: {lang2.Name}");
        }
    }
}