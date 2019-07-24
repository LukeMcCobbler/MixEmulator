using System;

namespace EmulatorLib
{
    public class MIXFieldSpecification
    {
        public int L { get; }
        public int R { get; }
        public MIXFieldSpecification(int Left, int Right)
        {
            L = Left;
            R = Right;
        }
        public static implicit operator MIXFieldSpecification(string s) => new MIXFieldSpecification(Int32.Parse(s.Substring(0, 1)), Int32.Parse(s.Substring(2, 1)));
    }
}