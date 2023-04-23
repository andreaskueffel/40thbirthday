using LiteDB;

namespace _40thBackend
{
    public class LiteDBContext
    {
        public LiteDatabase DB { get; set; }
        public LiteDBContext()
        {
            Directory.CreateDirectory("data");
            DB = new LiteDatabase("data/lite.db");
        }

    }
}
