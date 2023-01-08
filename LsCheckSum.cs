using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void LsCheckSumEventHandler(object sender, LSCheckSumEventArgs e);

    public class LSCheckSumEventArgs : EventArgs
    {
        public byte result { get; private set; }

        public LSCheckSumEventArgs(byte _result)
        {
            result = _result;
        }
    }
}
