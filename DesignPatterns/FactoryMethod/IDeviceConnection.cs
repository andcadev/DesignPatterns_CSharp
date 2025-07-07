namespace FactoryMethod
{
    public interface IDeviceConnection
    {
        void Open();
        void Close();
        void SetTemperature(double temperature);
    }
}