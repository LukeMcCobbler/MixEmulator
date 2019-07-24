namespace EmulatorLib
{

    public class MIXWord
    {
        private const int BYTE_SIZE = 64;
        public bool Sign=false;
        public int[] Bytes=new int[6];
        public int getContents(int FSLeft,int FSRight)
        {
            return getContents(new MIXFieldSpecification(FSLeft,FSRight));
        }
        public int getContents(MIXFieldSpecification fields)
        {
            var retval = 0;
            var counter = 1;
            var L=fields.L==0?1:fields.L;
            for (int cursor = fields.R ; cursor >= L; cursor--)
            {
                retval += (counter * Bytes[cursor]);
                counter *= BYTE_SIZE;
            }
            return retval * ((fields.L == 0 && !Sign) ? -1 : 1);
        }
        

    }
}