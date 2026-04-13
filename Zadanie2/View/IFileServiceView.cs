using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2.View
{
    public interface IFileServiceView
    {
        event EventHandler SaveToFileClicked;
        event EventHandler LoadFromFileClicked;
    }
}
