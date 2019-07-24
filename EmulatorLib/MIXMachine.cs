using System;
using System.Collections.Generic;
using System.Linq;

namespace EmulatorLib
{
    public class MIXMachine
    {
        public MIXWord[] Indexes { get; }
        public MIXWord[] Memory { get; }
        public MIXMachine()
        {
            Memory =  Enumerable.Range(0, 4000).Select(i => new MIXWord()).ToArray();
            Indexes = Enumerable.Range(0, 7).Select(i => new MIXWord()).ToArray();
        }
        public void LoadROM(List<List<int>> contents, int startIndex)
        {
            for (int i = 0; i < contents.Count; i++)
            {
                var bytes=contents[i];
                var target=Memory[startIndex+i];
                for(int j=0;j<5;j++)
                {
                    target.Sign=bytes[0]==1;
                    target.Bytes[j+1]=bytes[j+1];
                }
            }
        }

        public void RunInstruction(int InstructionAddress)
        {
            var currentInstruction = InstructionAddress;
            while (true)
            {
                var instructionToExecute = decodeInstruction(Memory[currentInstruction]);
                Console.WriteLine(instructionToExecute);
                currentInstruction++;
            }
        }

        private MIXInstruction decodeInstruction(MIXWord Content)
        {
            var A = Content.getContents("0:2");
            var I = Content.getContents("3:3");
            var FPacked = Content.getContents("4:4");
            var FR = FPacked % 8;
            var FL = (FPacked - FR) / 8;
            var F = new MIXFieldSpecification(FL, FR);
            var C = Content.getContents("5:5");
            var MIndexOffSet = (I == 0) ? 0 : Indexes[I].getContents(0, 2);
            var M = A + MIndexOffSet;
            return new MIXInstruction(M,A, F, C, I);
        }

    }
}
