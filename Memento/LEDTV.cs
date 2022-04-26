using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class LEDTV
    {
        private string size;
        private string price;
        private bool USBSupport;
    
        public LEDTV(string size, string price, bool USBSupport)
        {
            this.size = size;
            this.price = price;
            this.USBSupport = USBSupport;
        }

        public string GetDetails()
        {
            return "LEDTV [Size=" + size + ", Price=" + price + ", USBSupport=" + USBSupport + "]";
        }
    }
}
