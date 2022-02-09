using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutISP
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool PrintCopyContent(string content);
        bool PrintDuplexContent(string content);
    }
}
