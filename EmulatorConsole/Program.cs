using System;
using System.Collections.Generic;
using EmulatorLib;
namespace EmulatorConsole
{
    class Program
    {
        private const int PROGRAM_START = 2000;
        static void Main(string[] args)
        {
            var mach = new MIXMachine();
            mach.LoadROM(new List<List<int>>(){
                new List<int>(){1,31,16,2,3,8},
                new List<int>(){1,31,16,2,11,8},
                new List<int>(){1,31,16,0,11,8},
                new List<int>(){1,31,16,0,5,8},
                new List<int>(){0,31,16,4,5,8}
            }
                , 2000);
            mach.RunInstruction(2000);
            return;

        }
    }
}
