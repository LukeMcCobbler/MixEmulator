namespace EmulatorLib
{
    public class MIXInstruction
    {
        public int M{get;}
        public MIXFieldSpecification F{get;}
        public int C{get;}
        public int I{get;}
        public MIXInstruction(int Memory,MIXFieldSpecification FieldSpecicification,int OpCode,int Index){
            M=Memory;
            F=FieldSpecicification;
            C=OpCode;
            I=Index;
        }
                
    }
}