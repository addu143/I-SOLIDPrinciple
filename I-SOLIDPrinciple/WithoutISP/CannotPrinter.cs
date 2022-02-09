using System;

namespace WithoutISP
{
    public class CannotPrinter : IPrintTasks
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

        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine(content);
            return true;
        }
    }
}
