using System;

namespace AdapterDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Normal Engine
            IEngine normalEngine = new NormalEngine();
            normalEngine.StartEngine();
            normalEngine.SpeedUp();
            normalEngine.StopEngine();

            Console.WriteLine("-----------------------------------------");

            //Use Electric Engine
            IEngine electricEngine = new ElectricEngineAdapter(new ElectricEngine());
            electricEngine.StartEngine();
            electricEngine.SpeedUp();
            electricEngine.StopEngine();

            Console.ReadKey();

        }
    }
}
