using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class Kid : IElement
    {
        public string kidName;

        public Kid(string name)
        {
            kidName = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

}
