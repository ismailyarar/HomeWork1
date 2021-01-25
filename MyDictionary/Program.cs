using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("ismail", "125632");
            students.Add("metin", "124578");
            students.Read();
        }
    }
}
