using System;

namespace WithISP
{
    public class HPLaserJet : IPrintContent, IPrintDuplexContent
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine(content);
            return true;
        }    

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine(content);
            return true;
        }
    }
}
