using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface ICompression
    {
        void CompressFolder(string complressedArchiveFileName);
    }

    public class RarCompression : ICompression
    {
        public void CompressFolder(string complressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + complressedArchiveFileName
     + ".rar' file is created");
        }
    }

    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + compressedArchiveFileName
                 + ".zip' file is created");
        }
    }
}
