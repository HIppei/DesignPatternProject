using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ATM
    {
        private Handler twoThousandHandler = new TwoThousandHandler();
        private Handler fiveHundredHandler = new FiveHundredHandler();
        private Handler twoHundredHandler = new TwoHundredHandler();
        private Handler hundredHandler = new HundredHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.NextHandler(fiveHundredHandler);
            fiveHundredHandler.NextHandler(twoHundredHandler);
            twoHundredHandler.NextHandler(hundredHandler);
        }

        public void WithDraw(long requestedAmount)
        {
            twoThousandHandler.DispatchRs(requestedAmount);
        }
    }
}
