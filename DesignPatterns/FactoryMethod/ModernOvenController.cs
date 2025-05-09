namespace FactoryMethod
{
    public class ModernOvenController : OvenController
    {
        protected override IDeviceConnection CreateConnection() => new TCPConnection();
    }
}