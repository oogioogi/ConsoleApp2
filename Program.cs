

namespace ConsoleApp2
{
    public class Calculator
    {
        public event LsCheckSumEventHandler? LsCheckSum = null;

        public byte[] bytes;

        public Calculator(byte[] bytes)
        {
            this.bytes = bytes;
        }

        public delegate void checkSumDelegate(byte[] bytes);
        public void checkSum()
        {
            checkSumDelegate dele = new checkSumDelegate(DoingCheckSum);
            dele.Invoke(bytes);

        }

        public void DoingCheckSum(byte[] bytes)
        {
            byte result = 0x00;
            foreach (var item in bytes)
            {
                result += item;
            }
            LsCheckSum(this, new LSCheckSumEventArgs(result));
        }
    }
}
