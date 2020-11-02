using System;


namespace ConsoleApp_StudentA2
{
    public class MyException:ApplicationException
    {
        readonly int eid;
        readonly string enm;
        readonly int emks;
        public string emsg;
        public MyException(int id, string nm, int mks, string msg)
        {
            this.eid = id;
            this.enm = nm;
            this.emks = mks;
            this.emsg = msg;
        }
    }
}
