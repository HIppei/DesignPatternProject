using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler rsHandler;
        public void NextHandler(Handler rsHandler)
        {
            this.rsHandler = rsHandler;
        }

        public abstract void DispatchRs(long requestedAmount);
    }

    public class TwoThousandHandler : Handler
    {
        public override void DispatchRs(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 2000;

            if (numberOfNotesToBeDispatched > 1)
            {
                Console.WriteLine(numberOfNotesToBeDispatched + " Two Thousand notes are dispatched by TwoThousandHandler");
            }
            else
            {
                Console.WriteLine(numberOfNotesToBeDispatched + " Two Thousand note is dispatched by TwoThousandHandler");
            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;
            if(pendingAmountToBeProcessed > 0)
            {
                rsHandler.DispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

    public class FiveHundredHandler : Handler
    {
        public override void DispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 500;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 500;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.DispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

    public class TwoHundredHandler : Handler
    {
        public override void DispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 200;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by TwoHundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 200;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.DispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

    public class HundredHandler : Handler
    {
        public override void DispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 100;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHandler.DispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

}
