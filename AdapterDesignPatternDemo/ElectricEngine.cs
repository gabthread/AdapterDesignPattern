using System;

namespace AdapterDesignPatternDemo
{
    public class ElectricEngine : IElectricObject
    {
        private bool _connected = false;
        public void Connect()
        {
            Console.WriteLine("Electric Engine Connected");
            _connected = true;
        }

        public void Activate()
        {
            if(!_connected)
                Console.WriteLine("Electric Engine Cannot be activated because is not connected");
            else
                Console.WriteLine("Electric Engine Activated");
        }

        public void Disconnect()
        {
            if (!_connected)
                Console.WriteLine("Electric Engine Cannot be disconnected because is not connected");
            else
                Console.WriteLine("Electric Engine disconected");
        }

        public void Accelerate()
        {
            if (!_connected)
                Console.WriteLine("Electric Engine Cannot be accelerated because is not connected");
            else
                Console.WriteLine("Electric Engine accelerated");
        }


        public void Stop()
        {
            if (!_connected)
                Console.WriteLine("Electric Engine Cannot be stopped because is not connected");
            else
                Console.WriteLine("Electric Engine stopped");
        }


    }
}
