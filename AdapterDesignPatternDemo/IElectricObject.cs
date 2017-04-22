namespace AdapterDesignPatternDemo
{
    public interface IElectricObject
    {
        void Connect();
        void Activate();
        void Disconnect();
        void Accelerate();

        void Stop();
    }
}
