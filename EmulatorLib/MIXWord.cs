namespace EmulatorLib
{

    public class MIXWord
    {
        private const int BYTE_SIZE = 64;
        public bool Sign;
        public int[] Bytes;
        public int getContents(int FSLeft,int FSRight)
        {
            return getContents(new MIXFieldSpecification(FSLeft,FSRight));
        }
        public int getContents(MIXFieldSpecification fields)
        {
            var retval = 0;
            var counter = 1;
            for (int cursor = fields.R - 1; cursor > 0; cursor--)
            {
                retval += (counter * Bytes[cursor]);
                counter *= BYTE_SIZE;
            }
            return retval * ((fields.L == 0 && !Sign) ? -1 : 1);
        }
    }
}