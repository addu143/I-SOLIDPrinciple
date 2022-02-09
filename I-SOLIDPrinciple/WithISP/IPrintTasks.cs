using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithISP
{
    public interface IPrintContent 
    { 
        bool PrintContent(string content);
    }

    public interface IPrintCopyContent
    {
        bool PrintCopyContent(string content);     
    }
    public interface IPrintDuplexContent
{      
        bool PrintDuplexContent(string content);
    }

}
