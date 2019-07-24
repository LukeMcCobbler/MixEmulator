using System;
using System.Linq;

namespace EmulatorLib
{
    public class MIXMachine
    {
        public MIXWord[] Indexes{get;}
        public MIXWord[] Memory{get;}
        public MIXMachine()
        {
            Memory=new MIXWord[4000];
            Indexes=Enumerable.Range(0,6).Select(i=>new MIXWord()).ToArray();
        }

        public void RunInstruction(int InstructionAddress)
        {
            var currentInstruction=InstructionAddress;
            while(true)
            {
                var instructionToExecute=decodeInstruction(Memory[currentInstruction]);
            }
        }

        private MIXInstruction decodeInstruction(MIXWord Content)
        {
            var A=Content.getContents("0:2");
            var I=Content.getContents("3:3")                                 ;
            var FPacked=Content.getContents("4:4");
            var FR=FPacked%8;
            var FL=(FPacked-FR)/8;
            var F=new MIXFieldSpecification(FL,FR);
            var C=Content.getContents("5:5");
            var MIndexOffset=
        }

    }
}
