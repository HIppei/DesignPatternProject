using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class AbstractRemoteController
    {
        protected ITV iTv;

        protected AbstractRemoteController(ITV iTv)
        {
            this.iTv = iTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }

    public class SamsungRemoteController : AbstractRemoteController
    {
        public SamsungRemoteController(ITV iTv) :base(iTv)
        {
        }

        public override void SwitchOn()
        {
            iTv.SwitchOn();
        }

        public override void SwitchOff()
        {
            iTv.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            iTv.SetChannel(channelNumber);
        }
    }

    public class SonyRemoteController : AbstractRemoteController
    {
        public SonyRemoteController(ITV iTv) : base(iTv)
        {
        }

        public override void SwitchOn()
        {
            iTv.SwitchOn();
        }

        public override void SwitchOff()
        {
            iTv.SwitchOff();
        }

        public override void SetChannel(int channelNumber)
        {
            iTv.SetChannel(channelNumber);
        }
    }
}
