using System;

namespace WithISP
{
    public class CannotPrinter : IPrintContent, IPrintCopyContent
    {
        public bool PrintContent(string content)
        {
            Console.WriteLine(content);
            return true;
        }

        public bool PrintCopyContent(string content)
        {
            Console.WriteLine(content);
            return true;
        }
    }
}
