using System;
using EmulatorLib;
namespace EmulatorConsole
{
    class Program
    {
        private const int PROGRAM_START=2000;
        static void Main(string[] args)
        {
            var mach=new MIXMachine();
            mach.RunInstruction(2000);
            return; 
            
        }
    }
}
