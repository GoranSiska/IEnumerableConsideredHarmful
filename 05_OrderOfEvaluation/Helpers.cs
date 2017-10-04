using System.Runtime.CompilerServices;

namespace _05_OrderOfEvaluation
{
    public static class Helpers
    {
        public static string Tabs(int n)
        {
            return new string('\t', n);
        }

        public static string GetCaller([CallerMemberName] string caller = null)
        {
            return caller;
        }
    }
}
