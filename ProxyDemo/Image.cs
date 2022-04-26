using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    public interface IImage
    {
        void DisplayImage();
    }

    public class RealImage: IImage
    {
        private string Filename { get; set; }

        public RealImage(string filename)
        {
            Filename = filename;
            LoadImageFromDisk();
        }

        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + Filename);
        }

        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + Filename);
        }
    }
}
