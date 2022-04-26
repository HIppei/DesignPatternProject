using System;

namespace StateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemoteControll remoteControll = new RemoteController();

            remoteControll.TurnOff();

            remoteControll.TurnOn();

            remoteControll.TurnOff();

            remoteControll.TurnOff();

            remoteControll.TurnOn();
        }
    }
}
