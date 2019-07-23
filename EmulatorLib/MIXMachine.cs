using System;

namespace EmulatorLib
{
    public class MIXMachine
    {
        public MIXWord[] Memory{get;}
        public MIXMachine()
        {
            Memory=new MIXWord[4000];
        }

        public void RunInstruction(int InstructionAddress)
        {
            var currentInstruction=InstructionAddress;
            while(true)
            {
                var instructionToExecute=decodeInstruction(Memory[currentInstruction]);
            }
        }

        private MIXInstruction decodeInstruction(MIXWord mIXWord)
        {
            throw new NotImplementedException();
        }

    }
}
