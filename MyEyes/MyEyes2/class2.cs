using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyEyes2
{
    class class2
    {

        public void RunSomething()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < int.MaxValue; i++)
            {
                sb.Append($"{i} ");
            }
            File.WriteAllText(@"c:\temp\doda.txt", sb.ToString());  
        }
    }
}
