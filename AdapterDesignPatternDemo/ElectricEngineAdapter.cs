namespace AdapterDesignPatternDemo
{
    public class ElectricEngineAdapter : IEngine
    {
        private readonly IElectricObject _electricObject;


        public ElectricEngineAdapter(IElectricObject electricObject)
        {
            _electricObject = electricObject;
        }

        public void StartEngine()
        {
            _electricObject.Connect();
            _electricObject.Activate();
        }

        public void SpeedUp()
        {
            _electricObject.Accelerate();
        }

        public void StopEngine()
        {
            _electricObject.Stop();
        }
    }
}
