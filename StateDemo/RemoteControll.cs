using System;

namespace StateDemo
{
    public interface IRemoteControll
    {
        void TurnOn();
        void TurnOff();
    }

    public class StateTurnOn : IRemoteControll
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is already turned on. Nothing to do.");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is successfully turned off.");
        }
    }

    public class StateTurnOff : IRemoteControll
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is successfully turned on.");
           
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is already turned off. Nothing to do.");
        }
    }

    public class RemoteController:IRemoteControll
    {
        private IRemoteControll rState;
        private IRemoteControll stateTurnOn = new StateTurnOn();
        private IRemoteControll stateTurnOff = new StateTurnOff();

        public RemoteController()
        {
            rState = new StateTurnOff();
        }

        public void TurnOn()
        {
            rState.TurnOn();
            if (rState is StateTurnOff)
            {
                rState = stateTurnOn;
            }
        
        }

        public void TurnOff()
        {
            rState.TurnOff();
            if (rState is StateTurnOn)
            {
                rState = stateTurnOff;
            }
        }
    }
}
