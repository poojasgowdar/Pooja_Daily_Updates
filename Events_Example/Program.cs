using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Example
{
    public delegate void WorkPerformedHandler(int hours, WorkType worktype);
    internal class Program
    {
        public event WorkPerformedHandler WorkPerformed;

        public event EventHandler WorkCompleted;
        static void Main(string[] args)
        {

        }
    }
}
