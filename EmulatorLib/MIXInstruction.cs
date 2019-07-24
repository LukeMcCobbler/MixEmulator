namespace EmulatorLib
{
    public class MIXInstruction
    {
        public int A{get;}
        public int M{get;}
        public MIXFieldSpecification F{get;}
        public int C{get;}
        public int I{get;}
        public MIXInstruction(int Memory,int Address, MIXFieldSpecification FieldSpecicification,int OpCode,int Index){
            M=Memory;
            A=Address;
            F=FieldSpecicification;
            C=OpCode;
            I=Index;
        }
        public override string ToString()
        {
            var retval=string.Format("{0} {1},{2}({3}:{4})",(MIXOpcode)C,A,I,F.L,F.R);
            return retval;
        }
                
    }
}