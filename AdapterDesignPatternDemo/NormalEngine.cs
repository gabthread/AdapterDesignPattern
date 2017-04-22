using System;

namespace AdapterDesignPatternDemo
{
    public class NormalEngine : IEngine
    {
        public void StartEngine()
        {
            Console.WriteLine("Normal Engine started...");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Normal Engine Speeded Up ...");
        }

        public void StopEngine()
        {
            Console.WriteLine("Normal Engine Stopped ...");
        }
    }
}
