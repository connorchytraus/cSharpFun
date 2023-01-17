using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpFun
{
    public class PrintStuff
    {
        private string language = "";
        public PrintStuff(string temp)
        {
            language = temp;
        }

        public void PrintName(string name)
        {
            if (language == "EN")
            {
                Console.WriteLine("Hello, " + name);
            }

            if (language == "KH")
            {
                Console.WriteLine("Suarsday " + name);
            }
            
        }
    }
}
