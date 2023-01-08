using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MainClass
    {
        public static void Main()
        {
            byte[] bytes = { 0x01, 0x02, 0x03, 0xF9 };
            Calculator cal = new Calculator(bytes);
            cal.LsCheckSum += Cal_LsCheckSum;
            cal.checkSum();
        }

        private static void Cal_LsCheckSum(object sender, LSCheckSumEventArgs e)
        {
            Console.WriteLine($"하위 바이트 = [ {e.result} ]");
        }
    }
}
