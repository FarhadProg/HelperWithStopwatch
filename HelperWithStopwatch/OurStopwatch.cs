using System.Diagnostics;

namespace HelperWithStopwatch
{
    public class OurStopwatch
    {
        public readonly Stopwatch _sw;
        public bool IsNull { get; private set; }

        public OurStopwatch(Stopwatch sw)
        {
            _sw = sw;

        }

    }
}