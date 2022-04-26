using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CompressionContext
    {
        private ICompression compression;

        public CompressionContext(ICompression compression)
        {
            this.compression = compression;
        }

        public void SetStrategy(ICompression compression)
        {
            this.compression = compression;
        }

        public void CreateArchive(string compressedArchiveFileName)
        {
            compression.CompressFolder(compressedArchiveFileName);
        }

    }
}
