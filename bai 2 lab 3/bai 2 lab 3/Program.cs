using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2_lab_3
{
    class Program
    {
        static void Main()
        {
            string username = "myUsername";
            string password = "myPassword";
            string time = DateTime.Now.ToString();

            using (StringWriter sw = new StringWriter())
            {
                sw.WriteLine("username: " + username);
                sw.WriteLine("password: " + password);
                sw.WriteLine("time save: " + time);

                string content = sw.ToString();

                using (StringReader sr = new StringReader(content))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}   
