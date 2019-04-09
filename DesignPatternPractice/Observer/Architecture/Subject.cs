using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface Subject
    {
        //void Notify();

        string SubjectState { get; set; }
    }
}
