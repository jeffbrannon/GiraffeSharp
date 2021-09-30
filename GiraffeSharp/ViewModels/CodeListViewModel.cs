using System;
using System.Collections.Generic;
using System.Text;

namespace GiraffeSharp.ViewModels
{
    public class CodeListViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public CodeListItem[] CodeList => new CodeListItem[] { 
            new CodeListItem { LineNumber = "10", Code = "For a = 1 to 10" }, 
            new CodeListItem { LineNumber = "20", Code = "Print a" }, 
            new CodeListItem { LineNumber = "30", Code = "Next" } };
    }

    public class CodeListItem
    {
        public string LineNumber { get; set; }
        public string Code { get; set; }
    }
}
