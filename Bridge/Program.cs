using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ITV sonyTv = new SonyTv();
            AbstractRemoteController sonyRmoteController = new SonyRemoteController(sonyTv);
            sonyRmoteController.SwitchOn();
            sonyRmoteController.SetChannel(101);
            sonyRmoteController.SwitchOff();

            Console.WriteLine();

            AbstractRemoteController samsungRmoteController = new SamsungRemoteController(new SamsungTv());
            samsungRmoteController.SwitchOn();
            samsungRmoteController.SetChannel(202);
            samsungRmoteController.SwitchOff();

            Console.ReadKey();
        }
    }
}
